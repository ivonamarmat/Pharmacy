using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class LogInForm : Form
    {

        string ERR_LOGIN;
        string EMPTY = "";
        string ERR_LOGIN_HEADER;
        
        public LogInForm()
        {
            InitializeComponent();
            hideAllRedLabels();
            cbLanguage.SelectedItem = cbLanguage.Items[1];//SRPSKI JEZIK
            setSerbian();
        }

        private void setSerbian()
        {
           this.Text=btnLogin.Text = "Prijava";
           ERR_LOGIN = "Neispravno korisničko ime ili lozinka!";
           ERR_LOGIN_HEADER = "Greška u prijavi";
        }

        private void setEnglish()
        {
            this.Text=btnLogin.Text = "Login";
            ERR_LOGIN = "Incorrect username or password!";
            ERR_LOGIN_HEADER = "Login error";
        }

        private void setTheme(Theme theme)
        {
            btnLogin.Font = new Font(theme.font,theme.fontSize);
        }
        private void hideAllRedLabels()
        {
            lblRedWrongUsername.Hide();
            lblRedWrongPassword.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string message = "";

            /*TEST KASNIJE OBRISATI*/

            if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
                message = ERR_LOGIN;

            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
                message = ERR_LOGIN;

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine("CRVEE");
                lblRedWrongUsername.Show();
                lblRedWrongPassword.Show();
                MessageBox.Show(message, ERR_LOGIN_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                if (isUserValid(tbUsername.Text))
            {
                lblRedWrongUsername.Hide();
                using (var context =new PharmacyDB())
                {

                    string password = Functions.generatePasswordHash(tbPassword.Text.Trim());
                    //Console.WriteLine(password +"   "+Functions)
                    string correctPassword = context.Users.Where(u => u.Username == tbUsername.Text.Trim()).FirstOrDefault().Password;
                    Console.WriteLine(password + "   " + correctPassword);
                    if (password == correctPassword)
                    {
                        hideAllRedLabels();
                        Program.currentUserId = context.Users.Where(u => u.Username == tbUsername.Text.Trim()).FirstOrDefault().UserId;

                        context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language = (cbLanguage.SelectedIndex == 0) ? (byte)2 : (byte)1;
                        byte language = (cbLanguage.SelectedIndex == 0) ? (byte)2 : (byte)1;
                        byte theme = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme;
                        context.SaveChanges();

                        if (context.Users.Where(u => u.Username == tbUsername.Text.Trim()).FirstOrDefault().UserRole == 1)
                        {
                            MainAdminForm aForm = new MainAdminForm();
                            aForm.setAdminSettings(language, theme);
                            aForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            Console.WriteLine("USP");
                            
                            MainPharmacistForm pForm = new MainPharmacistForm();
                            pForm.setPharmacistSettings(language, theme);
                            pForm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show(ERR_LOGIN_HEADER, ERR_LOGIN_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
                

        }

      private bool isUserValid(string username)
        {
            bool returnValue = false;
            try
            {
                using (var context = new PharmacyDB())
                {
                    if (context.Users.Where(u => u.Username == username).FirstOrDefault() != null)
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Login error: " + ex.Message);
            }
            return returnValue;
        }

        private void tbPassword_DragEnter(object sender, DragEventArgs e)
        {
            btnLogin_Click(sender, e);
        }

       

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLanguage.SelectedIndex==0)
            {
               lblLanguage.Text= "Language:";
                btnLogin.Text = "Login";
                this.Text = "Login";
                setEnglish();
            }

            else if (cbLanguage.SelectedIndex==1)
            {
                lblLanguage.Text = "Jezik:";
                btnLogin.Text = "Prijava";
                this.Text = "Prijava";
                setSerbian();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbPassword.Focus();
                e.Handled = true;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
            else if (e.KeyCode == Keys.Down)
            {
                btnLogin.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbUsername.Focus();
                e.Handled = true;
            }
        }
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tbPassword.Focus();
                e.Handled = true;
            }
        }
    }
}
