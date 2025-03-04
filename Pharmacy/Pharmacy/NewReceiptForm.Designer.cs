
namespace Pharmacy
{
    partial class NewReceiptForm
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
            this.lblSorting = new System.Windows.Forms.Label();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.checkBoxSorting = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.picBoxAZ = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SoldPriceWithoutPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.dgReceiptItems = new System.Windows.Forms.DataGridView();
            this.dgrColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrColumnManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(27, 24);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 20;
            this.lblSorting.Text = "Sortiranje";
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
            this.comboBoxSorting.Location = new System.Drawing.Point(30, 45);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSorting.TabIndex = 21;
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.AutoSize = true;
            this.checkBoxSorting.Location = new System.Drawing.Point(177, 48);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSorting.TabIndex = 22;
            this.checkBoxSorting.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(663, 48);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 20);
            this.tbSearch.TabIndex = 23;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // picBoxAZ
            // 
            this.picBoxAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAZ.Image = global::Pharmacy.Properties.Resources.sort_az;
            this.picBoxAZ.Location = new System.Drawing.Point(198, 42);
            this.picBoxAZ.Name = "picBoxAZ";
            this.picBoxAZ.Size = new System.Drawing.Size(21, 20);
            this.picBoxAZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAZ.TabIndex = 24;
            this.picBoxAZ.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(660, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Pretraga";
            // 
            // SoldPriceWithoutPrescription
            // 
            this.SoldPriceWithoutPrescription.HeaderText = "Cijena(KM)";
            this.SoldPriceWithoutPrescription.Name = "SoldPriceWithoutPrescription";
            this.SoldPriceWithoutPrescription.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Proizvođač";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Opis";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Količina";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Naziv";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductKey
            // 
            this.ProductKey.HeaderText = "Šifra";
            this.ProductKey.Name = "ProductKey";
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
            this.SoldPriceWithoutPrescription});
            this.dgProducts.Location = new System.Drawing.Point(30, 98);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(774, 99);
            this.dgProducts.TabIndex = 19;
            this.dgProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProducts_CellMouseDoubleClick);
            // 
            // dgReceiptItems
            // 
            this.dgReceiptItems.AllowUserToAddRows = false;
            this.dgReceiptItems.AllowUserToOrderColumns = true;
            this.dgReceiptItems.AllowUserToResizeColumns = false;
            this.dgReceiptItems.AllowUserToResizeRows = false;
            this.dgReceiptItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReceiptItems.ColumnHeadersHeight = 50;
            this.dgReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrColumnId,
            this.dgrColumnName,
            this.dgrColumnDescription,
            this.dgrColumnManufacturer,
            this.dgrColumnPrice,
            this.dgrColumnNumber});
            this.dgReceiptItems.Location = new System.Drawing.Point(30, 265);
            this.dgReceiptItems.Name = "dgReceiptItems";
            this.dgReceiptItems.Size = new System.Drawing.Size(775, 52);
            this.dgReceiptItems.TabIndex = 26;
            this.dgReceiptItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReceiptItems_CellClick);
            this.dgReceiptItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReceiptItems_CellEndEdit);
            // 
            // dgrColumnId
            // 
            this.dgrColumnId.HeaderText = "Šifra";
            this.dgrColumnId.Name = "dgrColumnId";
            // 
            // dgrColumnName
            // 
            this.dgrColumnName.HeaderText = "Naziv";
            this.dgrColumnName.Name = "dgrColumnName";
            this.dgrColumnName.ReadOnly = true;
            // 
            // dgrColumnDescription
            // 
            this.dgrColumnDescription.HeaderText = "Opis";
            this.dgrColumnDescription.Name = "dgrColumnDescription";
            this.dgrColumnDescription.ReadOnly = true;
            // 
            // dgrColumnManufacturer
            // 
            this.dgrColumnManufacturer.HeaderText = "Proizvođač";
            this.dgrColumnManufacturer.Name = "dgrColumnManufacturer";
            this.dgrColumnManufacturer.ReadOnly = true;
            // 
            // dgrColumnPrice
            // 
            this.dgrColumnPrice.HeaderText = "Cijena/kom (KM)";
            this.dgrColumnPrice.Name = "dgrColumnPrice";
            this.dgrColumnPrice.ReadOnly = true;
            // 
            // dgrColumnNumber
            // 
            this.dgrColumnNumber.HeaderText = "Broj artikala";
            this.dgrColumnNumber.Name = "dgrColumnNumber";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.Location = new System.Drawing.Point(704, 396);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.tbTotalPrice.TabIndex = 27;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTotalAmount.Location = new System.Drawing.Point(701, 377);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(92, 16);
            this.lblTotalAmount.TabIndex = 28;
            this.lblTotalAmount.Text = "Ukupan iznos:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(704, 422);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 29;
            this.btnConfirm.Text = "Završi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // NewReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.dgReceiptItems);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.picBoxAZ);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.checkBoxSorting);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.dgProducts);
            this.Name = "NewReceiptForm";
            this.Text = "Novi račun";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.CheckBox checkBoxSorting;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox picBoxAZ;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldPriceWithoutPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductKey;
        private System.Windows.Forms.DataGridView dgProducts;
       
        private System.Windows.Forms.DataGridView dgReceiptItems;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrColumnNumber;
    }
}