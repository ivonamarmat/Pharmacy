
namespace Pharmacy
{
    partial class ChangePasswordForm
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
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmptyOldPassword = new System.Windows.Forms.Label();
            this.lblEmptyNewPassword = new System.Windows.Forms.Label();
            this.lblEmptyConfirmPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblRedWrongOldPassword = new System.Windows.Forms.Label();
            this.lblRedConflictPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOldPassword.Location = new System.Drawing.Point(45, 47);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(85, 16);
            this.lblOldPassword.TabIndex = 11;
            this.lblOldPassword.Text = "Stara lozinka";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.AcceptsTab = true;
            this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbOldPassword.Location = new System.Drawing.Point(49, 66);
            this.tbOldPassword.MaxLength = 200;
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(214, 22);
            this.tbOldPassword.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPassword.Location = new System.Drawing.Point(45, 113);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(86, 16);
            this.lblNewPassword.TabIndex = 17;
            this.lblNewPassword.Text = "Nova lozinka";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbNewPassword.Location = new System.Drawing.Point(49, 132);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(214, 22);
            this.tbNewPassword.TabIndex = 6;
           
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(98, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sačuvati";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(189, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Otkazati";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEmptyOldPassword
            // 
            this.lblEmptyOldPassword.BackColor = System.Drawing.Color.Red;
            this.lblEmptyOldPassword.Location = new System.Drawing.Point(48, 65);
            this.lblEmptyOldPassword.Name = "lblEmptyOldPassword";
            this.lblEmptyOldPassword.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyOldPassword.TabIndex = 23;
            // 
            // lblEmptyNewPassword
            // 
            this.lblEmptyNewPassword.BackColor = System.Drawing.Color.Red;
            this.lblEmptyNewPassword.Location = new System.Drawing.Point(48, 131);
            this.lblEmptyNewPassword.Name = "lblEmptyNewPassword";
            this.lblEmptyNewPassword.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyNewPassword.TabIndex = 29;
            // 
            // lblEmptyConfirmPassword
            // 
            this.lblEmptyConfirmPassword.BackColor = System.Drawing.Color.Red;
            this.lblEmptyConfirmPassword.Location = new System.Drawing.Point(48, 189);
            this.lblEmptyConfirmPassword.Name = "lblEmptyConfirmPassword";
            this.lblEmptyConfirmPassword.Size = new System.Drawing.Size(216, 24);
            this.lblEmptyConfirmPassword.TabIndex = 28;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(45, 171);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(133, 16);
            this.lblConfirmNewPassword.TabIndex = 16;
            this.lblConfirmNewPassword.Text = "Potvrda nove lozinke";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbConfirmPassword.Location = new System.Drawing.Point(49, 190);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(214, 22);
            this.tbConfirmPassword.TabIndex = 5;
            this.tbConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoldPricePrescript_KeyPress);
            // 
            // lblRedWrongOldPassword
            // 
            this.lblRedWrongOldPassword.AutoSize = true;
            this.lblRedWrongOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRedWrongOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRedWrongOldPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRedWrongOldPassword.Location = new System.Drawing.Point(46, 91);
            this.lblRedWrongOldPassword.Name = "lblRedWrongOldPassword";
            this.lblRedWrongOldPassword.Size = new System.Drawing.Size(123, 16);
            this.lblRedWrongOldPassword.TabIndex = 30;
            this.lblRedWrongOldPassword.Text = "Neispravna lozinka";
            // 
            // lblRedConflictPassword
            // 
            this.lblRedConflictPassword.AutoSize = true;
            this.lblRedConflictPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRedConflictPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRedConflictPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRedConflictPassword.Location = new System.Drawing.Point(46, 215);
            this.lblRedConflictPassword.Name = "lblRedConflictPassword";
            this.lblRedConflictPassword.Size = new System.Drawing.Size(162, 16);
            this.lblRedConflictPassword.TabIndex = 31;
            this.lblRedConflictPassword.Text = "Lozinke se ne podudaraju";
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(315, 296);
            this.Controls.Add(this.lblRedConflictPassword);
            this.Controls.Add(this.lblRedWrongOldPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblEmptyOldPassword);
            this.Controls.Add(this.lblEmptyConfirmPassword);
            this.Controls.Add(this.lblEmptyNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmptyOldPassword;
        private System.Windows.Forms.Label lblEmptyNewPassword;
        private System.Windows.Forms.Label lblEmptyConfirmPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblRedWrongOldPassword;
        private System.Windows.Forms.Label lblRedConflictPassword;
    }
}