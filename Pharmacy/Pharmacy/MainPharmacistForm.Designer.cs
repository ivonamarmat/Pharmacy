
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPharmacistForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOptionHomepage = new System.Windows.Forms.Button();
            this.btnOptionReceipt = new System.Windows.Forms.Button();
            this.btnOptionProduct = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHomepage = new Pharmacy.panelHomepage();
            this.panelProducts = new Pharmacy.panelProducts();
            this.panelReceipts = new Pharmacy.panelReceipts();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.panelMenu.Controls.Add(this.btnOptionHomepage);
            this.panelMenu.Controls.Add(this.btnOptionReceipt);
            this.panelMenu.Controls.Add(this.btnOptionProduct);
            this.panelMenu.Location = new System.Drawing.Point(0, 138);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 346);
            this.panelMenu.TabIndex = 1;
            // 
            // btnOptionHomepage
            // 
            this.btnOptionHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOptionHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionHomepage.FlatAppearance.BorderSize = 0;
            this.btnOptionHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptionHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionHomepage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionHomepage.Image = global::Pharmacy.Properties.Resources.home51;
            this.btnOptionHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionHomepage.Location = new System.Drawing.Point(0, 20);
            this.btnOptionHomepage.Name = "btnOptionHomepage";
            this.btnOptionHomepage.Size = new System.Drawing.Size(211, 55);
            this.btnOptionHomepage.TabIndex = 28;
            this.btnOptionHomepage.Text = " Početna strana";
            this.btnOptionHomepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptionHomepage.UseVisualStyleBackColor = false;
            this.btnOptionHomepage.Click += new System.EventHandler(this.btnOptionHomepage_Click);
            this.btnOptionHomepage.MouseEnter += new System.EventHandler(this.btnOptionHomepage_MouseEnter);
            this.btnOptionHomepage.MouseLeave += new System.EventHandler(this.btnOptionHomepage_MouseLeave);
            this.btnOptionHomepage.MouseHover += new System.EventHandler(this.btnOptionHomepage_MouseHover);
            // 
            // btnOptionReceipt
            // 
            this.btnOptionReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOptionReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionReceipt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOptionReceipt.FlatAppearance.BorderSize = 0;
            this.btnOptionReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionReceipt.Image = global::Pharmacy.Properties.Resources.receipt_4240;
            this.btnOptionReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionReceipt.Location = new System.Drawing.Point(0, 132);
            this.btnOptionReceipt.Name = "btnOptionReceipt";
            this.btnOptionReceipt.Size = new System.Drawing.Size(211, 55);
            this.btnOptionReceipt.TabIndex = 27;
            this.btnOptionReceipt.Text = " Računi";
            this.btnOptionReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptionReceipt.UseVisualStyleBackColor = false;
            this.btnOptionReceipt.Click += new System.EventHandler(this.btnOptionReceipt_Click);
            this.btnOptionReceipt.MouseEnter += new System.EventHandler(this.btnOptionReceipt_MouseEnter);
            this.btnOptionReceipt.MouseLeave += new System.EventHandler(this.btnOptionReceipt_MouseLeave);
            // 
            // btnOptionProduct
            // 
            this.btnOptionProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOptionProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionProduct.FlatAppearance.BorderSize = 0;
            this.btnOptionProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptionProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionProduct.Image = global::Pharmacy.Properties.Resources.commercial_products_transp_button;
            this.btnOptionProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionProduct.Location = new System.Drawing.Point(0, 76);
            this.btnOptionProduct.Name = "btnOptionProduct";
            this.btnOptionProduct.Size = new System.Drawing.Size(211, 55);
            this.btnOptionProduct.TabIndex = 26;
            this.btnOptionProduct.Text = "Proizvodi";
            this.btnOptionProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptionProduct.UseVisualStyleBackColor = false;
            this.btnOptionProduct.Click += new System.EventHandler(this.btnOptionProduct_Click);
            this.btnOptionProduct.MouseEnter += new System.EventHandler(this.btnOptionProduct_MouseEnter);
            this.btnOptionProduct.MouseLeave += new System.EventHandler(this.btnOptionProduct_MouseLeave);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogo.Image = global::Pharmacy.Properties.Resources.logo;
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(211, 138);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // panelHomepage
            // 
            this.panelHomepage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panelHomepage.Location = new System.Drawing.Point(210, 0);
            this.panelHomepage.Name = "panelHomepage";
            this.panelHomepage.Size = new System.Drawing.Size(819, 484);
            this.panelHomepage.TabIndex = 2;
            this.panelHomepage.Load += new System.EventHandler(this.panelHomepage_Load);
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panelProducts.Location = new System.Drawing.Point(210, 3);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(812, 481);
            this.panelProducts.TabIndex = 37;
            // 
            // panelReceipts
            // 
            this.panelReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            this.panelReceipts.Location = new System.Drawing.Point(210, 0);
            this.panelReceipts.Name = "panelReceipts";
            this.panelReceipts.Size = new System.Drawing.Size(812, 484);
            this.panelReceipts.TabIndex = 5;
            // 
            // MainPharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 484);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHomepage);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelReceipts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPharmacistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.MainPharmacistForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOptionProduct;
        private System.Windows.Forms.Button btnOptionReceipt;
        private System.Windows.Forms.Button btnOptionHomepage;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private panelHomepage panelHomepage;
       
        private panelReceipts panelReceipts;
        private panelProducts panelProducts=new panelProducts();

        public panelNewReceipt panelNewReceipt;
        //private panelProducts panelProducts1;
        //private panelProducts panelProducts1;
    }
}