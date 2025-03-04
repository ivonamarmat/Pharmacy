using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    
    public partial class ChangePasswordForm : Form
    {
        
       
        public ChangePasswordForm()
        {
            InitializeComponent();
            hideAllRedLabels();
            setEnglish();
        }


        private void setSerbian()
        {
            this.Text = "Novi proizvod";
            
            lblOldPassword.Text = "Naziv";
           
            lblNewPassword.Text = "Nabavna cijena";
            lblConfirmNewPassword.Text = "Prodajna cijena";
            btnSave.Text = "Sačuvaj";
            btnCancel.Text = "Otkaži";    
        }

        private void setEnglish()
        {
            this.Text = "Change password";
           
            lblOldPassword.Text = "Old password";
            
            lblNewPassword.Text = "Purchase price";
            lblConfirmNewPassword.Text = "Selling price";
            btnSave.Text = "Save";
            btnCancel.Text = "Cancel";
        }


       

        private void hideAllRedLabels()
        {
            lblEmptyOldPassword.Hide();
            
            lblEmptyConfirmPassword.Hide();
            lblEmptyNewPassword.Hide();      
        }

       
       


       


        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = Functions.generatePasswordHash(tbOldPassword.Text.Trim());
            string newPassword = tbNewPassword.Text;
            string confirmNewPassword = tbConfirmPassword.Text;
            //if (newPassword == confirmNewPassword)
            //{

            //}
        }


      
       

      

        private void tbSoldPricePrescript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isSpecificCharacter(e.KeyChar) || Functions.isLetterString(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
