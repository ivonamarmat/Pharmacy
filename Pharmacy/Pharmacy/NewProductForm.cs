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

namespace Pharmacy
{
    
    public partial class NewProductForm : Form
    {
        string MISSING_FIELDS;
        string MANUFACTURER;
        string ERR;
        string SUCCESS_PRODUCT;
       
        public NewProductForm()
        {
            InitializeComponent();
            hideAllRedLabels();
            initializeManufacturers();
            setLanguage();
            lblRequiredFields.Text = MISSING_FIELDS;
        }

        public void setLanguage()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var user = context.Users.Where(u => u.UserId == Program.currentUserId).FirstOrDefault();
                    byte language = (byte)user.AppSettings.Language;
                    byte theme = (byte)user.AppSettings.Theme;
                    if (language == 1)
                    {
                        setSerbian();
                    }
                    else
                    {
                        setEnglish();
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Langage: "+ex.Message);
            }
        }
        private void setSerbian()
        {
            this.Text = "Novi proizvod";
            lblTitleProductData.Text = "Podaci o proizvodu";
            lblName.Text = "Naziv";
            lblQuantity.Text = "Količina";
            lblDescription.Text = "Opis";
            lblManufacturer.Text = "Proizvođač";
            lblPurchasePrice.Text = "Nabavna cijena";
            lblSellingPrice.Text = "Prodajna cijena";
            btnSave.Text = "Sačuvaj";
            btnCancel.Text = "Otkaži";
            MISSING_FIELDS = "Sva polja su obavezna!";
            MANUFACTURER = "Proizvođač:";
            ERR = "Greška";
            SUCCESS_PRODUCT = "Proizvod uspješno dodat.";
        }

        private void setEnglish()
        {
            this.Text = "New product";
            lblTitleProductData.Text = "Product data";
            lblName.Text = "Name";
            lblQuantity.Text = "Quantity";
            lblDescription.Text = "Description";
            lblManufacturer.Text = "Manufacturer";
            lblPurchasePrice.Text = "Purchase price";
            lblSellingPrice.Text = "Selling price";
            btnSave.Text = "Save";
            btnCancel.Text = "Cancel";
            MISSING_FIELDS = "All fields are required!";
            MANUFACTURER = "Manufacturer:";
            ERR = "Error";
            SUCCESS_PRODUCT = "Product added successfully.";
        }


