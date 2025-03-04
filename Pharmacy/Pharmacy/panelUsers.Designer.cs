
namespace Pharmacy
{
    partial class panelUsers
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
            this.panelUsersHeader = new System.Windows.Forms.Panel();
            this.picBoxProductsHeader = new System.Windows.Forms.PictureBox();
            this.lblUsersHeader = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSorting = new System.Windows.Forms.CheckBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.panelUsersFooter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUsersHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsersHeader
            // 
            this.panelUsersHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelUsersHeader.Controls.Add(this.picBoxProductsHeader);
            this.panelUsersHeader.Controls.Add(this.lblUsersHeader);
            this.panelUsersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUsersHeader.Name = "panelUsersHeader";
            this.panelUsersHeader.Size = new System.Drawing.Size(812, 46);
            this.panelUsersHeader.TabIndex = 6;
            // 
            // picBoxProductsHeader
            // 
            this.picBoxProductsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxProductsHeader.Image = global::Pharmacy.Properties.Resources.usertransp50;
            this.picBoxProductsHeader.Location = new System.Drawing.Point(2, 0);
            this.picBoxProductsHeader.Name = "picBoxProductsHeader";
            this.picBoxProductsHeader.Size = new System.Drawing.Size(49, 47);
            this.picBoxProductsHeader.TabIndex = 6;
            this.picBoxProductsHeader.TabStop = false;
            // 
            // lblUsersHeader
            // 
            this.lblUsersHeader.AutoSize = true;
            this.lblUsersHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsersHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsersHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUsersHeader.Location = new System.Drawing.Point(57, 12);
            this.lblUsersHeader.Name = "lblUsersHeader";
            this.lblUsersHeader.Size = new System.Drawing.Size(76, 20);
            this.lblUsersHeader.TabIndex = 5;
            this.lblUsersHeader.Text = "Korisnici";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewUser.AutoSize = true;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewUser.Location = new System.Drawing.Point(685, 286);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(90, 25);
            this.btnNewUser.TabIndex = 7;
            this.btnNewUser.Text = "Novi korisnik";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Username,
            this.FirstName,
            this.LastName,
            this.PID,
            this.Role});
            this.dgUsers.Location = new System.Drawing.Point(34, 208);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.Size = new System.Drawing.Size(741, 47);
            this.dgUsers.TabIndex = 8;
            this.dgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellClick);
            this.dgUsers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgUsers_CellMouseDoubleClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID";
            this.UserId.Name = "UserId";
            // 
            // Username
            // 
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Ime";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Prezime";
            this.LastName.Name = "LastName";
            // 
            // PID
            // 
            this.PID.HeaderText = "JMBG";
            this.PID.Name = "PID";
            // 
            // Role
            // 
            this.Role.HeaderText = "Uloga";
            this.Role.Name = "Role";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSearch.Location = new System.Drawing.Point(631, 66);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 18);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Pretraga";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(634, 87);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 20);
            this.tbSearch.TabIndex = 23;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.AutoSize = true;
            this.checkBoxSorting.Location = new System.Drawing.Point(181, 87);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSorting.TabIndex = 22;
            this.checkBoxSorting.UseVisualStyleBackColor = true;
            this.checkBoxSorting.CheckedChanged += new System.EventHandler(this.checkBoxSorting_CheckedChanged);
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "ID",
            "Korisničko ime",
            "Ime",
            "Prezime",
            "Uloga"});
            this.comboBoxSorting.Location = new System.Drawing.Point(34, 84);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSorting.TabIndex = 21;
            this.comboBoxSorting.SelectedValueChanged += new System.EventHandler(this.comboBoxSorting_SelectedValueChanged);
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.BackColor = System.Drawing.Color.Transparent;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSorting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSorting.Location = new System.Drawing.Point(31, 63);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(71, 18);
            this.lblSorting.TabIndex = 20;
            this.lblSorting.Text = "Sortiranje";
            // 
            // panelUsersFooter
            // 
            this.panelUsersFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelUsersFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUsersFooter.Location = new System.Drawing.Point(0, 331);
            this.panelUsersFooter.Name = "panelUsersFooter";
            this.panelUsersFooter.Size = new System.Drawing.Size(812, 35);
            this.panelUsersFooter.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.sort_az;
            this.pictureBox1.Location = new System.Drawing.Point(202, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panelUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUsersFooter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.checkBoxSorting);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.panelUsersHeader);
            this.Name = "panelUsers";
            this.Size = new System.Drawing.Size(812, 366);
            this.panelUsersHeader.ResumeLayout(false);
            this.panelUsersHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUsersHeader;
        private System.Windows.Forms.PictureBox picBoxProductsHeader;
        private System.Windows.Forms.Label lblUsersHeader;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.CheckBox checkBoxSorting;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Panel panelUsersFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;

        //private System.Windows.Forms.Button btnNewUser;
    }
}
