
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnOptionUsers = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelUsers = new Pharmacy.panelUsers();
            this.panelHomepageAdmin = new Pharmacy.panelHomepage();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.panelMenu.Controls.Add(this.btnHomepage);
            this.panelMenu.Controls.Add(this.btnOptionUsers);
            this.panelMenu.Location = new System.Drawing.Point(0, 133);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 441);
            this.panelMenu.TabIndex = 4;
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHomepage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomepage.Image = global::Pharmacy.Properties.Resources.home52;
            this.btnHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomepage.Location = new System.Drawing.Point(3, 25);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(208, 55);
            this.btnHomepage.TabIndex = 27;
            this.btnHomepage.Text = "  Početna strana";
            this.btnHomepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            this.btnHomepage.MouseEnter += new System.EventHandler(this.btnHomepage_MouseEnter);
            this.btnHomepage.MouseLeave += new System.EventHandler(this.btnHomepage_MouseLeave);
            // 
            // btnOptionUsers
            // 
            this.btnOptionUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOptionUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOptionUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOptionUsers.FlatAppearance.BorderSize = 0;
            this.btnOptionUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptionUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptionUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptionUsers.Image = global::Pharmacy.Properties.Resources.usertransp50;
            this.btnOptionUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionUsers.Location = new System.Drawing.Point(2, 76);
            this.btnOptionUsers.Name = "btnOptionUsers";
            this.btnOptionUsers.Size = new System.Drawing.Size(208, 55);
            this.btnOptionUsers.TabIndex = 26;
            this.btnOptionUsers.Text = "Korisnici";
            this.btnOptionUsers.UseVisualStyleBackColor = false;
            this.btnOptionUsers.Click += new System.EventHandler(this.btnOptionUsers_Click);
            this.btnOptionUsers.MouseEnter += new System.EventHandler(this.btnOptionUsers_MouseEnter);
            this.btnOptionUsers.MouseLeave += new System.EventHandler(this.btnOptionUsers_MouseLeave);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogo.Image = global::Pharmacy.Properties.Resources.logo;
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(211, 138);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panelUsers.Location = new System.Drawing.Point(211, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(812, 485);
            this.panelUsers.TabIndex = 7;
            this.panelUsers.Load += new System.EventHandler(this.panelUsers_Load);
            // 
            // panelHomepageAdmin
            // 
            this.panelHomepageAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHomepageAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panelHomepageAdmin.Location = new System.Drawing.Point(211, 0);
            this.panelHomepageAdmin.Name = "panelHomepageAdmin";
            this.panelHomepageAdmin.Size = new System.Drawing.Size(812, 485);
            this.panelHomepageAdmin.TabIndex = 6;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 484);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelHomepageAdmin);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOptionUsers;

        private System.Windows.Forms.Button btnHomepage;
        private panelUsers panelUsers=new Pharmacy.panelUsers();
        private panelHomepage panelHomepageAdmin;
        
    }
}