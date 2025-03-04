
namespace Pharmacy
{
    partial class panelProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelProductsHeader = new System.Windows.Forms.Panel();
            this.picBoxProductsHeader = new System.Windows.Forms.PictureBox();
            this.lblProductsHeader = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSorting = new System.Windows.Forms.CheckBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.ProductKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSorting = new System.Windows.Forms.Label();
            this.panelProductsFooter = new System.Windows.Forms.Panel();
            this.picBoxAZ = new System.Windows.Forms.PictureBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.panelProductsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProductsHeader
            // 
            this.panelProductsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelProductsHeader.Controls.Add(this.picBoxProductsHeader);
            this.panelProductsHeader.Controls.Add(this.lblProductsHeader);
            this.panelProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProductsHeader.Name = "panelProductsHeader";
            this.panelProductsHeader.Size = new System.Drawing.Size(812, 46);
            this.panelProductsHeader.TabIndex = 3;
            // 
            // picBoxProductsHeader
            // 
            this.picBoxProductsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxProductsHeader.Image = global::Pharmacy.Properties.Resources.commercial_products_transp_button;
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
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(636, 103);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 20);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.AutoSize = true;
            this.checkBoxSorting.Location = new System.Drawing.Point(183, 103);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSorting.TabIndex = 15;
            this.checkBoxSorting.UseVisualStyleBackColor = true;
            this.checkBoxSorting.CheckedChanged += new System.EventHandler(this.checkBoxSorting_CheckedChanged);
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Šifra",
            "Naziv",
            "Količina",
            "Cijena"});
            this.comboBoxSorting.Location = new System.Drawing.Point(36, 100);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSorting.TabIndex = 14;
            this.comboBoxSorting.SelectedValueChanged += new System.EventHandler(this.comboBoxSorting_SelectedValueChanged);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToOrderColumns = true;
            this.dgProducts.AllowUserToResizeColumns = false;
            this.dgProducts.AllowUserToResizeRows = false;
            this.dgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.ColumnHeadersHeight = 50;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductKey,
            this.ProductName,
            this.Quantity,
            this.Description,
            this.Manufacturer,
            this.PurchasePrice,
            this.SellingPrice});
            this.dgProducts.Location = new System.Drawing.Point(36, 166);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(741, 52);
            this.dgProducts.TabIndex = 18;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            this.dgProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProducts_CellMouseDoubleClick);
            // 
            // ProductKey
            // 
            this.ProductKey.HeaderText = "Šifra";
            this.ProductKey.Name = "ProductKey";
            this.ProductKey.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Naziv";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Količina";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Opis";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Proizvođač";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Nabavna cijena(KM)";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.HeaderText = "Prodajna cijena(KM)";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(633, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Pretraga";
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(33, 79);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 13;
            this.lblSorting.Text = "Sortiranje";
            // 
            // panelProductsFooter
            // 
            this.panelProductsFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductsFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelProductsFooter.Location = new System.Drawing.Point(0, 320);
            this.panelProductsFooter.Name = "panelProductsFooter";
            this.panelProductsFooter.Size = new System.Drawing.Size(812, 35);
            this.panelProductsFooter.TabIndex = 21;
            // 
            // picBoxAZ
            // 
            this.picBoxAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAZ.Image = global::Pharmacy.Properties.Resources.sort_az;
            this.picBoxAZ.Location = new System.Drawing.Point(204, 97);
            this.picBoxAZ.Name = "picBoxAZ";
            this.picBoxAZ.Size = new System.Drawing.Size(21, 20);
            this.picBoxAZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAZ.TabIndex = 17;
            this.picBoxAZ.TabStop = false;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProduct.AutoSize = true;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewProduct.Location = new System.Drawing.Point(687, 278);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(90, 25);
            this.btnNewProduct.TabIndex = 22;
            this.btnNewProduct.Text = "Novi proizvod";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // panelProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.panelProductsFooter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.picBoxAZ);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.checkBoxSorting);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.panelProductsHeader);
            this.Name = "panelProducts";
            this.Size = new System.Drawing.Size(812, 355);
            this.panelProductsHeader.ResumeLayout(false);
            this.panelProductsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProductsHeader;
        private System.Windows.Forms.PictureBox picBoxProductsHeader;
        private System.Windows.Forms.Label lblProductsHeader;
        private System.Windows.Forms.PictureBox picBoxAZ;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.CheckBox checkBoxSorting;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelProductsFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.Button btnNewProduct;
        //private System.Windows.Forms.Button btnNewProduct;
    }
}