        private void initializeManufacturers()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    try
                    {
                        var manufacturers = context.Manufacturers.ToArray();

                        foreach (var m in manufacturers)
                        {
                            comboBoxManufacturer.Items.Add(m.Name);
                        }
                        comboBoxManufacturer.Text = MANUFACTURER;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add manufacturer combobox:" + ex.Message);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("New product: " + ex.Message);
            }
        }

        private void hideAllRedLabels()
        {
            lblEmptyName.Hide();
            lblEmptyQuantity.Hide();
            lblEmptyDescription.Hide();
            lblEmptyManufacturer.Hide();
            lblEmptySellingPrice.Hide();
            lblEmptyPurchasePrice.Hide();
            lblRequiredFields.Hide();
        }

       
       private void saveProduct()
       {
            
            int tmp = 0;
            string message = "";
            
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                lblEmptyName.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyName.Hide();
            }

            if(numUpDownQuantity.Value < 1)
            {
                lblEmptyQuantity.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyQuantity.Hide();
            }

            if(string.IsNullOrEmpty(tbDescription.Text.Trim()))
            {
                lblEmptyDescription.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyQuantity.Hide();
            }

            if(string.IsNullOrEmpty(comboBoxManufacturer.Text.Trim()))
            {
                lblEmptyManufacturer.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyQuantity.Hide();
            }

            if(string.IsNullOrEmpty(tbSellingPrice.Text.Trim()))
            {
                lblEmptySellingPrice.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyQuantity.Hide();
            }

            if(string.IsNullOrEmpty(tbPurchasePrice.Text.Trim()))
            {
                lblEmptyPurchasePrice.Show();
                message = MISSING_FIELDS;
            }
            else
            {
                lblEmptyQuantity.Hide();
            }

            if (!(string.IsNullOrEmpty(message)))
                //MessageBox.Show(message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRequiredFields.Show();
            else
            {
                try
                {
                    using (var context = new PharmacyDB())
                    {
                        //DODAVANJE NOVOG PROIZVODJACA AKO JE POTREBNO I PROVJERA DA LI ON POSTOJI U BAZI
                        var manufacturer = comboBoxManufacturer.Text;
                        if (context.Manufacturers.Where(m => m.Name == manufacturer).FirstOrDefault() == null)
                        {
                            Manufacturer mnf = new Manufacturer() { Name = manufacturer };
                            //try
                            //{

                            //    context.Manufacturers.Add(mnf);
                            //    context.SaveChanges();
                            //}
                            //catch(Exception ex)
                            //{
                            //    MessageBox.Show(ex.Message);
                            //}
                            InsertManufacturer(mnf);
                        }

                        //CIJENA PROIZVODA
                        var purchasePrice = Convert.ToDecimal(tbPurchasePrice.Text.Trim());
                        var sellingPrice = Convert.ToDecimal(tbSellingPrice.Text.Trim());

                        if (context.Prices.Where(p => p.PurchasePrice == purchasePrice && p.SellingPrice == sellingPrice).FirstOrDefault() == null)
                        {
                            Price price = new Price { PurchasePrice = purchasePrice, SellingPrice = sellingPrice };
                            InsertPrice(price);
                        }

                        //provjera da li proizvod vec postoji u bazi, odnosno da li se radi samo njegova izmjena
                        var product = context.Products.Where(p => p.Name == tbName.Text && p.Manufacturer.Name == manufacturer).FirstOrDefault();
                        if (product != null)
                        {
                            context.Entry(product).State = EntityState.Modified;
                        }
                        else
                        {
                            product = new Product() { IsDeleted = 0 };
                        }
                        //DODAVANJE PROIZVODA

                        product.Name = tbName.Text;
                        product.Quantity = (int)numUpDownQuantity.Value;
                        product.Description = tbDescription.Text;
                        product.ManufacturerId = context.Manufacturers.Where(m => m.Name == manufacturer).FirstOrDefault().ManufacturerId;
                        product.PriceId = context.Prices.Where(p => p.PurchasePrice == purchasePrice && p.SellingPrice == sellingPrice).FirstOrDefault().PriceId;


                        var state = context.Entry(product).State;

                        try
                        {
                            //Console.WriteLine(context.Entry(newProduct).State.ToString());
                            if (state != EntityState.Modified)
                            {
                                //Product newProduct = new Product(product);
                                context.Products.Add(product);
                            }
                            var success = context.SaveChanges();
                            if (success != 0)
                            {
                                hideAllRedLabels();
                                MessageBox.Show(SUCCESS_PRODUCT,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Save product: " + ex.Message);
                }
            }
        }

        private void InsertManufacturer(Manufacturer manufacturer)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.Manufacturers.Add(manufacturer);
                    context.SaveChanges();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertPrice(Price price)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.Prices.Add(price);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertReceiptItem(ReceiptItem receiptItem)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.ReceiptItems.Add(receiptItem);
                    context.SaveChanges();        
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProduct();
        }


        public void setProductData(Product product)
        {
            tbName.Text = product.Name;
            numUpDownQuantity.Value = (int)product.Quantity;
            tbDescription.Text = product.Description;
            comboBoxManufacturer.Text = product.Manufacturer.Name;
            tbPurchasePrice.Text = product.Price.PurchasePrice.ToString().Replace('.',',');
            tbSellingPrice.Text = product.Price.SellingPrice.ToString().Replace('.', ',');
        }
       

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoldPriceNoPrescript_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoldPriceNoPrescript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Functions.isSpecificCharacter(e.KeyChar) || Functions.isLetterString(e.KeyChar.ToString()) )
            {
                e.Handled = true;
            }
        }

        private void tbSoldPricePrescript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Functions.isSpecificCharacter(e.KeyChar) || Functions.isLetterString(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                numUpDownQuantity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                
                if (string.IsNullOrEmpty(tbName.Text.Trim()))
                {
                    lblEmptyName.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblEmptyName.Hide();
                    lblRequiredFields.Hide();
                    numUpDownQuantity.Focus();
                    e.Handled = true;
                }
            }
        }

        private void numUpDownQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbDescription.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbName.Focus();
                e.Handled = true;
            }
            if (e.KeyCode==Keys.Enter && numUpDownQuantity.Value==0)
            {
                lblEmptyQuantity.Show();
                lblRequiredFields.Show();
            }
            else
            {
                lblEmptyQuantity.Hide();
                lblRequiredFields.Hide();
                tbDescription.Focus();
                e.Handled = true;
            }
        }

        private void tbDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                comboBoxManufacturer.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                numUpDownQuantity.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbDescription.Text.Trim()))
                {
                    lblEmptyDescription.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblEmptyDescription.Hide();
                    lblRequiredFields.Hide();
                    comboBoxManufacturer.Focus();
                    e.Handled = true;
                }
            }
        }

        private void comboBoxManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbPurchasePrice.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbDescription.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (comboBoxManufacturer.SelectedIndex<0)
                {
                    lblEmptyManufacturer.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblEmptyManufacturer.Hide();
                    lblRequiredFields.Hide();
                    tbPurchasePrice.Focus();
                    e.Handled = true;
                }
            }
        }

        private void tbPurchasePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tbSellingPrice.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                comboBoxManufacturer.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbPurchasePrice.Text.Trim()))
                {
                    lblEmptyPurchasePrice.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblEmptyPurchasePrice.Hide();
                    lblRequiredFields.Hide();
                    tbSellingPrice.Focus();
                    e.Handled = true;
                }
            }
        }

        private void tbSellingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnSave.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbPurchasePrice.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbSellingPrice.Text.Trim()))
                {
                    lblEmptySellingPrice.Show();
                    lblRequiredFields.Show();
                }
                else
                {
                    lblEmptySellingPrice.Hide();
                    lblRequiredFields.Hide();
                    btnSave.Focus();
                    e.Handled = true;
                }
            }

        }

       
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                btnCancel.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                tbSellingPrice.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                btnSave.Focus();
                e.Handled = true;
            }
           
        }
    }
}
