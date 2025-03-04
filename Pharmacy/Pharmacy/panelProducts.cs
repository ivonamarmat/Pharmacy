using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class panelProducts : UserControl
    {
        string DELETE;
        string DELETE_CONFIRM;
        string SUCCESS_DELETE;
        string EDIT_BUTTON;
        string DELETE_BUTTON;
        public panelProducts()
        {
            InitializeComponent();
            setLanguage();
            addColumnButtons();
            dgProducts.Rows.Clear();
            loadAndDisplayProducts();
            //loadProducts();
            comboBoxSorting.SelectedIndex = 0;
            checkBoxSorting.Checked = true;
            //var products = new PharmacyDB().Products.ToList();
           
            
            //displayProducts(sortProducts(comboBoxSorting.SelectedItem.ToString(), true));   
           
        }

      public void panelRefresh()
        {
            loadAndDisplayProducts();
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
                Console.WriteLine("Pharm language " + ex.Message);
            }
        }
        public void setSerbian()
       {
            lblProductsHeader.Text = "Proizvodi";
            btnNewProduct.Text = "Novi proizvod";
            lblSearch.Text = "Pretraga";
            lblSorting.Text = "Sortiranje";
            DELETE = "Brisanje";
            DELETE_CONFIRM = "Potvrdite brisanje.";
            SUCCESS_DELETE = "Proizvod uspješno obrisan.";
            EDIT_BUTTON = "Izmijeni";
            DELETE_BUTTON = "Obriši";
           //edit delete
            List<string> columns = new List<string>{ "Šifra", "Naziv", "Količina", "Opis", "Proizvođač", "Nabavna cijena(KM)","Prodajna cijena(KM)" };
            List<string> items = new List<string> { "Šifra", "Naziv", "Količina", "Cijena" };
            int i = 0;
            foreach(var element in columns)
            {
                dgProducts.Columns[i++].HeaderText = element;
            }
            i = 0;
            foreach(var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }
       }

        public void setEnglish()
        {
            lblProductsHeader.Text = "Products";
            btnNewProduct.Text = "New product";
            lblSearch.Text = "Search";
            lblSorting.Text = "Sort by";
            DELETE = "Delete";
            DELETE_CONFIRM = "Delete confirm.";
            SUCCESS_DELETE = "Product is successfully deleted.";
            
            EDIT_BUTTON = "Edit";
            DELETE_BUTTON = "Delete";
            List<string> columns = new List<string> { "ID", "Name", "Quantity", "Description", "Manufacturer", "Purchase price(KM)","Selling price(KM" };
            List<string> items = new List<string> { "ID", "Name", "Quantity", "Price" };
            int i = 0;
            foreach (var element in columns)
            {
                dgProducts.Columns[i++].HeaderText = element;
            }

            i = 0;
            foreach (var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }

        }


        public void setTheme(Theme theme)
        {
            panelProductsHeader.BackColor = panelProductsFooter.BackColor = theme.headerFooterColor;
            BackColor = theme.backColor;
            lblProductsHeader.ForeColor = theme.foreColorMain;
            lblProductsHeader.Font = new Font(theme.font, 12);
            lblSorting.ForeColor = lblSearch.ForeColor = btnNewProduct.ForeColor = theme.foreColorText;
            lblSorting.Font = lblSearch.Font = btnNewProduct.Font = new Font(theme.font, 11);
            
        }
        private void addColumnButtons()
        {
            
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Text = EDIT_BUTTON;
            editButtonColumn.UseColumnTextForButtonValue = true;
            
            
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Text = DELETE_BUTTON;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgProducts.Columns.Add(editButtonColumn);
            dgProducts.Columns.Add(deleteButtonColumn);
        }


        private void adjustDGHeight()
        {
            int rowsHeight = dgProducts.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight = dgProducts.ColumnHeadersHeight;
            dgProducts.Height = rowsHeight + headerHeight + 2; 

            
        }


        //private void loadProducts()
        //{
        //    try
        //    {
        //        using (var context = new PharmacyDB())
        //        {
        //            Product[] products = context.Products.ToArray();
        //            foreach(Product product in products) 
        //            {
        //                string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
        //                decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
        //                decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;
        //                int r=dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, purchasePrice,sellingPrice); 
        //            }
                   
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Load products:" + ex.Message);
        //    }
        //}

        private void selectProduct()
        {
            
        }
        public void setTitleProductsColor(Color color)
        {
            lblProductsHeader.ForeColor = color;
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            new NewProductForm().Show();
            
        }

        public void dgProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >=0 && e.ColumnIndex < 7)
            {
                //int column = e.ColumnIndex;
                int id = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells[0].Value);
                try
                {
                    using (var context = new PharmacyDB())
                    {
                        var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
                        updatePoduct(product);

                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Update " + ex.Message);
                }

            }
        }



        private void updatePoduct(Product product)
        {
            try
            {
                    var productForm = new NewProductForm();
                    productForm.setProductData(product);
                    productForm.Show();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update product" + ex.Message);
            }
        }

       

    
        private void dgProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int row = e.RowIndex;
            ////int column = e.ColumnIndex;
            //int id = Convert.ToInt32(dgProducts.Rows[row].Cells[0].Value);
            //try
            //{
            //    using (var context = new PharmacyDB())
            //    {
            //        var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            //        updatePoduct(product);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Update product" + ex.Message);
            //}
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    using (var context = new PharmacyDB())
                    {
                        if (e.ColumnIndex == 7 || e.ColumnIndex == 8)
                        {
                            int id = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells[0].Value);
                            var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();

                            if (e.ColumnIndex == 7)//OPCIJA EDIT
                            {
                                try
                                {
                                    if (product != null)
                                    {
                                        updatePoduct(product);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Update product: " + ex.Message);
                                }
                            }
                            else if (e.ColumnIndex == 8)//OPCIJA DELETE
                            {
                                string message = DELETE_CONFIRM;
                                DialogResult result = MessageBox.Show(message, DELETE, MessageBoxButtons.OKCancel);
                                if (result == DialogResult.OK)
                                {

                                    context.Products.Where(p => p.ProductId == id).FirstOrDefault().IsDeleted = (byte)1;
                                    context.SaveChanges();
                                    MessageBox.Show("", SUCCESS_DELETE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            displayProducts(context.Products.ToList());
                        }
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Click Prod " + ex.Message);
                }
            }
        }

        

        

        public void setPanelColors(Color headerFooterColor, Color backColor)
        {
            panelProductsHeader.BackColor = panelProductsFooter.BackColor = headerFooterColor;
            this.BackColor = backColor;
            
        }

        public void setPanelFont(FontFamily font)
        {
            
            lblProductsHeader.Font = new Font(font, (float)Convert.ToInt32(lblProductsHeader.Font.Size));
            lblSorting.Font = new Font(font, (float)Convert.ToInt32(lblSorting.Font.Size));
            lblSearch.Font = new Font(font, (float)Convert.ToInt32(lblSearch.Font.Size));
            btnNewProduct.Font= new Font(font, (float)Convert.ToInt32(btnNewProduct.Font.Size));
            
        }

        private void setPanelProperties(Color headerFooterColor, Color backColor, FontFamily font)
        {
            setPanelColors(headerFooterColor, backColor);
            setPanelFont(font);
        }

        
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Products.ToArray();
                    var words = tbSearch.Text.Trim().ToLower().Split(' ').ToList();
                    int count = words.Count;

                    foreach (DataGridViewRow row in dgProducts.Rows)
                    {
                        List<int> indexes = new List<int>();

                        foreach (string word in words)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                DataGridViewCell cell = row.Cells[i];

                                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(word))
                                {

                                    if (!indexes.Contains(i))
                                    {
                                        indexes.Add(i);
                                        break;
                                    }
                                }
                            }
                        }

                        if (indexes.Count == count)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }

                    }
                }

                adjustDGHeight();
            }catch(Exception ex)
            {
                Console.WriteLine("Search " + ex.Message);
            }
        }

       
        private List<Product> sortProducts(string criteria, bool ascending)
        {
            switch (criteria)
            {
                case "ID":
                case "Šifra":
                    return sortByProductId(ascending);

                case "Name":
                case "Naziv":
                    return sortByName(ascending);

                case "Quantity":
                case "Količina":
                    return sortByQuantity(ascending);

                case "Price":
                case "Cijena":
                    return sortByPrice(ascending);

                default:
                    return null;
            }
           
            
        }
       
        private List<Product> sortByName(bool ascending)
        {
            List<Product> result = new List<Product>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var products = context.Products.ToList();
                    if (ascending == true)
                    {
                        return products.OrderBy(p => p.Name).ToList();
                    }
                    else
                    {
                        return products.OrderByDescending(p => p.Name).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<Product> sortByProductId(bool ascending)
        {
            List<Product> result = new List<Product>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var products = context.Products.ToList();
                    if (ascending == true)
                    {
                        result=products.OrderBy(p => p.ProductId).ToList();
                    }
                    else
                    {
                        result=products.OrderByDescending(p => p.ProductId).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<Product> sortByQuantity(bool ascending)
        {
            List<Product> result = new List<Product>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var products = context.Products.ToList();
                    if (ascending == true)
                    {
                        result=products.OrderBy(p => p.Quantity).ToList();
                    }

                    else
                    {
                        result=products.OrderByDescending(p => p.Quantity).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<Product> sortByPrice(bool ascending)
        {
            List<Product> result=new List<Product>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var products = context.Products.ToList();
                    if (ascending == true)
                    {
                        result= products.OrderBy(p => p.Price.SellingPrice).ToList();
                    }
                    else
                    {
                        result= products.OrderByDescending(p => p.Price.SellingPrice).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
                
            }
            return result;
        }

        private void loadAndDisplayProducts()
        {
            try
            {
                displayProducts(new PharmacyDB().Products.ToList());
            } catch(Exception ex)
            {
                Console.WriteLine("Products: " + ex.Message);

            }
        }
        private void displayProducts(List<Product> products)
        {
            dgProducts.Rows.Clear();

            try
            {
                using (var context = new PharmacyDB())
                {
                    foreach (Product product in products)
                    {
                        if (product.IsDeleted == 0)
                        {
                            string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
                            decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
                            decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;

                            int r = dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, purchasePrice, sellingPrice);
                        }
                    }
                    adjustDGHeight();
                    dgProducts.Refresh();
                    dgProducts.Show();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
        }

        private void comboBoxSorting_SelectedValueChanged(object sender, EventArgs e)
        {
            string criteria = comboBoxSorting.SelectedItem.ToString();
            bool ascending = (checkBoxSorting.Checked) ? true : false;
            displayProducts(sortProducts(criteria, ascending));
        }

      

        private void checkBoxSorting_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxSorting.SelectedItem.ToString());
            List<Product> products = new List<Product>();
            bool isChecked= (checkBoxSorting.Checked) ? true : false;

            switch (comboBoxSorting.SelectedItem.ToString())
            {
                case "ID": 
                case "Šifra":

                    {
                        products=sortByProductId(isChecked);
                        break;
                    }

                case "Name":
                case "Naziv":
                    {
                        Console.WriteLine("Mrvica.");
                        products=sortByName(isChecked);
                        foreach (var p in products) Console.WriteLine(p.Name);
                        break;
                    }


                case "Quantity":
                case "Količina":
                    {
                        products = sortByQuantity(isChecked);
                        break;
                    }

                case "Price":
                case "Cijena":
                    {
                        products = sortByPrice(isChecked);
                        break;
                    }
            }
            
            displayProducts(products);
        }
    }
    }

