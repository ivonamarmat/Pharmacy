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
        public static Theme theme;
       // User[] users = new Arrray<User>();

        public MainAdminForm()
        {
            theme = new Theme();
            InitializeComponent();
            setTheme();
            selectBtnHomepage();
            setLanguage();
            //loadUsers();
           
        }

        private void setLanguage()
        {
            using (var context = new PharmacyDB())
            {
                var language = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language;
                if (language == (byte)1)
                {
                    setEnglish();
                }
                else
                {
                    setSerbian();
                }
            }
        }
        private void setSerbian()
        {
            btnHomepage.Text = "Početna strana";
            btnOptionUsers.Text = "Korisnici";
            this.Text = "Glavna admin forma";
            panelUsers.setSerbian();
            panelHomepageAdmin.setSerbian();
        }

        private void setEnglish()
        {
            btnHomepage.Text = "Homepage";
            btnOptionUsers.Text = "Users";
            this.Text = "Main admin form";
            panelUsers.setEnglish();
            panelHomepageAdmin.setEnglish();

        }

        
        private Color selectedColor()
        {
            return theme.selectedButtonColor;
        }

        private Color nonSelectedColor()
        {
            return theme.menuColor;
        }

        private void setTheme()
        {
           using(var context=new PharmacyDB())
            {
                byte userTheme = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme;

                switch (userTheme)
                {
                    case 1:
                        {
                            setThemeAdmin(Constants.CLASSIC_THEME);
                            break;
                        }
                    case 2:
                        {
                            setThemeAdmin(Constants.GRAY_THEME);
                            break;
                        }
                    case 3:
                        {
                            setThemeAdmin(Constants.BLACK_AND_WHITE);
                            break;
                        }
                }
            }
        }
        private void setThemeAdmin(Theme theme)
        {
            panelHomepageAdmin.BackColor = panelUsers.BackColor = theme.backColor;
            panelHomepageAdmin.ForeColor = panelUsers.ForeColor =   theme.foreColorText;
            panelMenu.BackColor = btnHomepage.BackColor = btnOptionUsers.BackColor = btnSettings.BackColor= theme.menuColor;
            panelMenu.ForeColor = theme.foreColorMain;
            this.BackColor = theme.backColor;
            panelHomepageAdmin.setTheme(theme);
            panelUsers.setTheme(theme);
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
            selectBtnUsers();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            selectBtnHomepage(); 
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

        }

        private void btnHomepage_MouseClick(object sender, MouseEventArgs e)
        {
            btnHomepage.BackColor = selectedColor();
            btnOptionUsers.BackColor = nonSelectedColor();
        }
    }
}
