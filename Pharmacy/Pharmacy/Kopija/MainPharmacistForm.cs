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
    public partial class MainPharmacistForm : Form
    {

        //List<Panel> panels = new List<Panel>();

        Color SELECTED = System.Drawing.Color.MediumSlateBlue;
        Color NONSELECTED =System.Drawing.Color.FromArgb(128, 128, 255);

        public MainPharmacistForm()
        {
            InitializeComponent();
        }

        private void MainPharmacistForm_Load(object sender, EventArgs e)
        {

            //panels.Add(panelProducts);
            //panels.Add(panelRecipients);

            panelProducts.BringToFront();
            panelRecipients.SendToBack();
            btnOptionProduct.BackColor = SELECTED;



        }

        private void hidePanelRecipients()
        {
            panelProductsHeader.Visible = true;
            lblRecipientMin.Visible = false;
            lblRecipientMax.Visible = false;
            tbRecipientsMin.Visible = false;
            tbRecipientMax.Visible = false;
            lblTotalAmount.Visible = false;
            tbTotalAmount.Visible = false;
        }


        private void showPanelRecipients()
        {
            panelProductsHeader.Visible = false;
            lblRecipientMin.Visible = true;
            lblRecipientMax.Visible = true;
            tbRecipientsMin.Visible = true;
            tbRecipientMax.Visible = true;
            lblTotalAmount.Visible = true;
            tbTotalAmount.Visible = true;
        }

        private void btnOptionProduct_Click(object sender, EventArgs e)
        {

            panelProducts.Visible = true;
            hidePanelRecipients();
            //panelProducts.BringToFront();

            btnOptionProduct.BackColor = SELECTED;
            btnOptionRecipient.BackColor = NONSELECTED;
            
        }

        private void btnOptionRecipient_Click(object sender, EventArgs e)
        {

            panelProducts.Visible = false;
            showPanelRecipients();
            //panelRecipients.BringToFront();
            
            btnOptionProduct.BackColor = NONSELECTED;
            btnOptionRecipient.BackColor = SELECTED;


        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            new NewProductForm().Show();
        }

        private void tbTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
