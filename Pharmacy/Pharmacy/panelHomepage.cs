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
    public partial class panelHomepage : UserControl
    {
        private static bool serbian;
        private static bool english;
        private static bool classic;
        private static bool gray;
        private static bool blackAndWhite;


        public panelHomepage()
        {
            InitializeComponent();
            setCurrentUser();
        }

        public void setCurrentUser()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    lblUsername.Text = context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().Username;
                }
            } catch
            {
                Console.WriteLine("HAHAHAHA");

            }
        }
        public void rbSerbianCheck()
        {
            rbSerbian.Checked = true;
        }

        public void rbEnglishCheck()
        {
            rbEnglish.Checked = true;
        }

        public void rbTheme1Check()
        {
            rbTheme1.Checked = true;
        }

        public void rbTheme2Check()
        {
            rbTheme2.Checked = true;
        }

        public void rbTheme3Check()
        {
            rbTheme3.Checked = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            new LogInForm().Show();
        }

        public void setTheme(Theme theme)
        {
            panelHomepageHeader.BackColor = panelHomepageFooter.BackColor = theme.headerFooterColor;
            BackColor = theme.backColor;
            lblHomepageHeader.ForeColor = theme.foreColorMain;
        }

        public void setHomepageTitleColor(Color color)
        {
            lblHomepageHeader.ForeColor = color;
        }
        //private void rbSerbian_CheckedChanged(object sender, EventArgs e)
        //{
        //    setSerbian();
        //    serbian = true;
        //    english = false;
           
        //}

        //private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        //{
        //    setEnglish();
        //    english = true;
        //    serbian = false;
        //}

        public void setSerbian()
        {
            lblHomepageHeader.Text = "Početna strana";
            lblCurrentUser.Text = "Trenutno prijavljeni korisnik:";
            lblSettings.Text = "Podešavanja aplikacije";
            lblChooseLanguage.Text = "Jezik:";
            lblChooseTheme.Text = "Tema:";
            rbSerbian.Text = "Srpski";
            rbEnglish.Text = "Engleski";
            rbTheme1.Text = "Klasična";
            rbTheme2.Text = "Siva";
            rbTheme3.Text = "Crno-bijela";
            btnLogout.Text = "Odjava";

            //if (this.Parent is MainAdminForm form1)
            //{
            //    form1.setSerbian();
            //}
            //else if (this.Parent is MainPharmacistForm form2)
            //{
            //    form2.setSerbian();
            //}
        }

        public void setEnglish()
        {
            lblHomepageHeader.Text = "Homepage";
            lblCurrentUser.Text = "Current user:";
            lblSettings.Text = "Application settings";
            lblChooseLanguage.Text = "Language:";
            lblChooseTheme.Text = "Theme:";
            rbSerbian.Text = "Serbian";
            rbEnglish.Text = "English";
            rbTheme1.Text = "Classic";
            rbTheme2.Text = "Gray";
            rbTheme3.Text = @"Black /& white";
            btnLogout.Text = "Logout";
            //if (this.Parent is MainAdminForm form1)
            //{
            //    form1.setEnglish();
            //}
            //else if (this.Parent is MainPharmacistForm form2)
            //{
            //    form2.setEnglish();
            //}

        }
      
       

      

        private void setUserSettings()
        {
            byte language = (serbian == true) ? (byte)2 : (byte)1;
            byte theme;
            if (classic == true)
            {
                theme = (byte)1;
            }
            else if (gray == true)
            {
                theme = (byte)2;
            }
            else
            {
                theme = (byte)3;
            }

            using(var context=new PharmacyDB())
            {
                User user = context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault();
                user.AppSettings.Language = language;
                user.AppSettings.Theme = theme;
                context.SaveChanges();
            }
        }
        public static bool isClassic()
        {
            return classic;
        }

        public static bool isDark()
        {
            return gray;
        }

        public static bool isBlackAndWhite()
        {
            return blackAndWhite;
        }

        public static bool isSerbian()
        {
            return serbian;
        }

        public static bool isEnglish()
        {
            return english;
        }

        public void setUserSettings(byte language,byte theme)
        {
            using (var context = new PharmacyDB())
            {
                var settingsId = context.AppSettingss.Where(a => a.Language == language && a.Theme == theme).FirstOrDefault().AppSettingsId;
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.AppSettingsId=settingsId;
                context.SaveChanges();
            }
        }
        public void setUserLanguage(byte language)
        {
            using(var context=new PharmacyDB())
            {
                var theme = context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme;
                var settings = context.AppSettingss.Where(a => a.Theme == theme && a.Language == language).FirstOrDefault();
                if (settings == null)
                {
                    settings= new AppSettings() { Theme = theme, Language = language };
                    context.AppSettingss.Add(settings);
                }
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettingsId = settings.AppSettingsId;
                context.SaveChanges();
            }
        }

        public void setUserTheme(byte theme)
        {
            using (var context = new PharmacyDB())
            {
                var language = context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language;
                var settings = context.AppSettingss.Where(a => a.Theme == theme && a.Language == language).FirstOrDefault();
                if (settings == null)
                {
                    settings = new AppSettings() { Theme = theme, Language = language };
                    context.AppSettingss.Add(settings);
                }
                context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettingsId = settings.AppSettingsId;
                context.SaveChanges();
            }
        }
        private void rbSerbian_CheckedChanged(object sender, EventArgs e)
        {
            setSerbian();
            serbian = true;
            english = false;
            if (this.ParentForm is MainAdminForm form1)
            {
                form1.setSerbian();
            }
            else if (this.ParentForm is MainPharmacistForm form2)
            {
                form2.setSerbian();
            }

            setUserLanguage(1);

            
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            setEnglish();
            serbian = false;
            english = true;
            if(this.ParentForm is MainAdminForm form1)
            {
                form1.setEnglish();
            }
            else if(this.ParentForm is MainPharmacistForm form2)
            {
                form2.setEnglish();
            }
            setUserLanguage(2);
        }

        private void rbTheme1_CheckedChanged(object sender, EventArgs e)
        {
            classic = true;
            gray = false;
            blackAndWhite = false;
            setTheme(Constants.CLASSIC_THEME);
            if (this.ParentForm is MainAdminForm form1)
            {
                form1.setThemeAdmin(Constants.CLASSIC_THEME);
            }
            else if (this.ParentForm is MainPharmacistForm form2)
            {
                form2.setThemePharmacist(Constants.CLASSIC_THEME);
            }
            setUserTheme(1);
        }

        private void rbTheme2_CheckedChanged(object sender, EventArgs e)
        {
            gray = true;
            classic = false;
            blackAndWhite = false;
            setTheme(Constants.GRAY_THEME);
            if (this.ParentForm is MainAdminForm form1)
            {
                form1.setThemeAdmin(Constants.GRAY_THEME);
            }
            else if (this.ParentForm is MainPharmacistForm form2)
            {
                form2.setThemePharmacist(Constants.GRAY_THEME);
            }
            setUserTheme(2);
        }

        private void rbTheme3_CheckedChanged(object sender, EventArgs e)
        {
            gray = false;
            classic = false;
            blackAndWhite = true;
            setTheme(Constants.BLACK_AND_WHITE);
            if (this.ParentForm is MainAdminForm form1)
            {
                form1.setThemeAdmin(Constants.BLACK_AND_WHITE);
            }
            else if (this.ParentForm is MainPharmacistForm form2)
            {
                form2.setThemePharmacist(Constants.BLACK_AND_WHITE);
            }
            setUserTheme(3);
        }

        private void rbSerbian_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rbEnglish.Focus();
                e.Handled = true;
            }
        }

        private void rbEnglish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                rbSerbian.Focus();
                e.Handled = true;
            }
        }

        private void rbTheme1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rbTheme2.Focus();
                e.Handled = true;
            }
        }

        private void rbTheme2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rbTheme3.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                rbTheme1.Focus();
                e.Handled = true;
            }
        }

        private void rbTheme3_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Left)
            {
                rbTheme2.Focus();
                e.Handled = true;
            }
        }
    }
}
