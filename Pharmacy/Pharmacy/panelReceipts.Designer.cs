
namespace Pharmacy
{
    partial class panelReceipts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReceiptsHeader = new System.Windows.Forms.Label();
            this.panelReceiptsHeader = new System.Windows.Forms.Panel();
            this.picBoxReceiptsHeader = new System.Windows.Forms.PictureBox();
            this.dgReceipts = new System.Windows.Forms.DataGridView();
            this.SerialNumberr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pharmacist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.panelReceiptsFooter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.picBoxAZ = new System.Windows.Forms.PictureBox();
            this.checkBoxSorting = new System.Windows.Forms.CheckBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.panelReceiptsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceiptsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceiptsHeader
            // 
            this.lblReceiptsHeader.AutoSize = true;
            this.lblReceiptsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReceiptsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceiptsHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReceiptsHeader.Location = new System.Drawing.Point(57, 12);
            this.lblReceiptsHeader.Name = "lblReceiptsHeader";
            this.lblReceiptsHeader.Size = new System.Drawing.Size(65, 20);
            this.lblReceiptsHeader.TabIndex = 5;
            this.lblReceiptsHeader.Text = "Računi";
            // 
            // panelReceiptsHeader
            // 
            this.panelReceiptsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelReceiptsHeader.Controls.Add(this.picBoxReceiptsHeader);
            this.panelReceiptsHeader.Controls.Add(this.lblReceiptsHeader);
            this.panelReceiptsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceiptsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReceiptsHeader.Name = "panelReceiptsHeader";
            this.panelReceiptsHeader.Size = new System.Drawing.Size(812, 46);
            this.panelReceiptsHeader.TabIndex = 23;
            // 
            // picBoxReceiptsHeader
            // 
            this.picBoxReceiptsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxReceiptsHeader.Image = global::Pharmacy.Properties.Resources.receipt_4240;
            this.picBoxReceiptsHeader.Location = new System.Drawing.Point(9, 3);
            this.picBoxReceiptsHeader.Name = "picBoxReceiptsHeader";
            this.picBoxReceiptsHeader.Size = new System.Drawing.Size(42, 40);
            this.picBoxReceiptsHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxReceiptsHeader.TabIndex = 6;
            this.picBoxReceiptsHeader.TabStop = false;
            // 
            // dgReceipts
            // 
            this.dgReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumberr,
            this.ReceiptKey,
            this.DateOfCreation,
            this.Pharmacist,
            this.Amount});
            this.dgReceipts.Location = new System.Drawing.Point(36, 183);
            this.dgReceipts.Name = "dgReceipts";
            this.dgReceipts.Size = new System.Drawing.Size(741, 45);
            this.dgReceipts.TabIndex = 34;
            // 
            // SerialNumberr
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialNumberr.DefaultCellStyle = dataGridViewCellStyle1;
            this.SerialNumberr.HeaderText = "R.B.";
            this.SerialNumberr.Name = "SerialNumberr";
            // 
            // ReceiptKey
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceiptKey.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReceiptKey.HeaderText = "Šifra";
            this.ReceiptKey.Name = "ReceiptKey";
            // 
            // DateOfCreation
            // 
            this.DateOfCreation.HeaderText = "Datum kreiranja";
            this.DateOfCreation.Name = "DateOfCreation";
            // 
            // Pharmacist
            // 
            this.Pharmacist.HeaderText = "Farmaceut";
            this.Pharmacist.Name = "Pharmacist";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Iznos (KM)";
            this.Amount.Name = "Amount";
            // 
            // btnNewReceipt
            // 
            this.btnNewReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewReceipt.Location = new System.Drawing.Point(664, 305);
            this.btnNewReceipt.Name = "btnNewReceipt";
            this.btnNewReceipt.Size = new System.Drawing.Size(113, 33);
            this.btnNewReceipt.TabIndex = 35;
            this.btnNewReceipt.Text = "Novi račun";
            this.btnNewReceipt.UseVisualStyleBackColor = true;
            this.btnNewReceipt.Click += new System.EventHandler(this.btnNewReceipt_Click);
            // 
            // panelReceiptsFooter
            // 
            this.panelReceiptsFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelReceiptsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReceiptsFooter.Location = new System.Drawing.Point(0, 501);
            this.panelReceiptsFooter.Name = "panelReceiptsFooter";
            this.panelReceiptsFooter.Size = new System.Drawing.Size(812, 35);
            this.panelReceiptsFooter.TabIndex = 22;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(633, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 42;
            this.lblSearch.Text = "Pretraga";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(636, 103);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 20);
            this.tbSearch.TabIndex = 39;
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.BackColor = System.Drawing.Color.Transparent;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(33, 79);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 36;
            this.lblSorting.Text = "Sortiranje";
            // 
            // picBoxAZ
            // 
            this.picBoxAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAZ.Image = global::Pharmacy.Properties.Resources.sort_az;
            this.picBoxAZ.Location = new System.Drawing.Point(205, 97);
            this.picBoxAZ.Name = "picBoxAZ";
            this.picBoxAZ.Size = new System.Drawing.Size(21, 20);
            this.picBoxAZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAZ.TabIndex = 45;
            this.picBoxAZ.TabStop = false;
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.AutoSize = true;
            this.checkBoxSorting.Location = new System.Drawing.Point(184, 103);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSorting.TabIndex = 44;
            this.checkBoxSorting.UseVisualStyleBackColor = true;
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Datum",
            "Farmaceut",
            "Iznos(KM)"});
            this.comboBoxSorting.Location = new System.Drawing.Point(36, 100);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSorting.TabIndex = 43;
            // 
            // panelReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.picBoxAZ);
            this.Controls.Add(this.checkBoxSorting);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.panelReceiptsFooter);
            this.Controls.Add(this.btnNewReceipt);
            this.Controls.Add(this.dgReceipts);
            this.Controls.Add(this.panelReceiptsHeader);
            this.Location = new System.Drawing.Point(0, 1);
            this.Name = "panelReceipts";
            this.Size = new System.Drawing.Size(812, 536);
            this.panelReceiptsHeader.ResumeLayout(false);
            this.panelReceiptsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceiptsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxReceiptsHeader;
        private System.Windows.Forms.Label lblReceiptsHeader;
        private System.Windows.Forms.Panel panelReceiptsHeader;
        private System.Windows.Forms.DataGridView dgReceipts;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumberr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pharmacist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnNewReceipt;
        private System.Windows.Forms.Panel panelReceiptsFooter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.PictureBox picBoxAZ;
        private System.Windows.Forms.CheckBox checkBoxSorting;
        private System.Windows.Forms.ComboBox comboBoxSorting;
    }
}
