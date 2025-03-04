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
    public partial class MainAdminForm : Form
    {
        public static Theme themeAdmin=new Theme();
        // User[] users = new Arrray<User>();
        static bool userSelected;
        static bool homepageSelected;
        
        public MainAdminForm()
        {
            //panelUsers = new panelUsers();
            //this.Controls.Add(panelUsers);
            InitializeComponent();
            setTheme();
            selectBtnHomepage();
            //setLanguage();
            
           
            //loadUsers();
           
        }

        private void setLanguage()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var language = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language;
                    if (language ==1)
                    {
                        setEnglish();
                        //rbEnglish.Checked = true;
                    }
                    else
                    {
                        setSerbian();
                        //rbSerbian.Checked = true;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Admin language " + ex.Message);
            }
        }
        public void setSerbian()
        {
            btnHomepage.Text = "Početna strana";
            btnOptionUsers.Text = "Korisnici";
            this.Text = "Glavna admin forma";
            
            panelUsers.setSerbian();
            panelHomepageAdmin.setSerbian();
        }

        public void setEnglish()
        {
            btnHomepage.Text = "Homepage";
            btnOptionUsers.Text = "Users";
            this.Text = "Main admin form";
            
            panelUsers.setEnglish();
            panelHomepageAdmin.setEnglish();

        }

        public void setAdminSettings(byte language,byte theme)
        {
            switch (language)
            {
                case 1:
                    {
                        rbSerbianCheck();
                        break;
                    }
                case 2:
                    {
                        rbEnglishCheck();
                        break;
                    }
            }

            switch (theme)
            {
                case 1:
                    {
                        rbTheme1Check();
                        break;
                    }
                case 2:
                    {
                        rbTheme2Check();
                        break;
                    }

                case 3:
                    {
                        rbTheme3Check();
                        break;
                    }
            }
        }

        public void rbSerbianCheck()
        {
            this.panelHomepageAdmin.rbSerbianCheck();
        }

        public void rbEnglishCheck()
        {
            this.panelHomepageAdmin.rbEnglishCheck();
        }

        public void rbTheme1Check()
        {
            this.panelHomepageAdmin.rbTheme1Check();
        }

        public void rbTheme2Check()
        {
            this.panelHomepageAdmin.rbTheme2Check();
        }

        public void rbTheme3Check()
        {
            this.panelHomepageAdmin.rbTheme3Check();
        }
        private Color selectedColor()
        {
            return themeAdmin.selectedButtonColor;
        }

        private Color nonSelectedColor()
        {
            return themeAdmin.menuColor;
        }

        private void setTheme()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    byte userTheme = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme;

                    switch (userTheme)
                    {
                        case 1:
                            {
                                setThemeAdmin(Constants.CLASSIC_THEME);
                                //rbTheme1.Checked = true;
                                break;
                            }
                        case 2:
                            {
                                setThemeAdmin(Constants.GRAY_THEME);
                                //rbTheme2.Checked = true;
                                break;
                            }
                        case 3:
                            {
                                setThemeAdmin(Constants.BLACK_AND_WHITE);
                                //rbTheme3.Checked = true;
                                break;
                            }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Theme: " + ex.Message);
            }
        }
        public void setThemeAdmin(Theme theme)
        {
            themeAdmin = theme; 
            btnHomepage.BackColor = themeAdmin.selectedButtonColor;
            //panelHomepageAdmin.BackColor = panelUsers.BackColor = theme.backColor;
            //panelHomepageAdmin.ForeColor = panelUsers.ForeColor =   theme.foreColorText;
            panelMenu.BackColor = theme.menuColor;
            panelMenu.ForeColor = theme.foreColorMain;
            btnHomepage.Font = btnOptionUsers.Font = new Font(theme.font, 12);
            this.BackColor = theme.backColor;
            panelHomepageAdmin.setTheme(theme);
            panelUsers.setTheme(theme);
            btnOptionUsers.BackColor = themeAdmin.menuColor;
            

            //panelHomepageAdmin.setHomepageTitleColor(theme.foreColorMain);
            //panelUsers.setTitleUsersColor(theme.foreColorMain);
        }

        
        private void selectBtnHomepage()
        {
            panelHomepageAdmin.BringToFront();
            btnHomepage.BackColor = selectedColor();
            btnOptionUsers.BackColor = nonSelectedColor();
            
        }

        private void selectBtnUsers()
        {
            panelUsers.BringToFront();
            btnOptionUsers.BackColor = selectedColor();
            btnHomepage.BackColor = nonSelectedColor();
            
        }
        private void btnOptionUsers_Click(object sender, EventArgs e)
        {
            panelUsers.BringToFront();
            btnHomepage.BackColor = themeAdmin.menuColor;
            btnOptionUsers.BackColor = themeAdmin.selectedButtonColor;
            homepageSelected = false;
            userSelected = true;
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            panelHomepageAdmin.BringToFront();
            btnHomepage.BackColor = themeAdmin.selectedButtonColor;
            btnOptionUsers.BackColor = themeAdmin.menuColor;
            homepageSelected = true;
            userSelected = false;
        }

        private void btnOptionUsers_MouseEnter(object sender, EventArgs e)
        {
            btnOptionUsers.BackColor = themeAdmin.selectedButtonColor;
            if (homepageSelected == false) btnHomepage.BackColor = themeAdmin.menuColor;
        }
        private void btnHomepage_MouseEnter(object sender, EventArgs e)
        {
            btnHomepage.BackColor = themeAdmin.selectedButtonColor;
            if (userSelected == false) btnOptionUsers.BackColor = themeAdmin.menuColor;
        }

        private void btnOptionUsers_MouseLeave(object sender, EventArgs e)
        {
            if (userSelected == false)
            {
                btnOptionUsers.BackColor = themeAdmin.menuColor;
            }
            

        }
        private void btnHomepage_MouseLeave(object sender, EventArgs e)
        {
            if (homepageSelected == false)
            {
                btnHomepage.BackColor = themeAdmin.menuColor;
            }

        }

       

 

        public void loadUsers()
        {
            panelUsers.loadUsers();
            try
            {

                using (var context = new PharmacyDB())
                {
                   User[] users = context.Users.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load users: " + ex.Message);
            }
        }

        private void searchUsers()
        {
           
        }
        private void panelUsers1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            panelHomepageAdmin.BringToFront();
            btnHomepage.BackColor = themeAdmin.selectedButtonColor;
        }

        private void btnHomepage_Click(object sender, MouseEventArgs e)
        {
            panelHomepageAdmin.BringToFront();
            btnHomepage.BackColor = themeAdmin.selectedButtonColor;
            btnOptionUsers.BackColor =  themeAdmin.menuColor;
            homepageSelected = true;
            userSelected = false;
        }

        private void rbSerbian_CheckedChanged(object sender, EventArgs e)
        {
            setSerbian();
            using (var context = new PharmacyDB())
            {
               context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language=2;
                context.SaveChanges();
            }
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            setEnglish();
            using (var context = new PharmacyDB())
            {
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language = 1;
                context.SaveChanges();
            }
        }

        private void rbTheme1_CheckedChanged(object sender, EventArgs e)
        {
            setThemeAdmin(Constants.CLASSIC_THEME);
            using (var context = new PharmacyDB())
            {
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme = 1;
                context.SaveChanges();
            }
        }

        private void rbTheme2_CheckedChanged(object sender, EventArgs e)
        {
            setThemeAdmin(Constants.GRAY_THEME);
            using (var context = new PharmacyDB())
            {
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme = 2;
                context.SaveChanges();
            }
        }

        private void rbTheme3_CheckedChanged(object sender, EventArgs e)
        {
            setThemeAdmin(Constants.BLACK_AND_WHITE);
            using (var context = new PharmacyDB())
            {
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme = 3;
                context.SaveChanges();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
                    }

        private void panelUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
