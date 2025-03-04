
namespace Pharmacy
{
    partial class panelHomepage
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
            this.panelHomepageFooter = new System.Windows.Forms.Panel();
            this.panelHomepageHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picBoxHomepageHeader = new System.Windows.Forms.PictureBox();
            this.lblHomepageHeader = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbSerbian = new System.Windows.Forms.RadioButton();
            this.lblChooseLanguage = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.rbTheme3 = new System.Windows.Forms.RadioButton();
            this.rbTheme1 = new System.Windows.Forms.RadioButton();
            this.rbTheme2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChooseTheme = new System.Windows.Forms.Label();
            this.panelHomepageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomepageHeader)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomepageFooter
            // 
            this.panelHomepageFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelHomepageFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHomepageFooter.Location = new System.Drawing.Point(0, 368);
            this.panelHomepageFooter.Name = "panelHomepageFooter";
            this.panelHomepageFooter.Size = new System.Drawing.Size(812, 35);
            this.panelHomepageFooter.TabIndex = 23;
            // 
            // panelHomepageHeader
            // 
            this.panelHomepageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.panelHomepageHeader.Controls.Add(this.btnLogout);
            this.panelHomepageHeader.Controls.Add(this.picBoxHomepageHeader);
            this.panelHomepageHeader.Controls.Add(this.lblHomepageHeader);
            this.panelHomepageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomepageHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHomepageHeader.Name = "panelHomepageHeader";
            this.panelHomepageHeader.Size = new System.Drawing.Size(812, 46);
            this.panelHomepageHeader.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLogout.Location = new System.Drawing.Point(710, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picBoxHomepageHeader
            // 
            this.picBoxHomepageHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxHomepageHeader.Image = global::Pharmacy.Properties.Resources.home51;
            this.picBoxHomepageHeader.Location = new System.Drawing.Point(2, 1);
            this.picBoxHomepageHeader.Name = "picBoxHomepageHeader";
            this.picBoxHomepageHeader.Size = new System.Drawing.Size(49, 47);
            this.picBoxHomepageHeader.TabIndex = 6;
            this.picBoxHomepageHeader.TabStop = false;
            // 
            // lblHomepageHeader
            // 
            this.lblHomepageHeader.AutoSize = true;
            this.lblHomepageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHomepageHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomepageHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHomepageHeader.Location = new System.Drawing.Point(57, 12);
            this.lblHomepageHeader.Name = "lblHomepageHeader";
            this.lblHomepageHeader.Size = new System.Drawing.Size(131, 20);
            this.lblHomepageHeader.TabIndex = 5;
            this.lblHomepageHeader.Text = "Početna strana";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.Location = new System.Drawing.Point(22, 69);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(203, 16);
            this.lblCurrentUser.TabIndex = 34;
            this.lblCurrentUser.Text = "Trenutno prijavljeni korisnik:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsername.Location = new System.Drawing.Point(246, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 16);
            this.lblUsername.TabIndex = 35;
            this.lblUsername.Text = "korisničko ime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.rbEnglish);
            this.panel1.Controls.Add(this.rbSerbian);
            this.panel1.Location = new System.Drawing.Point(125, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 52);
            this.panel1.TabIndex = 42;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.rbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbEnglish.Location = new System.Drawing.Point(108, 16);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(78, 20);
            this.rbEnglish.TabIndex = 1;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Engleski";
            this.rbEnglish.UseVisualStyleBackColor = false;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            this.rbEnglish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbEnglish_KeyDown);
            // 
            // rbSerbian
            // 
            this.rbSerbian.AutoSize = true;
            this.rbSerbian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.rbSerbian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbSerbian.Location = new System.Drawing.Point(10, 16);
            this.rbSerbian.Name = "rbSerbian";
            this.rbSerbian.Size = new System.Drawing.Size(64, 20);
            this.rbSerbian.TabIndex = 0;
            this.rbSerbian.TabStop = true;
            this.rbSerbian.Text = "Srpski";
            this.rbSerbian.UseVisualStyleBackColor = false;
            this.rbSerbian.CheckedChanged += new System.EventHandler(this.rbSerbian_CheckedChanged);
            this.rbSerbian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbSerbian_KeyDown);
            // 
            // lblChooseLanguage
            // 
            this.lblChooseLanguage.AutoSize = true;
            this.lblChooseLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.lblChooseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblChooseLanguage.Location = new System.Drawing.Point(32, 221);
            this.lblChooseLanguage.Name = "lblChooseLanguage";
            this.lblChooseLanguage.Size = new System.Drawing.Size(48, 16);
            this.lblChooseLanguage.TabIndex = 40;
            this.lblChooseLanguage.Text = "Jezik:";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSettings.Location = new System.Drawing.Point(22, 161);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(179, 18);
            this.lblSettings.TabIndex = 39;
            this.lblSettings.Text = "Podešavanja aplikacije";
            // 
            // rbTheme3
            // 
            this.rbTheme3.AutoSize = true;
            this.rbTheme3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.rbTheme3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme3.Location = new System.Drawing.Point(192, 14);
            this.rbTheme3.Name = "rbTheme3";
            this.rbTheme3.Size = new System.Drawing.Size(91, 20);
            this.rbTheme3.TabIndex = 4;
            this.rbTheme3.TabStop = true;
            this.rbTheme3.Text = "Crno-bijela";
            this.rbTheme3.UseVisualStyleBackColor = false;
            this.rbTheme3.CheckedChanged += new System.EventHandler(this.rbTheme3_CheckedChanged);
            this.rbTheme3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbTheme3_KeyDown);
            // 
            // rbTheme1
            // 
            this.rbTheme1.AutoSize = true;
            this.rbTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.rbTheme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme1.Location = new System.Drawing.Point(8, 14);
            this.rbTheme1.Name = "rbTheme1";
            this.rbTheme1.Size = new System.Drawing.Size(77, 20);
            this.rbTheme1.TabIndex = 2;
            this.rbTheme1.TabStop = true;
            this.rbTheme1.Text = "Klasična";
            this.rbTheme1.UseVisualStyleBackColor = false;
            this.rbTheme1.CheckedChanged += new System.EventHandler(this.rbTheme1_CheckedChanged);
            this.rbTheme1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbTheme1_KeyDown);
            // 
            // rbTheme2
            // 
            this.rbTheme2.AutoSize = true;
            this.rbTheme2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.rbTheme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme2.Location = new System.Drawing.Point(106, 14);
            this.rbTheme2.Name = "rbTheme2";
            this.rbTheme2.Size = new System.Drawing.Size(53, 20);
            this.rbTheme2.TabIndex = 3;
            this.rbTheme2.TabStop = true;
            this.rbTheme2.Text = "Siva";
            this.rbTheme2.UseVisualStyleBackColor = false;
            this.rbTheme2.CheckedChanged += new System.EventHandler(this.rbTheme2_CheckedChanged);
            this.rbTheme2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbTheme2_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.rbTheme3);
            this.panel2.Controls.Add(this.rbTheme1);
            this.panel2.Controls.Add(this.rbTheme2);
            this.panel2.Location = new System.Drawing.Point(125, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 52);
            this.panel2.TabIndex = 43;
            // 
            // lblChooseTheme
            // 
            this.lblChooseTheme.AutoSize = true;
            this.lblChooseTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.lblChooseTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblChooseTheme.Location = new System.Drawing.Point(32, 275);
            this.lblChooseTheme.Name = "lblChooseTheme";
            this.lblChooseTheme.Size = new System.Drawing.Size(52, 16);
            this.lblChooseTheme.TabIndex = 41;
            this.lblChooseTheme.Text = "Tema:";
            // 
            // panelHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChooseLanguage);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblChooseTheme);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.panelHomepageFooter);
            this.Controls.Add(this.panelHomepageHeader);
            this.Name = "panelHomepage";
            this.Size = new System.Drawing.Size(812, 403);
            this.panelHomepageHeader.ResumeLayout(false);
            this.panelHomepageHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomepageHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHomepageFooter;
        private System.Windows.Forms.Panel panelHomepageHeader;
        private System.Windows.Forms.PictureBox picBoxHomepageHeader;
        private System.Windows.Forms.Label lblHomepageHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbSerbian;
        private System.Windows.Forms.Label lblChooseLanguage;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.RadioButton rbTheme3;
        private System.Windows.Forms.RadioButton rbTheme1;
        private System.Windows.Forms.RadioButton rbTheme2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChooseTheme;
    }
}
