
namespace Pharmacy
{
    partial class panelNewReceipt
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
            this.lblNewReceiptHeader = new System.Windows.Forms.Label();
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
            this.SoldPriceWithoutPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSorting = new System.Windows.Forms.Label();
            this.panelProductsFooter = new System.Windows.Forms.Panel();
            this.picBoxAZ = new System.Windows.Forms.PictureBox();
            this.dgReceipt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelProductsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProductsHeader
            // 
            this.panelProductsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelProductsHeader.Controls.Add(this.picBoxProductsHeader);
            this.panelProductsHeader.Controls.Add(this.lblNewReceiptHeader);
            this.panelProductsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProductsHeader.Name = "panelProductsHeader";
            this.panelProductsHeader.Size = new System.Drawing.Size(846, 46);
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
            // lblNewReceiptHeader
            // 
            this.lblNewReceiptHeader.AutoSize = true;
            this.lblNewReceiptHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewReceiptHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewReceiptHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNewReceiptHeader.Location = new System.Drawing.Point(57, 12);
            this.lblNewReceiptHeader.Name = "lblNewReceiptHeader";
            this.lblNewReceiptHeader.Size = new System.Drawing.Size(93, 20);
            this.lblNewReceiptHeader.TabIndex = 5;
            this.lblNewReceiptHeader.Text = "Novi račun";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(670, 103);
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
            this.SoldPriceWithoutPrescription});
            this.dgProducts.Location = new System.Drawing.Point(36, 166);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(775, 52);
            this.dgProducts.TabIndex = 18;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            this.dgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellContentClick);
            this.dgProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProducts_CellMouseDoubleClick);
            this.dgProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProducts_CellMouseDown);
            this.dgProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgProducts_EditingControlShowing);
            // 
            // ProductKey
            // 
            this.ProductKey.HeaderText = "Šifra";
            this.ProductKey.Name = "ProductKey";
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
            // SoldPriceWithoutPrescription
            // 
            this.SoldPriceWithoutPrescription.HeaderText = "Prodajna cijena(KM)";
            this.SoldPriceWithoutPrescription.Name = "SoldPriceWithoutPrescription";
            this.SoldPriceWithoutPrescription.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(667, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Pretraga";
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(33, 79);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 13;
            this.lblSorting.Text = "Sortiranje";
            // 
            // panelProductsFooter
            // 
            this.panelProductsFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelProductsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductsFooter.Location = new System.Drawing.Point(0, 494);
            this.panelProductsFooter.Name = "panelProductsFooter";
            this.panelProductsFooter.Size = new System.Drawing.Size(846, 35);
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
            // dgReceipt
            // 
            this.dgReceipt.AllowUserToAddRows = false;
            this.dgReceipt.AllowUserToOrderColumns = true;
            this.dgReceipt.AllowUserToResizeColumns = false;
            this.dgReceipt.AllowUserToResizeRows = false;
            this.dgReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReceipt.ColumnHeadersHeight = 50;
            this.dgReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Količina,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dgReceipt.Location = new System.Drawing.Point(36, 411);
            this.dgReceipt.Name = "dgReceipt";
            this.dgReceipt.Size = new System.Drawing.Size(677, 53);
            this.dgReceipt.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Proizvođač";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Prodajna cijena(KM)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(762, 424);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Završi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelNewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgReceipt);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.panelProductsFooter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.picBoxAZ);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.checkBoxSorting);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.panelProductsHeader);
            this.Name = "panelNewReceipt";
            this.Size = new System.Drawing.Size(846, 529);
            this.panelProductsHeader.ResumeLayout(false);
            this.panelProductsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProductsHeader;
        private System.Windows.Forms.PictureBox picBoxProductsHeader;
        private System.Windows.Forms.Label lblNewReceiptHeader;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldPriceWithoutPrescription;
        private System.Windows.Forms.DataGridView dgReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnConfirm;

        //private System.Windows.Forms.Button btnNewProduct;
    }
}
