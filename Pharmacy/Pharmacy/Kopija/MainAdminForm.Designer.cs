
namespace Pharmacy
{
    partial class MainAdminForm
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
            System.Windows.Forms.Button btnNewUser;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnOptionUsers = new System.Windows.Forms.Button();
            this.panelProductsHeader = new System.Windows.Forms.Panel();
            this.picBoxProductsHeader = new System.Windows.Forms.PictureBox();
            this.lblUsersHeader = new System.Windows.Forms.Label();
            btnNewUser = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.panelProductsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnOptionUsers);
            this.panelMenu.Location = new System.Drawing.Point(0, 133);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 320);
            this.panelMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelProductsHeader);
            this.panel1.Controls.Add(btnNewUser);
            this.panel1.Location = new System.Drawing.Point(215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 450);
            this.panel1.TabIndex = 5;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImage = global::Pharmacy.Properties.Resources.logo;
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogo.Location = new System.Drawing.Point(0, -5);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(218, 138);
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // btnOptionUsers
            // 
            this.btnOptionUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionUsers.FlatAppearance.BorderSize = 0;
            this.btnOptionUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptionUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionUsers.Image = global::Pharmacy.Properties.Resources.usertransp50;
            this.btnOptionUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionUsers.Location = new System.Drawing.Point(2, 20);
            this.btnOptionUsers.Name = "btnOptionUsers";
            this.btnOptionUsers.Size = new System.Drawing.Size(212, 55);
            this.btnOptionUsers.TabIndex = 26;
            this.btnOptionUsers.Text = "Korisnici";
            this.btnOptionUsers.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnNewUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnNewUser.ForeColor = System.Drawing.Color.Black;
            btnNewUser.Location = new System.Drawing.Point(431, 379);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new System.Drawing.Size(103, 26);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "Novi korisnik";
            btnNewUser.UseVisualStyleBackColor = false;
            // 
            // panelProductsHeader
            // 
            this.panelProductsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelProductsHeader.Controls.Add(this.picBoxProductsHeader);
            this.panelProductsHeader.Controls.Add(this.lblUsersHeader);
            this.panelProductsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProductsHeader.Name = "panelProductsHeader";
            this.panelProductsHeader.Size = new System.Drawing.Size(586, 46);
            this.panelProductsHeader.TabIndex = 5;
            // 
            // picBoxProductsHeader
            // 
            this.picBoxProductsHeader.BackgroundImage = global::Pharmacy.Properties.Resources.usertransp50;
            this.picBoxProductsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxProductsHeader.Image = global::Pharmacy.Properties.Resources.commercial_products_transp;
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
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.panelProductsHeader.ResumeLayout(false);
            this.panelProductsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProductsHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOptionUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProductsHeader;
        private System.Windows.Forms.PictureBox picBoxProductsHeader;
        private System.Windows.Forms.Label lblUsersHeader;
    }
}