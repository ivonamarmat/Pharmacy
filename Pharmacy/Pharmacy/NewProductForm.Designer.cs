
namespace Pharmacy
{
    partial class NewProductForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.numUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.tbPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblTitleProductData = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblKMspp = new System.Windows.Forms.Label();
            this.lblKMspnp = new System.Windows.Forms.Label();
            this.lblEmptyName = new System.Windows.Forms.Label();
            this.lblEmptyQuantity = new System.Windows.Forms.Label();
            this.lblEmptyDescription = new System.Windows.Forms.Label();
            this.lblEmptyManufacturer = new System.Windows.Forms.Label();
            this.lblEmptySellingPrice = new System.Windows.Forms.Label();
            this.lblEmptyPurchasePrice = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(45, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Naziv";
            // 
            // tbName
            // 
            this.tbName.AcceptsTab = true;
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbName.Location = new System.Drawing.Point(249, 95);
            this.tbName.MaxLength = 200;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 22);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(45, 143);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Količina";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(45, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(36, 16);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Opis";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManufacturer.Location = new System.Drawing.Point(45, 345);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(76, 16);
            this.lblManufacturer.TabIndex = 14;
            this.lblManufacturer.Text = "Proizvođač";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellingPrice.Location = new System.Drawing.Point(46, 434);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(102, 16);
            this.lblSellingPrice.TabIndex = 16;
            this.lblSellingPrice.Text = "Prodajna cijena";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(45, 392);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(103, 16);
            this.lblPurchasePrice.TabIndex = 17;
            this.lblPurchasePrice.Text = "Nabavna cijena";
            // 
            // numUpDownQuantity
            // 
            this.numUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numUpDownQuantity.Location = new System.Drawing.Point(249, 136);
            this.numUpDownQuantity.Name = "numUpDownQuantity";
            this.numUpDownQuantity.Size = new System.Drawing.Size(214, 22);
            this.numUpDownQuantity.TabIndex = 1;
            this.numUpDownQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numUpDownQuantity_KeyDown);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbDescription.Location = new System.Drawing.Point(249, 182);
            this.tbDescription.MaxLength = 400;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(214, 130);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            this.tbDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDescription_KeyDown);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(249, 337);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(214, 24);
            this.comboBoxManufacturer.TabIndex = 3;
            this.comboBoxManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxManufacturer_KeyDown);
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbSellingPrice.Location = new System.Drawing.Point(250, 427);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.Size = new System.Drawing.Size(214, 22);
            this.tbSellingPrice.TabIndex = 5;
            this.tbSellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSellingPrice_KeyDown);
            this.tbSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoldPricePrescript_KeyPress);
            // 
            // tbPurchasePrice
            // 
            this.tbPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPurchasePrice.Location = new System.Drawing.Point(249, 385);
            this.tbPurchasePrice.Name = "tbPurchasePrice";
            this.tbPurchasePrice.Size = new System.Drawing.Size(214, 22);
            this.tbPurchasePrice.TabIndex = 4;
            this.tbPurchasePrice.TextChanged += new System.EventHandler(this.tbSoldPriceNoPrescript_TextChanged);
            this.tbPurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPurchasePrice_KeyDown);
            this.tbPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoldPriceNoPrescript_KeyPress);
            // 
            // lblTitleProductData
            // 
            this.lblTitleProductData.AutoSize = true;
            this.lblTitleProductData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitleProductData.Location = new System.Drawing.Point(41, 21);
            this.lblTitleProductData.Name = "lblTitleProductData";
            this.lblTitleProductData.Size = new System.Drawing.Size(172, 24);
            this.lblTitleProductData.TabIndex = 17;
            this.lblTitleProductData.Text = "Podaci o proizvodu";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(292, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Sačuvati";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(383, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Otkazati";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
            // 
            // lblKMspp
            // 
            this.lblKMspp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKMspp.AutoSize = true;
            this.lblKMspp.Location = new System.Drawing.Point(468, 430);
            this.lblKMspp.Name = "lblKMspp";
            this.lblKMspp.Size = new System.Drawing.Size(23, 13);
            this.lblKMspp.TabIndex = 21;
            this.lblKMspp.Text = "KM";
            // 
            // lblKMspnp
            // 
            this.lblKMspnp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKMspnp.AutoSize = true;
            this.lblKMspnp.Location = new System.Drawing.Point(467, 388);
            this.lblKMspnp.Name = "lblKMspnp";
            this.lblKMspnp.Size = new System.Drawing.Size(23, 13);
            this.lblKMspnp.TabIndex = 22;
            this.lblKMspnp.Text = "KM";
            // 
            // lblEmptyName
            // 
            this.lblEmptyName.BackColor = System.Drawing.Color.Red;
            this.lblEmptyName.Location = new System.Drawing.Point(248, 94);
            this.lblEmptyName.Name = "lblEmptyName";
            this.lblEmptyName.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyName.TabIndex = 23;
            // 
            // lblEmptyQuantity
            // 
            this.lblEmptyQuantity.BackColor = System.Drawing.Color.Red;
            this.lblEmptyQuantity.Location = new System.Drawing.Point(248, 135);
            this.lblEmptyQuantity.Name = "lblEmptyQuantity";
            this.lblEmptyQuantity.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyQuantity.TabIndex = 24;
            // 
            // lblEmptyDescription
            // 
            this.lblEmptyDescription.BackColor = System.Drawing.Color.Red;
            this.lblEmptyDescription.Location = new System.Drawing.Point(248, 181);
            this.lblEmptyDescription.Name = "lblEmptyDescription";
            this.lblEmptyDescription.Size = new System.Drawing.Size(216, 132);
            this.lblEmptyDescription.TabIndex = 25;
            // 
            // lblEmptyManufacturer
            // 
            this.lblEmptyManufacturer.BackColor = System.Drawing.Color.Red;
            this.lblEmptyManufacturer.Location = new System.Drawing.Point(248, 336);
            this.lblEmptyManufacturer.Name = "lblEmptyManufacturer";
            this.lblEmptyManufacturer.Size = new System.Drawing.Size(216, 26);
            this.lblEmptyManufacturer.TabIndex = 26;
            // 
            // lblEmptySellingPrice
            // 
            this.lblEmptySellingPrice.BackColor = System.Drawing.Color.Red;
            this.lblEmptySellingPrice.Location = new System.Drawing.Point(249, 426);
            this.lblEmptySellingPrice.Name = "lblEmptySellingPrice";
            this.lblEmptySellingPrice.Size = new System.Drawing.Size(216, 24);
            this.lblEmptySellingPrice.TabIndex = 28;
            // 
            // lblEmptyPurchasePrice
            // 
            this.lblEmptyPurchasePrice.BackColor = System.Drawing.Color.Red;
            this.lblEmptyPurchasePrice.Location = new System.Drawing.Point(248, 384);
            this.lblEmptyPurchasePrice.Name = "lblEmptyPurchasePrice";
            this.lblEmptyPurchasePrice.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyPurchasePrice.TabIndex = 29;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRequiredFields.Location = new System.Drawing.Point(248, 452);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(170, 16);
            this.lblRequiredFields.TabIndex = 30;
            this.lblRequiredFields.Text = "Sva polja su obavezna!";
            // 
            // NewProductForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(515, 542);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lblKMspnp);
            this.Controls.Add(this.lblKMspp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitleProductData);
            this.Controls.Add(this.tbPurchasePrice);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmptyName);
            this.Controls.Add(this.lblEmptyDescription);
            this.Controls.Add(this.numUpDownQuantity);
            this.Controls.Add(this.lblEmptyQuantity);
            this.Controls.Add(this.lblEmptyManufacturer);
            this.Controls.Add(this.lblEmptySellingPrice);
            this.Controls.Add(this.lblEmptyPurchasePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi proizvod";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.NumericUpDown numUpDownQuantity;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.TextBox tbSellingPrice;
        private System.Windows.Forms.TextBox tbPurchasePrice;
        private System.Windows.Forms.Label lblTitleProductData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblKMspp;
        private System.Windows.Forms.Label lblKMspnp;
        private System.Windows.Forms.Label lblEmptyName;
        private System.Windows.Forms.Label lblEmptyQuantity;
        private System.Windows.Forms.Label lblEmptyDescription;
        private System.Windows.Forms.Label lblEmptyManufacturer;
        private System.Windows.Forms.Label lblEmptySellingPrice;
        private System.Windows.Forms.Label lblEmptyPurchasePrice;
        private System.Windows.Forms.Label lblRequiredFields;
    }
}