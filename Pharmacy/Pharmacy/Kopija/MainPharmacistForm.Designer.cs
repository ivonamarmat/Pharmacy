
namespace Pharmacy
{
    partial class MainPharmacistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnNewProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPharmacistForm));
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelProductsHeader = new System.Windows.Forms.Panel();
            this.picBoxProductsHeader = new System.Windows.Forms.PictureBox();
            this.lblProductsHeader = new System.Windows.Forms.Label();
            this.picBoxAZ = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSorting = new System.Windows.Forms.CheckBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOptionRecipient = new System.Windows.Forms.Button();
            this.btnOptionProduct = new System.Windows.Forms.Button();
            this.panelRecipients = new System.Windows.Forms.Panel();
            this.btnNewRecipient = new System.Windows.Forms.Button();
            this.panelReceiptsHeader = new System.Windows.Forms.Panel();
            this.picBoxReceiptsHeader = new System.Windows.Forms.PictureBox();
            this.lblReceiptsHeader = new System.Windows.Forms.Label();
            this.lblRecipientMin = new System.Windows.Forms.Label();
            this.tbRecipientMax = new System.Windows.Forms.TextBox();
            this.tbRecipientsMin = new System.Windows.Forms.TextBox();
            this.lblRecipientMax = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            btnNewProduct = new System.Windows.Forms.Button();
            this.panelProducts.SuspendLayout();
            this.panelProductsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelRecipients.SuspendLayout();
            this.panelReceiptsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceiptsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnNewProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnNewProduct.ForeColor = System.Drawing.Color.Black;
            btnNewProduct.Location = new System.Drawing.Point(492, 400);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new System.Drawing.Size(103, 26);
            btnNewProduct.TabIndex = 3;
            btnNewProduct.Text = "Novi proizvod";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProducts.Controls.Add(this.tbTotalAmount);
            this.panelProducts.Controls.Add(this.lblTotalAmount);
            this.panelProducts.Controls.Add(this.panelProductsHeader);
            this.panelProducts.Controls.Add(this.picBoxAZ);
            this.panelProducts.Controls.Add(this.lblSearch);
            this.panelProducts.Controls.Add(this.tbSearch);
            this.panelProducts.Controls.Add(this.checkBoxSorting);
            this.panelProducts.Controls.Add(this.comboBoxSorting);
            this.panelProducts.Controls.Add(this.lblSorting);
            this.panelProducts.Controls.Add(btnNewProduct);
            this.panelProducts.Location = new System.Drawing.Point(0, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(666, 482);
            this.panelProducts.TabIndex = 0;
            // 
            // panelProductsHeader
            // 
            this.panelProductsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelProductsHeader.Controls.Add(this.picBoxProductsHeader);
            this.panelProductsHeader.Controls.Add(this.lblProductsHeader);
            this.panelProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProductsHeader.Name = "panelProductsHeader";
            this.panelProductsHeader.Size = new System.Drawing.Size(666, 46);
            this.panelProductsHeader.TabIndex = 2;
            // 
            // picBoxProductsHeader
            // 
            this.picBoxProductsHeader.BackgroundImage = global::Pharmacy.Properties.Resources.commercial_products_transp;
            this.picBoxProductsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxProductsHeader.Image = global::Pharmacy.Properties.Resources.commercial_products_transp;
            this.picBoxProductsHeader.Location = new System.Drawing.Point(2, 0);
            this.picBoxProductsHeader.Name = "picBoxProductsHeader";
            this.picBoxProductsHeader.Size = new System.Drawing.Size(49, 47);
            this.picBoxProductsHeader.TabIndex = 6;
            this.picBoxProductsHeader.TabStop = false;
            // 
            // lblProductsHeader
            // 
            this.lblProductsHeader.AutoSize = true;
            this.lblProductsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProductsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductsHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProductsHeader.Location = new System.Drawing.Point(57, 12);
            this.lblProductsHeader.Name = "lblProductsHeader";
            this.lblProductsHeader.Size = new System.Drawing.Size(81, 20);
            this.lblProductsHeader.TabIndex = 5;
            this.lblProductsHeader.Text = "Proizvodi";
            // 
            // picBoxAZ
            // 
            this.picBoxAZ.BackgroundImage = global::Pharmacy.Properties.Resources.sort_az;
            this.picBoxAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAZ.Location = new System.Drawing.Point(199, 84);
            this.picBoxAZ.Name = "picBoxAZ";
            this.picBoxAZ.Size = new System.Drawing.Size(21, 20);
            this.picBoxAZ.TabIndex = 12;
            this.picBoxAZ.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Image = global::Pharmacy.Properties.Resources.bill_receipt;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(248, 66);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Pretraga";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(251, 87);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 20);
            this.tbSearch.TabIndex = 9;
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.AutoSize = true;
            this.checkBoxSorting.Location = new System.Drawing.Point(178, 90);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSorting.TabIndex = 7;
            this.checkBoxSorting.UseVisualStyleBackColor = true;
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Šifra",
            "Naziv",
            "Količina",
            "Proizvođač",
            "Nabavna cijena uz recept",
            "Prodajna cijena uz recept"});
            this.comboBoxSorting.Location = new System.Drawing.Point(31, 87);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSorting.TabIndex = 6;
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.Image = global::Pharmacy.Properties.Resources.bill_receipt;
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(28, 66);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 4;
            this.lblSorting.Text = "Sortiranje";
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnOptionRecipient);
            this.panelMenu.Controls.Add(this.btnOptionProduct);
            this.panelMenu.Location = new System.Drawing.Point(-5, 133);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(218, 436);
            this.panelMenu.TabIndex = 1;
            // 
            // btnOptionRecipient
            // 
            this.btnOptionRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionRecipient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionRecipient.FlatAppearance.BorderSize = 0;
            this.btnOptionRecipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionRecipient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionRecipient.Image = global::Pharmacy.Properties.Resources.receipt_white_transp_button;
            this.btnOptionRecipient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionRecipient.Location = new System.Drawing.Point(6, 81);
            this.btnOptionRecipient.Name = "btnOptionRecipient";
            this.btnOptionRecipient.Size = new System.Drawing.Size(211, 55);
            this.btnOptionRecipient.TabIndex = 27;
            this.btnOptionRecipient.Text = "Računi";
            this.btnOptionRecipient.UseVisualStyleBackColor = false;
            this.btnOptionRecipient.Click += new System.EventHandler(this.btnOptionRecipient_Click);
            // 
            // btnOptionProduct
            // 
            this.btnOptionProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionProduct.FlatAppearance.BorderSize = 0;
            this.btnOptionProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptionProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionProduct.Image = global::Pharmacy.Properties.Resources.commercial_products_transp_button;
            this.btnOptionProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionProduct.Location = new System.Drawing.Point(6, 20);
            this.btnOptionProduct.Name = "btnOptionProduct";
            this.btnOptionProduct.Size = new System.Drawing.Size(211, 55);
            this.btnOptionProduct.TabIndex = 26;
            this.btnOptionProduct.Text = "Proizvodi";
            this.btnOptionProduct.UseVisualStyleBackColor = false;
            this.btnOptionProduct.Click += new System.EventHandler(this.btnOptionProduct_Click);
            // 
            // panelRecipients
            // 
            this.panelRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecipients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRecipients.Controls.Add(this.panelProducts);
            this.panelRecipients.Controls.Add(this.btnNewRecipient);
            this.panelRecipients.Controls.Add(this.panelReceiptsHeader);
            this.panelRecipients.Controls.Add(this.lblRecipientMin);
            this.panelRecipients.Controls.Add(this.tbRecipientMax);
            this.panelRecipients.Controls.Add(this.tbRecipientsMin);
            this.panelRecipients.Controls.Add(this.lblRecipientMax);
            this.panelRecipients.Location = new System.Drawing.Point(211, -2);
            this.panelRecipients.Name = "panelRecipients";
            this.panelRecipients.Size = new System.Drawing.Size(666, 482);
            this.panelRecipients.TabIndex = 17;
            // 
            // btnNewRecipient
            // 
            this.btnNewRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRecipient.Location = new System.Drawing.Point(579, 482);
            this.btnNewRecipient.Name = "btnNewRecipient";
            this.btnNewRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnNewRecipient.TabIndex = 23;
            this.btnNewRecipient.Text = "Novi račun";
            this.btnNewRecipient.UseVisualStyleBackColor = true;
            // 
            // panelReceiptsHeader
            // 
            this.panelReceiptsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceiptsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelReceiptsHeader.Controls.Add(this.picBoxReceiptsHeader);
            this.panelReceiptsHeader.Controls.Add(this.lblReceiptsHeader);
            this.panelReceiptsHeader.Location = new System.Drawing.Point(0, 3);
            this.panelReceiptsHeader.Name = "panelReceiptsHeader";
            this.panelReceiptsHeader.Size = new System.Drawing.Size(666, 43);
            this.panelReceiptsHeader.TabIndex = 22;
            // 
            // picBoxReceiptsHeader
            // 
            this.picBoxReceiptsHeader.BackgroundImage = global::Pharmacy.Properties.Resources.receipt_white_transp;
            this.picBoxReceiptsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxReceiptsHeader.Location = new System.Drawing.Point(15, 9);
            this.picBoxReceiptsHeader.Name = "picBoxReceiptsHeader";
            this.picBoxReceiptsHeader.Size = new System.Drawing.Size(27, 29);
            this.picBoxReceiptsHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReceiptsHeader.TabIndex = 6;
            this.picBoxReceiptsHeader.TabStop = false;
            // 
            // lblReceiptsHeader
            // 
            this.lblReceiptsHeader.AutoSize = true;
            this.lblReceiptsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReceiptsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceiptsHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReceiptsHeader.Location = new System.Drawing.Point(57, 9);
            this.lblReceiptsHeader.Name = "lblReceiptsHeader";
            this.lblReceiptsHeader.Size = new System.Drawing.Size(65, 20);
            this.lblReceiptsHeader.TabIndex = 5;
            this.lblReceiptsHeader.Text = "Računi";
            // 
            // lblRecipientMin
            // 
            this.lblRecipientMin.AutoSize = true;
            this.lblRecipientMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblRecipientMin.Location = new System.Drawing.Point(42, 104);
            this.lblRecipientMin.Name = "lblRecipientMin";
            this.lblRecipientMin.Size = new System.Drawing.Size(195, 18);
            this.lblRecipientMin.TabIndex = 17;
            this.lblRecipientMin.Text = "Najmanji iznos računa (KM):";
            // 
            // tbRecipientMax
            // 
            this.tbRecipientMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientMax.Location = new System.Drawing.Point(298, 147);
            this.tbRecipientMax.Name = "tbRecipientMax";
            this.tbRecipientMax.Size = new System.Drawing.Size(189, 20);
            this.tbRecipientMax.TabIndex = 20;
            // 
            // tbRecipientsMin
            // 
            this.tbRecipientsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientsMin.Location = new System.Drawing.Point(298, 104);
            this.tbRecipientsMin.Name = "tbRecipientsMin";
            this.tbRecipientsMin.Size = new System.Drawing.Size(189, 20);
            this.tbRecipientsMin.TabIndex = 18;
            // 
            // lblRecipientMax
            // 
            this.lblRecipientMax.AutoSize = true;
            this.lblRecipientMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblRecipientMax.Location = new System.Drawing.Point(42, 146);
            this.lblRecipientMax.Name = "lblRecipientMax";
            this.lblRecipientMax.Size = new System.Drawing.Size(186, 18);
            this.lblRecipientMax.TabIndex = 19;
            this.lblRecipientMax.Text = "Najveći iznos računa (KM):";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImage = global::Pharmacy.Properties.Resources.logo;
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogo.Location = new System.Drawing.Point(-5, -2);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(218, 138);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmount.Location = new System.Drawing.Point(251, 177);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(141, 20);
            this.tbTotalAmount.TabIndex = 27;
            this.tbTotalAmount.TextChanged += new System.EventHandler(this.tbTotalAmount_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalAmount.Location = new System.Drawing.Point(28, 176);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(189, 18);
            this.lblTotalAmount.TabIndex = 26;
            this.lblTotalAmount.Text = "Ukupan iznos računa (KM):";
            // 
            // MainPharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 479);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelRecipients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPharmacistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.MainPharmacistForm_Load);
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            this.panelProductsHeader.ResumeLayout(false);
            this.panelProductsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelRecipients.ResumeLayout(false);
            this.panelRecipients.PerformLayout();
            this.panelReceiptsHeader.ResumeLayout(false);
            this.panelReceiptsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceiptsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelProductsHeader;
        private System.Windows.Forms.PictureBox picBoxProductsHeader;
        private System.Windows.Forms.Label lblProductsHeader;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.CheckBox checkBoxSorting;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox picBoxAZ;
        private System.Windows.Forms.Panel panelRecipients;
        private System.Windows.Forms.Label lblRecipientMin;
        private System.Windows.Forms.TextBox tbRecipientMax;
        private System.Windows.Forms.TextBox tbRecipientsMin;
        private System.Windows.Forms.Label lblRecipientMax;
        private System.Windows.Forms.Panel panelReceiptsHeader;
        private System.Windows.Forms.PictureBox picBoxReceiptsHeader;
        private System.Windows.Forms.Label lblReceiptsHeader;
        private System.Windows.Forms.Button btnNewRecipient;
        private System.Windows.Forms.Button btnOptionProduct;
        private System.Windows.Forms.Button btnOptionRecipient;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}