
namespace Pharmacy
{
    partial class panelSettings
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
            this.settingsFooter = new System.Windows.Forms.Panel();
            this.settingsHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picBoxsettingsHeader = new System.Windows.Forms.PictureBox();
            this.lblSettingsHeader = new System.Windows.Forms.Label();
            this.rbTheme2 = new System.Windows.Forms.RadioButton();
            this.rbTheme3 = new System.Windows.Forms.RadioButton();
            this.rbTheme1 = new System.Windows.Forms.RadioButton();
            this.lblChooseTheme = new System.Windows.Forms.Label();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbSerbian = new System.Windows.Forms.RadioButton();
            this.lblChooseLanguage = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.settingsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxsettingsHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsFooter
            // 
            this.settingsFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.settingsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsFooter.Location = new System.Drawing.Point(0, 331);
            this.settingsFooter.Name = "settingsFooter";
            this.settingsFooter.Size = new System.Drawing.Size(812, 35);
            this.settingsFooter.TabIndex = 23;
            // 
            // settingsHeader
            // 
            this.settingsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.settingsHeader.Controls.Add(this.btnLogout);
            this.settingsHeader.Controls.Add(this.picBoxsettingsHeader);
            this.settingsHeader.Controls.Add(this.lblSettingsHeader);
            this.settingsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsHeader.Location = new System.Drawing.Point(0, 0);
            this.settingsHeader.Name = "settingsHeader";
            this.settingsHeader.Size = new System.Drawing.Size(812, 46);
            this.settingsHeader.TabIndex = 22;
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
            // picBoxsettingsHeader
            // 
            this.picBoxsettingsHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxsettingsHeader.Image = global::Pharmacy.Properties.Resources.home51;
            this.picBoxsettingsHeader.Location = new System.Drawing.Point(2, 1);
            this.picBoxsettingsHeader.Name = "picBoxsettingsHeader";
            this.picBoxsettingsHeader.Size = new System.Drawing.Size(49, 47);
            this.picBoxsettingsHeader.TabIndex = 6;
            this.picBoxsettingsHeader.TabStop = false;
            // 
            // lblSettingsHeader
            // 
            this.lblSettingsHeader.AutoSize = true;
            this.lblSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSettingsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSettingsHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSettingsHeader.Location = new System.Drawing.Point(57, 12);
            this.lblSettingsHeader.Name = "lblSettingsHeader";
            this.lblSettingsHeader.Size = new System.Drawing.Size(111, 20);
            this.lblSettingsHeader.TabIndex = 5;
            this.lblSettingsHeader.Text = "Podešavanja";
            // 
            // rbTheme2
            // 
            this.rbTheme2.BackColor = System.Drawing.Color.Transparent;
            this.rbTheme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme2.Location = new System.Drawing.Point(233, 226);
            this.rbTheme2.Name = "rbTheme2";
            this.rbTheme2.Size = new System.Drawing.Size(69, 20);
            this.rbTheme2.TabIndex = 31;
            this.rbTheme2.TabStop = true;
            this.rbTheme2.Text = "Tamna";
            this.rbTheme2.UseVisualStyleBackColor = false;
            this.rbTheme2.CheckedChanged += new System.EventHandler(this.rbTheme2_CheckedChanged);
            // 
            // rbTheme3
            // 
            this.rbTheme3.BackColor = System.Drawing.Color.Transparent;
            this.rbTheme3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme3.Location = new System.Drawing.Point(319, 226);
            this.rbTheme3.Name = "rbTheme3";
            this.rbTheme3.Size = new System.Drawing.Size(70, 20);
            this.rbTheme3.TabIndex = 30;
            this.rbTheme3.TabStop = true;
            this.rbTheme3.Text = "Svijetla";
            this.rbTheme3.UseVisualStyleBackColor = false;
            this.rbTheme3.CheckedChanged += new System.EventHandler(this.rbTheme3_CheckedChanged);
            // 
            // rbTheme1
            // 
            this.rbTheme1.BackColor = System.Drawing.Color.Transparent;
            this.rbTheme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbTheme1.Location = new System.Drawing.Point(135, 226);
            this.rbTheme1.Name = "rbTheme1";
            this.rbTheme1.Size = new System.Drawing.Size(77, 20);
            this.rbTheme1.TabIndex = 29;
            this.rbTheme1.TabStop = true;
            this.rbTheme1.Text = "Klasična";
            this.rbTheme1.UseVisualStyleBackColor = false;
            this.rbTheme1.CheckedChanged += new System.EventHandler(this.rbTheme1_CheckedChanged);
            // 
            // lblChooseTheme
            // 
            this.lblChooseTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblChooseTheme.Location = new System.Drawing.Point(32, 226);
            this.lblChooseTheme.Name = "lblChooseTheme";
            this.lblChooseTheme.Size = new System.Drawing.Size(52, 16);
            this.lblChooseTheme.TabIndex = 28;
            this.lblChooseTheme.Text = "Tema:";
            // 
            // rbEnglish
            // 
            this.rbEnglish.BackColor = System.Drawing.Color.Transparent;
            this.rbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbEnglish.Location = new System.Drawing.Point(233, 172);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(78, 20);
            this.rbEnglish.TabIndex = 27;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Engleski";
            this.rbEnglish.UseVisualStyleBackColor = false;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // rbSerbian
            // 
            this.rbSerbian.BackColor = System.Drawing.Color.Transparent;
            this.rbSerbian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rbSerbian.Location = new System.Drawing.Point(135, 172);
            this.rbSerbian.Name = "rbSerbian";
            this.rbSerbian.Size = new System.Drawing.Size(64, 20);
            this.rbSerbian.TabIndex = 26;
            this.rbSerbian.TabStop = true;
            this.rbSerbian.Text = "Srpski";
            this.rbSerbian.UseVisualStyleBackColor = false;
            this.rbSerbian.CheckedChanged += new System.EventHandler(this.rbSerbian_CheckedChanged);
            // 
            // lblChooseLanguage
            // 
            this.lblChooseLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblChooseLanguage.Location = new System.Drawing.Point(32, 172);
            this.lblChooseLanguage.Name = "lblChooseLanguage";
            this.lblChooseLanguage.Size = new System.Drawing.Size(48, 16);
            this.lblChooseLanguage.TabIndex = 25;
            this.lblChooseLanguage.Text = "Jezik:";
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSettings.Location = new System.Drawing.Point(22, 112);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(179, 18);
            this.lblSettings.TabIndex = 24;
            this.lblSettings.Text = "Podešavanja aplikacije";
            // 
            // panelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.rbTheme2);
            this.Controls.Add(this.rbTheme3);
            this.Controls.Add(this.rbTheme1);
            this.Controls.Add(this.lblChooseTheme);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbSerbian);
            this.Controls.Add(this.lblChooseLanguage);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.settingsFooter);
            this.Controls.Add(this.settingsHeader);
            this.Name = "panelSettings";
            this.Size = new System.Drawing.Size(812, 366);
            this.settingsHeader.ResumeLayout(false);
            this.settingsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxsettingsHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsFooter;
        private System.Windows.Forms.Panel settingsHeader;
        private System.Windows.Forms.PictureBox picBoxsettingsHeader;
        private System.Windows.Forms.Label lblSettingsHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RadioButton rbTheme2;
        private System.Windows.Forms.RadioButton rbTheme3;
        private System.Windows.Forms.RadioButton rbTheme1;
        private System.Windows.Forms.Label lblChooseTheme;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbSerbian;
        private System.Windows.Forms.Label lblChooseLanguage;
        private System.Windows.Forms.Label lblSettings;
    }
}
