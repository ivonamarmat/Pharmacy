using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Pharmacy
{
    public partial class NewUserForm : Form
    {
        string ERR_ALL_FIELDS_REQUIRED;
        string USERNAME_TAKEN;
        string CONFIRM_PASSWORD_NON_EQUAL;
        string SHORT_PASSWORD;
        string SUCCESS_USER;
        string message = "";

        List<User> users = new List<User>();
       
        public NewUserForm()
        {
            InitializeComponent();
            hideAllRedLabels();
            setLanguage();
        }

        private void setLanguage()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var language = (byte)context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault().AppSettings.Language;
                    if (language == 1)
                    {
                        setSerbian();
                    }
                    else
                    {
                        setEnglish();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Admin language " + ex.Message);
            }
        }
        private void setSerbian()
        {
            lblTitleUserData.Text = "Podaci o korisniku";
            lblPersonalData.Text = "Lični podaci";
            lblFirstName.Text = "Ime";
            lblLastName.Text = "Prezime";
            lblPID.Text = "JMBG";

            lblUserData.Text = "Korisnički podaci";
            lblContact.Text = "Kontakt podaci";
            lblEmail.Text = "Email";
            lblPhoneNumber.Text = "Broj telefona";

            lblAddress.Text = "Adresa stanovanja";
            lblCountry.Text = "Država";
            lblCity.Text = "Grad";
            lblPlace.Text = "Mjesto";
            lblStreet.Text = "Ulica";
            lblZipCode.Text = "Poštanski broj";
            lblHouseNumber.Text = "Broj";
            lblRole.Text = "Uloga";
            lblUsername.Text = "Korisničko ime";
            lblPassword.Text = "Lozinka";
            lblConfirmPassword.Text = "Potvrda lozinke";

            rbAdmin.Text = "Administrator";
            rbPharmacist.Text = "Farmaceut";
            btnSave.Text = "Sačuvaj";
            btnCancel.Text = "Otkaži";

            ERR_ALL_FIELDS_REQUIRED = "Sva polja su obavezna!";
            USERNAME_TAKEN = "Korisničko ime je zauzeto.";
            CONFIRM_PASSWORD_NON_EQUAL = "Lozinke se ne podudaraju.";
            SHORT_PASSWORD = "Lozinka mora da sadrži minimalno 8 karaktera.";
            SUCCESS_USER = "Korisnik uspješno dodat.";
        }

        private void setEnglish()
        {
            lblTitleUserData.Text = "User data";
            lblPersonalData.Text = "Personal data";
            lblFirstName.Text = "First name";
            lblLastName.Text = "Last name";
            lblPID.Text = "PID";

            lblUserData.Text = "Account data";
            lblContact.Text = "Contact";
            //lblEmail.Text = "Email";
            lblPhoneNumber.Text = "Phone number";

            lblAddress.Text = "Address";
            lblCountry.Text = "Country";
            lblCity.Text = "City";
            lblPlace.Text = "Place";
            lblStreet.Text = "Street";
            lblZipCode.Text = "Zip code";
            lblHouseNumber.Text = "House number";
            lblRole.Text = "Role";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            lblConfirmPassword.Text = "Confirm password";

            rbAdmin.Text = "Admin";
            rbPharmacist.Text = "Pharmacist";
            btnSave.Text = "Save";
            btnCancel.Text = "Cancel";

            ERR_ALL_FIELDS_REQUIRED = "All fields are required!";
            USERNAME_TAKEN = "Username is already taken.";
            CONFIRM_PASSWORD_NON_EQUAL = "Passwords have to be equal.";
            SHORT_PASSWORD = "Password has to contain at least 8 characters.";
            SUCCESS_USER = "User added successfully.";
        }

        private void processUsername()
        {
            string username = tbUsername.Text.Trim();
            try
            {
                using(var context =new PharmacyDB())
                {
                    if (context.Users.Where(u => u.Username == username).FirstOrDefault() != null)
                    {
                        lblUsernameTaken.Text = USERNAME_TAKEN;
                        lblUsernameTaken.Show();
                        lblInvalidUsername.Show();
                    }
                    else
                    {
                        lblUsernameTaken.Hide();
                        lblInvalidUsername.Hide();
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Username new " + ex.Message);
            }
        }

        private void processConfirmPassword()
        {
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
           
            if (password!=confirmPassword)
            {
              lblDifferentPass.Text = CONFIRM_PASSWORD_NON_EQUAL;
              lblDifferentPass.Show();
              lblInvalidConfirmPassword.Show();
            }
            else
            {
              lblDifferentPass.Hide();
              lblInvalidConfirmPassword.Hide();
            }
             
        }

        private void processPassword()
        {
           
                    if (tbPassword.Text.Trim().Length<8)
                    {
                        lblPasswordTooShort.Text = SHORT_PASSWORD;
                        lblPasswordTooShort.Show();
                        lblInvalidPassword.Show();

                    }
                    else
                    {
                        lblPasswordTooShort.Hide();
                        lblInvalidPassword.Hide();
                    }
        }

        private void setTheme(Theme theme)
        {
            lblTitleUserData.Font = new Font(theme.font, 15);
            lblPersonalData.Font = lblUserData.Font=lblContact.Font= new Font(theme.font, 13);
            lblFirstName.Font = lblLastName.Font = lblPID.Font = lblEmail.Font = lblPhoneNumber.Font =
            lblCountry.Font = lblCity.Font = lblPlace.Font = lblStreet.Font = lblZipCode.Font = lblHouseNumber.Font =
            lblUsername.Font = lblPassword.Font = lblConfirmPassword.Font = rbAdmin.Font = rbPharmacist.Font=lblRole.Font = new Font(theme.font, 11);
        }

        private void hideAllRedLabels()
        {
            lblInvalidFirstName.Hide();
            lblInvalidLastName.Hide();
            lblInvalidPID.Hide();
            lblInvalidCountry.Hide();
            lblInvalidCity.Hide();
            lblInvalidPlace.Hide();
            lblInvalidZipCode.Hide();
            lblInvalidStreet.Hide();
            lblInvalidHouseNumber.Hide();
            lblInvalidEmail.Hide();
            lblInvalidPhoneNumber.Hide();
            lblInvalidUsername.Hide();
            lblInvalidPassword.Hide();
            lblInvalidConfirmPassword.Hide();
            lblUsernameTaken.Hide();
            lblDifferentPass.Hide();
            lblPasswordTooShort.Hide();
            lblRequiredFields.Hide();
            
        }

        private void processLabels()
        {

            if (isNullOrEmpty(tbFirstName.Text.Trim()))
            {
                lblInvalidFirstName.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidFirstName.Hide();

            }

            if (isNullOrEmpty(tbLastName.Text.Trim()))
            {
                lblInvalidLastName.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidLastName.Hide();
            }

            if (isNullOrEmpty(tbPID.Text.Trim()))
            {
                lblInvalidPID.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidPID.Hide();
            }

            if (isNullOrEmpty(tbCountry.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }

            if (isNullOrEmpty(tbCity.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }


            if (isNullOrEmpty(tbPlace.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }


            if (isNullOrEmpty(tbZipCode.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }


            if (isNullOrEmpty(tbStreet.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }

            if (isNullOrEmpty(tbHouseNumber.Text.Trim()))
            {
                lblInvalidCountry.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }

            if (isNullOrEmpty(tbEmail.Text.Trim()))
            {
                lblInvalidEmail.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidCountry.Hide();
            }

            if (isNullOrEmpty(tbPhoneNumber.Text.Trim()))
            {
                lblInvalidPhoneNumber.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidPhoneNumber.Hide();
            }

            if (isNullOrEmpty(tbUsername.Text.Trim()))
            {
                lblInvalidUsername.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else 
            {
                lblInvalidUsername.Hide();
            }

            if (isNullOrEmpty(tbPassword.Text.Trim()))
            {
                lblInvalidPassword.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidPassword.Hide();
            }

            if (isNullOrEmpty(tbConfirmPassword.Text.Trim()))
            {
                lblInvalidConfirmPassword.Show();
                message = ERR_ALL_FIELDS_REQUIRED;
            }
            else
            {
                lblInvalidConfirmPassword.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            processLabels();

            if (!string.IsNullOrEmpty(message))
            {
                lblRequiredFields.Show();
            }
            else
            {
                lblRequiredFields.Hide();

                //PROVJERA DA LI KORISNIK VEC POSTOJI U BAZI
                try
                {
                    using (var context = new PharmacyDB())
                    {
                        int houseNumber;
                        Int32.TryParse(tbHouseNumber.Text.Trim(), out houseNumber);

                        Address address = context.Addresses.Where(a => a.Place == tbPlace.Text && a.Street == tbStreet.Text && a.HouseNumber == houseNumber).FirstOrDefault();
                        if (address == null)
                        {
                            address = new Address()
                            {
                                Country = tbCountry.Text,
                                City = tbCity.Text,
                                Place = tbPlace.Text,
                                Street = tbStreet.Text,
                                ZipCode = tbZipCode.Text,
                                HouseNumber = houseNumber,

                            };
                            context.Addresses.Add(address);
                            context.SaveChanges();
                        }

                        User user = context.Users.Where(u => u.Username == tbUsername.Text).FirstOrDefault();
                        if (user != null)
                        {
                            context.Entry(user).State = EntityState.Modified;
                        }
                        else
                        {
                            user = new User();
                        }

                        user.FirstName = tbFirstName.Text;
                        user.LastName = tbLastName.Text;
                        user.PID = tbPID.Text;
                        user.AddressId = address.AddressId;
                        //user.Address = address;
                        user.Email = tbEmail.Text;
                        user.PhoneNumber = tbPhoneNumber.Text;
                        user.Username = tbUsername.Text;
                        string password = Functions.generatePasswordHash(tbPassword.Text);
                        string confirmPassword = Functions.generatePasswordHash(tbConfirmPassword.Text);
                        if (password == confirmPassword)
                        {
                            user.Password = password;
                        }
                        else
                        {
                            lblConfirmPassword.Show();
                        }
                        user.UserRole = rbAdmin.Checked ? (byte)1 : (byte)0;
                        user.IsDeleted = 0;
                        user.AppSettingsId = 1;

                        //foreach(var u in context.Users)
                        //{
                        //    if (tbUsername.Text == u.Username)
                        //    {
                        //        break;
                        //        lblInvalidUsername.Show();
                        //    }
                        //}
                        var userState = context.Entry(user).State;

                        if (userState != EntityState.Modified)
                        {
                            context.Users.Add(user);
                            int success = context.SaveChanges();
                            if (success != 0)
                            {
                                MessageBox.Show(SUCCESS_USER);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("User add " + ex.Message);
                }
            }
        }
        //}

        
        public void setUserData(User user)
        {
            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbPID.Text = user.PID;
            tbEmail.Text = user.Email;
            tbPhoneNumber.Text = user.PhoneNumber;
            tbCountry.Text = user.Address.Country;
            tbCity.Text = user.Address.City;
            tbPlace.Text = user.Address.Place;
            tbStreet.Text = user.Address.Street;
            tbZipCode.Text = user.Address.ZipCode;
            tbHouseNumber.Text = user.Address.HouseNumber.ToString();
            tbUsername.Text = user.Username;
            tbPassword.Text = user.Password;
            if (user.UserRole == 1)
            {
                rbAdmin.Checked = true;
            }
            else 
            {
                rbPharmacist.Checked= true;
            }
        }


       


        private void InsertUser(User user)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.Users.Add(user);
                    var res = context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertAddress(Address address)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.Addresses.Add(address);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UpdateUser(User user)
        {
            using (var context = new PharmacyDB())
            {
                {
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }


        private bool isNullOrEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        //FUNKCIJA KOJA PROVJERAVA DA LI STRING SADRZI SAMO SLOVNE KARATERE
        private bool isStringValid(string s)
        {
            return s.All(char.IsLetter);
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isNumberCharacter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isNumberCharacter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isLetter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isNumberCharacter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isNumberCharacter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void tbPlace_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Functions.isNumberCharacter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isLetter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHouseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isLetter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isLetter(e.KeyChar) || Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isSpecificCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isNonEmailCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void tbFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbLastName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbFirstName.Text.Trim()))
                {
                    lblInvalidFirstName.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidFirstName.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbPID.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbFirstName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbLastName.Text.Trim()))
                {
                    lblInvalidLastName.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidLastName.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbPID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbEmail.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbLastName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbPID.Text.Trim()))
                {
                    lblInvalidPID.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidPID.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbPhoneNumber.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbPID.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
                {
                    lblInvalidEmail.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidEmail.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode==Keys.Right)
            {
                tbCountry.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode==Keys.Left)
            {
                tbEmail.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbPhoneNumber.Text.Trim()))
                {
                    lblInvalidPhoneNumber.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidPhoneNumber.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbCity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode==Keys.Up)
            {
                tbPhoneNumber.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbCountry.Text.Trim()))
                {
                    lblInvalidCountry.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidCountry.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbCountry.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbPhoneNumber.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbCity.Text.Trim()))
                {
                    lblInvalidCity.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidCity.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode==Keys.Right)
            {
                tbPlace.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbCity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbPlace.Text.Trim()))
                {
                    lblInvalidPlace.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidPlace.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbZipCode.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Left)
            {
                tbPlace.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbStreet.Text.Trim()))
                {
                    lblInvalidStreet.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidStreet.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbZipCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tbHouseNumber.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbStreet.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbZipCode.Text.Trim()))
                {
                    lblInvalidZipCode.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidZipCode.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbHouseNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode==Keys.Right)
            {
                tbUsername.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbZipCode.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbHouseNumber.Text.Trim()))
                {
                    lblInvalidHouseNumber.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidHouseNumber.Hide();
                    lblRequiredFields.Hide();
                }
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbPassword.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Left)
            {
                tbHouseNumber.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
                {
                    lblInvalidUsername.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidUsername.Hide();
                    lblRequiredFields.Hide();
                }
                processUsername();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbConfirmPassword.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbUsername.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
                {
                    lblInvalidPassword.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblInvalidPassword.Hide();
                    lblRequiredFields.Hide();
                }
                processPassword();
            }
            
        }

        private void tbConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode==Keys.Down)
            {
                rbAdmin.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbPassword.Focus();
                e.Handled = true;
            }
            if (string.IsNullOrEmpty(tbConfirmPassword.Text.Trim()))
            {
                lblInvalidConfirmPassword.Show();
                lblRequiredFields.Show();
            }
            else
            {
                lblInvalidConfirmPassword.Hide();
                lblRequiredFields.Hide();
            }
            processConfirmPassword();
        }

        private void rbAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rbPharmacist.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Left)
            {
                tbConfirmPassword.Focus();
                e.Handled = true;
            }
        }

        private void rbPharmacist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rbAdmin.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode==Keys.Right)
            {
                btnCancel.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Left)
            {
                rbPharmacist.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Up || e.KeyCode==Keys.Left)
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalidPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    