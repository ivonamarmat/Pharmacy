
namespace Pharmacy
{
    partial class NewUserForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitleUserData = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblInvalidFirstName = new System.Windows.Forms.Label();
            this.lblInvalidLastName = new System.Windows.Forms.Label();
            this.lblInvalidUsername = new System.Windows.Forms.Label();
            this.lblInvalidPID = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lblInvalidCountry = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblInvalidPhoneNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblInvalidConfirmPassword = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblInvalidCity = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.lblInvalidPlace = new System.Windows.Forms.Label();
            this.lblInvalidHouseNumber = new System.Windows.Forms.Label();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.lblInvalidZipCode = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblInvalidStreet = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbPharmacist = new System.Windows.Forms.RadioButton();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPersonalData = new System.Windows.Forms.Label();
            this.lblUserData = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblUsernameTaken = new System.Windows.Forms.Label();
            this.lblDifferentPass = new System.Windows.Forms.Label();
            this.lblPasswordTooShort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(792, 659);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Otkazati";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(694, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 31);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sačuvati";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblTitleUserData
            // 
            this.lblTitleUserData.AutoSize = true;
            this.lblTitleUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitleUserData.Location = new System.Drawing.Point(46, 9);
            this.lblTitleUserData.Name = "lblTitleUserData";
            this.lblTitleUserData.Size = new System.Drawing.Size(170, 25);
            this.lblTitleUserData.TabIndex = 48;
            this.lblTitleUserData.Text = "Podaci o korisniku";
            // 
            // tbPID
            // 
            this.tbPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPID.Location = new System.Drawing.Point(628, 129);
            this.tbPID.MaxLength = 13;
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(261, 22);
            this.tbPID.TabIndex = 2;
            this.tbPID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPID_KeyDown);
            this.tbPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPID_KeyPress);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbUsername.Location = new System.Drawing.Point(52, 567);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(262, 22);
            this.tbUsername.TabIndex = 11;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbLastName.Location = new System.Drawing.Point(335, 130);
            this.tbLastName.MaxLength = 400;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(260, 22);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLastName_KeyDown);
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(48, 308);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(159, 22);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Adresa stanovanja";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPID.Location = new System.Drawing.Point(625, 110);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(51, 18);
            this.lblPID.TabIndex = 46;
            this.lblPID.Text = "JMBG";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(51, 547);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 18);
            this.lblUsername.TabIndex = 45;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(332, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 18);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "Prezime";
            // 
            // tbFirstName
            // 
            this.tbFirstName.AcceptsTab = true;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbFirstName.Location = new System.Drawing.Point(50, 130);
            this.tbFirstName.MaxLength = 200;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(260, 22);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFirstName_KeyDown);
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(47, 109);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(32, 18);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "Ime";
            // 
            // lblInvalidFirstName
            // 
            this.lblInvalidFirstName.BackColor = System.Drawing.Color.Red;
            this.lblInvalidFirstName.Location = new System.Drawing.Point(49, 129);
            this.lblInvalidFirstName.Name = "lblInvalidFirstName";
            this.lblInvalidFirstName.Size = new System.Drawing.Size(262, 24);
            this.lblInvalidFirstName.TabIndex = 53;
            // 
            // lblInvalidLastName
            // 
            this.lblInvalidLastName.BackColor = System.Drawing.Color.Red;
            this.lblInvalidLastName.Location = new System.Drawing.Point(334, 129);
            this.lblInvalidLastName.Name = "lblInvalidLastName";
            this.lblInvalidLastName.Size = new System.Drawing.Size(262, 24);
            this.lblInvalidLastName.TabIndex = 55;
            // 
            // lblInvalidUsername
            // 
            this.lblInvalidUsername.BackColor = System.Drawing.Color.Red;
            this.lblInvalidUsername.Location = new System.Drawing.Point(51, 566);
            this.lblInvalidUsername.Name = "lblInvalidUsername";
            this.lblInvalidUsername.Size = new System.Drawing.Size(264, 24);
            this.lblInvalidUsername.TabIndex = 57;
            // 
            // lblInvalidPID
            // 
            this.lblInvalidPID.BackColor = System.Drawing.Color.Red;
            this.lblInvalidPID.Location = new System.Drawing.Point(627, 128);
            this.lblInvalidPID.Name = "lblInvalidPID";
            this.lblInvalidPID.Size = new System.Drawing.Size(263, 24);
            this.lblInvalidPID.TabIndex = 2;
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCountry.Location = new System.Drawing.Point(50, 365);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(259, 22);
            this.tbCountry.TabIndex = 5;
            this.tbCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCountry_KeyDown);
            this.tbCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountry_KeyPress);
            // 
            // lblInvalidCountry
            // 
            this.lblInvalidCountry.BackColor = System.Drawing.Color.Red;
            this.lblInvalidCountry.Location = new System.Drawing.Point(49, 364);
            this.lblInvalidCountry.Name = "lblInvalidCountry";
            this.lblInvalidCountry.Size = new System.Drawing.Size(261, 24);
            this.lblInvalidCountry.TabIndex = 66;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbEmail.Location = new System.Drawing.Point(50, 240);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(263, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.BackColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(49, 239);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(265, 24);
            this.lblInvalidEmail.TabIndex = 69;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(45, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Email";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(337, 241);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(259, 22);
            this.tbPhoneNumber.TabIndex = 4;
            this.tbPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhoneNumber_KeyDown);
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // lblInvalidPhoneNumber
            // 
            this.lblInvalidPhoneNumber.BackColor = System.Drawing.Color.Red;
            this.lblInvalidPhoneNumber.Location = new System.Drawing.Point(336, 240);
            this.lblInvalidPhoneNumber.Name = "lblInvalidPhoneNumber";
            this.lblInvalidPhoneNumber.Size = new System.Drawing.Size(261, 24);
            this.lblInvalidPhoneNumber.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(334, 221);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(91, 18);
            this.lblPhoneNumber.TabIndex = 70;
            this.lblPhoneNumber.Text = "Broj telefona";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPassword.Location = new System.Drawing.Point(52, 631);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(262, 22);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(49, 612);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 18);
            this.lblPassword.TabIndex = 74;
            this.lblPassword.Text = "Lozinka";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.BackColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(51, 630);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(264, 24);
            this.lblInvalidPassword.TabIndex = 75;
            this.lblInvalidPassword.Click += new System.EventHandler(this.lblInvalidPassword_Click);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbConfirmPassword.Location = new System.Drawing.Point(51, 695);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(262, 22);
            this.tbConfirmPassword.TabIndex = 13;
            this.tbConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConfirmPassword_KeyDown);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(48, 676);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(110, 18);
            this.lblConfirmPassword.TabIndex = 77;
            this.lblConfirmPassword.Text = "Potvrda lozinke";
            // 
            // lblInvalidConfirmPassword
            // 
            this.lblInvalidConfirmPassword.BackColor = System.Drawing.Color.Red;
            this.lblInvalidConfirmPassword.Location = new System.Drawing.Point(50, 694);
            this.lblInvalidConfirmPassword.Name = "lblInvalidConfirmPassword";
            this.lblInvalidConfirmPassword.Size = new System.Drawing.Size(264, 24);
            this.lblInvalidConfirmPassword.TabIndex = 78;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCity.Location = new System.Drawing.Point(334, 364);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(262, 22);
            this.tbCity.TabIndex = 6;
            this.tbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCity_KeyDown);
            this.tbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCity_KeyPress);
            // 
            // lblInvalidCity
            // 
            this.lblInvalidCity.BackColor = System.Drawing.Color.Red;
            this.lblInvalidCity.Location = new System.Drawing.Point(333, 363);
            this.lblInvalidCity.Name = "lblInvalidCity";
            this.lblInvalidCity.Size = new System.Drawing.Size(264, 24);
            this.lblInvalidCity.TabIndex = 80;
            // 
            // tbPlace
            // 
            this.tbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPlace.Location = new System.Drawing.Point(627, 363);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(262, 22);
            this.tbPlace.TabIndex = 7;
            this.tbPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPlace_KeyDown);
            this.tbPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlace_KeyPress);
            // 
            // lblInvalidPlace
            // 
            this.lblInvalidPlace.BackColor = System.Drawing.Color.Red;
            this.lblInvalidPlace.Location = new System.Drawing.Point(626, 362);
            this.lblInvalidPlace.Name = "lblInvalidPlace";
            this.lblInvalidPlace.Size = new System.Drawing.Size(264, 24);
            this.lblInvalidPlace.TabIndex = 82;
            // 
            // lblInvalidHouseNumber
            // 
            this.lblInvalidHouseNumber.BackColor = System.Drawing.Color.Red;
            this.lblInvalidHouseNumber.Location = new System.Drawing.Point(533, 428);
            this.lblInvalidHouseNumber.Name = "lblInvalidHouseNumber";
            this.lblInvalidHouseNumber.Size = new System.Drawing.Size(64, 24);
            this.lblInvalidHouseNumber.TabIndex = 86;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbHouseNumber.Location = new System.Drawing.Point(534, 429);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(62, 22);
            this.tbHouseNumber.TabIndex = 10;
            this.tbHouseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHouseNumber_KeyDown);
            this.tbHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHouseNumber_KeyPress);
            // 
            // tbZipCode
            // 
            this.tbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbZipCode.Location = new System.Drawing.Point(335, 428);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(158, 22);
            this.tbZipCode.TabIndex = 9;
            this.tbZipCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbZipCode_KeyDown);
            this.tbZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbZipCode_KeyPress);
            // 
            // lblInvalidZipCode
            // 
            this.lblInvalidZipCode.BackColor = System.Drawing.Color.Red;
            this.lblInvalidZipCode.Location = new System.Drawing.Point(334, 427);
            this.lblInvalidZipCode.Name = "lblInvalidZipCode";
            this.lblInvalidZipCode.Size = new System.Drawing.Size(160, 24);
            this.lblInvalidZipCode.TabIndex = 88;
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbStreet.Location = new System.Drawing.Point(50, 428);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(258, 22);
            this.tbStreet.TabIndex = 8;
            this.tbStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStreet_KeyDown);
            this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreet_KeyPress);
            // 
            // lblInvalidStreet
            // 
            this.lblInvalidStreet.BackColor = System.Drawing.Color.Red;
            this.lblInvalidStreet.Location = new System.Drawing.Point(49, 427);
            this.lblInvalidStreet.Name = "lblInvalidStreet";
            this.lblInvalidStreet.Size = new System.Drawing.Size(260, 24);
            this.lblInvalidStreet.TabIndex = 90;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.Location = new System.Drawing.Point(47, 346);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 18);
            this.lblCountry.TabIndex = 91;
            this.lblCountry.Text = "Država";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(331, 344);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 18);
            this.lblCity.TabIndex = 92;
            this.lblCity.Text = "Grad";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlace.Location = new System.Drawing.Point(624, 342);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(53, 18);
            this.lblPlace.TabIndex = 93;
            this.lblPlace.Text = "Mjesto";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreet.Location = new System.Drawing.Point(47, 406);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(41, 18);
            this.lblStreet.TabIndex = 94;
            this.lblStreet.Text = "Ulica";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZipCode.Location = new System.Drawing.Point(333, 409);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(103, 18);
            this.lblZipCode.TabIndex = 95;
            this.lblZipCode.Text = "Poštanski broj";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHouseNumber.Location = new System.Drawing.Point(531, 408);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(35, 18);
            this.lblHouseNumber.TabIndex = 96;
            this.lblHouseNumber.Text = "Broj";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRole.Location = new System.Drawing.Point(363, 571);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(47, 18);
            this.lblRole.TabIndex = 97;
            this.lblRole.Text = "Uloga";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAdmin.Location = new System.Drawing.Point(457, 571);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(67, 22);
            this.rbAdmin.TabIndex = 14;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbAdmin_KeyDown);
            // 
            // rbPharmacist
            // 
            this.rbPharmacist.AutoSize = true;
            this.rbPharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPharmacist.Location = new System.Drawing.Point(457, 606);
            this.rbPharmacist.Name = "rbPharmacist";
            this.rbPharmacist.Size = new System.Drawing.Size(97, 22);
            this.rbPharmacist.TabIndex = 15;
            this.rbPharmacist.TabStop = true;
            this.rbPharmacist.Text = "Farmaceut";
            this.rbPharmacist.UseVisualStyleBackColor = true;
            this.rbPharmacist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbPharmacist_KeyDown);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContact.Location = new System.Drawing.Point(44, 188);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(129, 22);
            this.lblContact.TabIndex = 100;
            this.lblContact.Text = "Kontakt podaci";
            // 
            // lblPersonalData
            // 
            this.lblPersonalData.AutoSize = true;
            this.lblPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPersonalData.Location = new System.Drawing.Point(46, 80);
            this.lblPersonalData.Name = "lblPersonalData";
            this.lblPersonalData.Size = new System.Drawing.Size(105, 22);
            this.lblPersonalData.TabIndex = 101;
            this.lblPersonalData.Text = "Lični podaci";
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserData.Location = new System.Drawing.Point(48, 505);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(145, 22);
            this.lblUserData.TabIndex = 102;
            this.lblUserData.Text = "Korisnički podaci";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRequiredFields.Location = new System.Drawing.Point(425, 711);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(170, 16);
            this.lblRequiredFields.TabIndex = 103;
            this.lblRequiredFields.Text = "Sva polja su obavezna!";
            // 
            // lblUsernameTaken
            // 
            this.lblUsernameTaken.AutoSize = true;
            this.lblUsernameTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsernameTaken.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsernameTaken.Location = new System.Drawing.Point(49, 592);
            this.lblUsernameTaken.Name = "lblUsernameTaken";
            this.lblUsernameTaken.Size = new System.Drawing.Size(216, 16);
            this.lblUsernameTaken.TabIndex = 104;
            this.lblUsernameTaken.Text = "Korisničko ime je već zauzeto!";
            // 
            // lblDifferentPass
            // 
            this.lblDifferentPass.AutoSize = true;
            this.lblDifferentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDifferentPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDifferentPass.Location = new System.Drawing.Point(48, 720);
            this.lblDifferentPass.Name = "lblDifferentPass";
            this.lblDifferentPass.Size = new System.Drawing.Size(242, 16);
            this.lblDifferentPass.TabIndex = 105;
            this.lblDifferentPass.Text = "Lozinke moraju da se podudaraju!";
            // 
            // lblPasswordTooShort
            // 
            this.lblPasswordTooShort.AutoSize = true;
            this.lblPasswordTooShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordTooShort.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswordTooShort.Location = new System.Drawing.Point(49, 656);
            this.lblPasswordTooShort.Name = "lblPasswordTooShort";
            this.lblPasswordTooShort.Size = new System.Drawing.Size(328, 16);
            this.lblPasswordTooShort.TabIndex = 106;
            this.lblPasswordTooShort.Text = "Lozinka mora da sadrži minimalno 8 karaktera!";
            this.lblPasswordTooShort.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewUserForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(913, 749);
            this.Controls.Add(this.lblPasswordTooShort);
            this.Controls.Add(this.lblDifferentPass);
            this.Controls.Add(this.lblUsernameTaken);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lblUserData);
            this.Controls.Add(this.lblPersonalData);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.rbPharmacist);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblHouseNumber);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.lblInvalidStreet);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.lblInvalidZipCode);
            this.Controls.Add(this.tbHouseNumber);
            this.Controls.Add(this.lblInvalidHouseNumber);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.lblInvalidPlace);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblInvalidCity);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblInvalidConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lblInvalidPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.lblInvalidCountry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitleUserData);
            this.Controls.Add(this.tbPID);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblInvalidUsername);
            this.Controls.Add(this.lblInvalidPID);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblInvalidFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblInvalidLastName);
            this.Name = "NewUserForm";
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitleUserData;
        private System.Windows.Forms.TextBox tbPID;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblInvalidFirstName;
        private System.Windows.Forms.Label lblInvalidLastName;
        private System.Windows.Forms.Label lblInvalidUsername;
        private System.Windows.Forms.Label lblInvalidPID;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lblInvalidCountry;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblInvalidPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblInvalidConfirmPassword;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblInvalidCity;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label lblInvalidPlace;
        private System.Windows.Forms.Label lblInvalidHouseNumber;
        private System.Windows.Forms.TextBox tbHouseNumber;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label lblInvalidZipCode;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblInvalidStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbPharmacist;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPersonalData;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblUsernameTaken;
        private System.Windows.Forms.Label lblDifferentPass;
        private System.Windows.Forms.Label lblPasswordTooShort;
    }
}