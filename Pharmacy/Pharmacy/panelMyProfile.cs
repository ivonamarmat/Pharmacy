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
    public partial class panelMyProfile : UserControl
    {
       
        public panelMyProfile()
        {
            InitializeComponent();
        }

      
       public void setSerbian()
       {
            lblMyProfileHeader.Text = "Proizvodi";
            
           
       }

        public void setEnglish()
        {
            lblMyProfileHeader.Text = "Products";
            
           

        }


        public void setTheme(Theme theme)
        {
            panelProductsHeader.BackColor = panelProductsFooter.BackColor = theme.headerFooterColor;
            BackColor = theme.backColor;
            lblMyProfileHeader.ForeColor = theme.foreColorMain;
            lblMyProfileHeader.Font = new Font(theme.font, 12);
           
            
        }
       

        public void setPanelColors(Color headerFooterColor, Color backColor)
        {
            panelProductsHeader.BackColor = panelProductsFooter.BackColor = headerFooterColor;
            this.BackColor = backColor;
            
        }

        public void setPanelFont(FontFamily font)
        {
            
            lblMyProfileHeader.Font = new Font(font, (float)Convert.ToInt32(lblMyProfileHeader.Font.Size));
           
            //btnNewProduct.Font= new Font(font, (float)Convert.ToInt32(btnNewProduct.Font.Size));
            
        }

        private void setPanelProperties(Color headerFooterColor, Color backColor, FontFamily font)
        {
            setPanelColors(headerFooterColor, backColor);
            setPanelFont(font);
        }

        
        

       
       
      

       

      

        private void btnPassword_Click(object sender, EventArgs e)
        {

        }
    }
    }

