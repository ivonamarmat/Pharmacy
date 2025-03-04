using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pharmacy
{

    public partial class MainPharmacistForm : Form
    {

        public static Theme themePharmacist = new Theme();
        List<Panel> panels = new List<Panel>();

        static Color SELECTED = themePharmacist.selectedButtonColor;
        static Color NONSELECTED = themePharmacist.menuColor;

        public static List<Product> products=new List<Product>();
        static bool productSelected;
        static bool homepageSelected;
        static bool receiptSelected;

        //Color NONSELECTED = System.Drawing.Color.FromArgb(255, 100, 20);

        public MainPharmacistForm()
        {
            
           InitializeComponent();
           setTheme();

            using(var context=new PharmacyDB())
            {
                products = context.Products.ToList();
            }
            //panelProducts = new panelProducts();
          
        }

       public void setSerbian()
       {
            btnOptionHomepage.Text = "Početna strana";
            btnOptionProduct.Text = "Proizvodi";
            btnOptionReceipt.Text = "Računi";
       

            panelHomepage.setSerbian();
            panelProducts.setSerbian();
            panelReceipts.setSerbian();
       }

       public void setEnglish()
       {
            btnOptionHomepage.Text = "Homepage";
            btnOptionProduct.Text = "Products";
            btnOptionReceipt.Text = "Receipts";
            
            panelHomepage.setEnglish();
            panelProducts.setEnglish();
            panelReceipts.setEnglish();
        }

        private void setTheme()
        {
            using (var context = new PharmacyDB())
            {
                byte userTheme = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Theme;

                switch (userTheme)
                {
                    case 1:
                        {
                            setThemePharmacist(Constants.CLASSIC_THEME);
                            break;
                        }
                    case 2:
                        {
                            setThemePharmacist(Constants.GRAY_THEME);
                            break;
                        }
                    case 3:
                        {
                            setThemePharmacist(Constants.BLACK_AND_WHITE);
                            break;
                        }
                }
            }
        }


    
        public void setThemePharmacist(Theme theme)
       {
            themePharmacist = theme;
            btnOptionHomepage.BackColor = themePharmacist.selectedButtonColor;
            panelMenu.BackColor = btnOptionProduct.BackColor=btnOptionReceipt.BackColor= theme.menuColor;
            panelMenu.ForeColor = btnOptionHomepage.ForeColor = btnOptionProduct.ForeColor = btnOptionReceipt.ForeColor = theme.foreColorMain;
            btnOptionHomepage.Font = btnOptionProduct.Font = btnOptionReceipt.Font = new Font(theme.font,12);
            panelHomepage.setTheme(theme);
            panelProducts.setTheme(theme);
            panelReceipts.setTheme(theme);
            
       }

        public void setPharmacistSettings(byte language, byte theme)
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
            this.panelHomepage.rbSerbianCheck();
        }

        public void rbEnglishCheck()
        {
            this.panelHomepage.rbEnglishCheck();
        }

        public void rbTheme1Check()
        {
            this.panelHomepage.rbTheme1Check();
        }

        public void rbTheme2Check()
        {
            this.panelHomepage.rbTheme2Check();
        }

        public void rbTheme3Check()
        {
            this.panelHomepage.rbTheme3Check();
        }


        public void  setClassicTheme()
        {
            themePharmacist = Constants.CLASSIC_THEME;
           
        }

        public void setGrayTheme()
        {
            themePharmacist = Constants.GRAY_THEME;
        }

        public void setBlackAndWhiteTheme()
        {
            themePharmacist = Constants.BLACK_AND_WHITE;
        }
        private void MainPharmacistForm_Load(object sender, EventArgs e)
        {
            panelHomepage.BringToFront();
            btnOptionHomepage.BackColor =themePharmacist.selectedButtonColor;
            
        }

    
        private void btnOptionProduct_Click(object sender, EventArgs e)
        {
            panelProducts.BringToFront();
            btnOptionProduct.BackColor = themePharmacist.selectedButtonColor;
            btnOptionReceipt.BackColor = themePharmacist.menuColor;
            btnOptionHomepage.BackColor=themePharmacist.menuColor;
            productSelected = true;
            homepageSelected = receiptSelected = false;

        }

        private void btnOptionReceipt_Click(object sender, EventArgs e)
        {
            panelReceipts.BringToFront();
            btnOptionProduct.BackColor = btnOptionHomepage.BackColor= themePharmacist.menuColor;
            btnOptionReceipt.BackColor = themePharmacist.selectedButtonColor;
            receiptSelected = true;
            homepageSelected = productSelected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHomepage.BringToFront();
            btnOptionHomepage.BackColor = Constants.SELECTED;
            btnOptionProduct.BackColor = Constants.NONSELECTED;
            btnOptionReceipt.BackColor = Constants.NONSELECTED;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Dodati za zatvaranje forme.
            new LogInForm().Show();
            

        }

        private void btnOptionHomepage_MouseEnter(object sender, EventArgs e)
        {
            
            //panelHomepage.BringToFront();
            //btnOptionHomepage.BackColor = themePharmacist.selectedButtonColor;
            //btnOptionProduct.BackColor = btnOptionReceipt.BackColor = theme.menuColor;
            
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            panelNewReceipt.BringToFront();
        }

        private void btnOptionHomepage_Click(object sender, EventArgs e)
        {
            panelHomepage.BringToFront();
            btnOptionHomepage.BackColor = themePharmacist.selectedButtonColor;
            btnOptionProduct.BackColor = btnOptionReceipt.BackColor = themePharmacist.menuColor;
            homepageSelected = true;
            productSelected = receiptSelected = false;
        }

        private void btnOptionProduct_MouseEnter(object sender, EventArgs e)
        {
            btnOptionProduct.BackColor = themePharmacist.selectedButtonColor;
        }

        private void btnOptionReceipt_MouseEnter(object sender, EventArgs e)
        {
            btnOptionReceipt.BackColor = themePharmacist.selectedButtonColor;
        }

        private void btnOptionHomepage_MouseHover(object sender, EventArgs e)
        {
            btnOptionHomepage.BackColor = themePharmacist.selectedButtonColor;
        }

        private void btnOptionHomepage_MouseLeave(object sender, EventArgs e)
        {
            if (homepageSelected == false)
            {
                btnOptionHomepage.BackColor = themePharmacist.menuColor;
            }
            
        }

        private void btnOptionProduct_MouseLeave(object sender, EventArgs e)
        {
            if (productSelected == false)
            {
                btnOptionProduct.BackColor = themePharmacist.menuColor;
            }
        }

        private void btnOptionReceipt_MouseLeave(object sender, EventArgs e)
        {
            if (receiptSelected == false)
            {
                btnOptionReceipt.BackColor = themePharmacist.menuColor;
            }
        }

        private void panelHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}
