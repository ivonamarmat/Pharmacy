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
    public partial class panelNewReceipt : UserControl
    {
        Receipt receipt = new Receipt();
        public panelNewReceipt()
        {
            InitializeComponent();
            comboBoxSorting.SelectedIndex=0;
            checkBoxSorting.Checked = true;
            //loadProducts();
            loadAndDisplayProducts();
            adjustDGHeight();
        }


        private void loadAndDisplayProducts()
        {
            try
            {
                displayProducts(new PharmacyDB().Products.ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Products: " + ex.Message);

            }
        }
        private void adjustDGHeight()
        {
            int rowsHeight = dgProducts.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight = dgProducts.ColumnHeadersHeight;
            dgProducts.Height = rowsHeight + headerHeight + 2; 
        }


        private void loadProducts()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    Product[] products = context.Products.ToArray();
                    foreach(Product product in products) 
                    {
                        string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
                        decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
                        decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;
                        int r=dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, purchasePrice,sellingPrice); 
                    }
                   
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load products:" + ex.Message);
            }
        }

        private void selectProduct()
        {
            
        }
        public void setTitleProductsColor(Color color)
        {
            lblNewReceiptHeader.ForeColor = color;
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            new NewProductForm().Show();
            
        }

        public void dgProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            //int column = e.ColumnIndex;
            int id = Convert.ToInt32(dgProducts.Rows[row].Cells[0].Value);
            
            using (var context = new PharmacyDB())
            {
               var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
                if (product != null)
                {
                    addReceiptItem(product);
                    
                }
            }
           
        }
          
        private void createReceipt()
        {
            Receipt receipt = new Receipt { };
        }


        private void addReceiptItem(Product product)
        {
            //int quantity = (int)numQuantity.Value;
            int productId = product.ProductId;
            string name = product.Name;
            string description = product.Description;
            string manufacturerName = product.Manufacturer.Name;
            decimal price = (decimal)product.Price.SellingPrice;

            using (var context = new PharmacyDB())
            {
                ReceiptItem item = new ReceiptItem
                {
                    ProductId = product.ProductId,
                    //Quantity = (int)numQuantity.Value,
                   
                };

                    receipt.ReceiptItems.Add(item);
                    context.ReceiptItems.Add(item);
                    context.SaveChanges();
                    dgProducts.Rows.Add(item.ProductId, item.Product.Name, item.Quantity, item.Product.Description, item.Product.Manufacturer.Name,item.Product.Price.SellingPrice);
                    dgProducts.Refresh();
            }
        }

        private decimal totalPrice()
        {
            decimal total=0;
            foreach(var item in receipt.ReceiptItems)
            {
                total += (decimal)item.Product.Price.SellingPrice;
            }
            return total;
        }

        private void btnNewReceiptItem_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
                try
                {
                    using (var context = new PharmacyDB())
                    {
                        context.Receipts.Add(receipt);
                        int success = context.SaveChanges();
                        if (success != 0)
                        {
                            MessageBox.Show("Uspjesno ste kreirali racun.", "", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }

                //ispis poruke o uspjesnom dodavanju
            


        private void dgProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

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
            if (e.RowIndex >= 0 && e.ColumnIndex>=0 && dgProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgProducts.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    try
                    {
                        using (var context = new PharmacyDB())
                        {
                            int id = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells[0].Value);
                            var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
                            if (product != null)
                            {
                                //updatePoduct(product);
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Update product: " + ex.Message);
                    }
                }

            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgProducts.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    try
                    {
                        using (var context = new PharmacyDB())
                        {
                            int id = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells[0].Value);
                            var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
                            if (product != null)
                            {
                                //updatePoduct(product);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Update product: " + ex.Message);
                    }
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
            
            lblNewReceiptHeader.Font = new Font(font, (float)Convert.ToInt32(lblNewReceiptHeader.Font.Size));
            lblSorting.Font = new Font(font, (float)Convert.ToInt32(lblSorting.Font.Size));
            lblSearch.Font = new Font(font, (float)Convert.ToInt32(lblSearch.Font.Size));     
        }

        private void setPanelProperties(Color headerFooterColor, Color backColor, FontFamily font)
        {
            setPanelColors(headerFooterColor, backColor);
            setPanelFont(font);
        }

        
        private void tbSearch_TextChanged(object sender, EventArgs e)
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
        }

        private List<Product> sortProducts(string criteria, bool ascending)
        {
            if (criteria == "Name" || criteria == "Naziv")
            {
                return sortByName(ascending);
            }
            else if (criteria == "ID" || criteria == "Šifra")
            {
                return sortByProductId(ascending);
            }
            else if (criteria == "Quantity" || criteria == "Količina")
            {
                return sortByQuantity(ascending);
            }
            else if (criteria == "Price" || criteria == "Cijena")
            {
                return sortByPrice(ascending);
            }
            else return null;
        }
       
        private List<Product> sortByName(bool ascending)
        {
            using(var context=new PharmacyDB())
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

        private List<Product> sortByProductId(bool ascending)
        {
            using (var context = new PharmacyDB())
            {
                var products = context.Products.ToList();
                if (ascending == true)
                {
                    return products.OrderBy(p => p.ProductId).ToList();
                }
                else
                {
                    return products.OrderByDescending(p => p.ProductId).ToList();
                }

            }
        }

        private List<Product> sortByQuantity(bool ascending)
        {
            using (var context = new PharmacyDB())
            {
                var products = context.Products.ToList();
                if (ascending == true)
                {
                    return products.OrderBy(p => p.Quantity).ToList();
                }

                else
                {
                    return products.OrderByDescending(p => p.Quantity).ToList();
                }
            }
        }

        private List<Product> sortByPrice(bool ascending)
        {
            using (var context = new PharmacyDB())
            {
                var products = context.Products.ToList();
                if (ascending == true)
                {
                    return products.OrderBy(p => p.Price.SellingPrice).ToList();
                }
                else
                {
                    return products.OrderByDescending(p => p.Price.SellingPrice).ToList();
                }
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
                        string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
                        decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
                        decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;
                        int r = dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, purchasePrice, sellingPrice);
                    }
                    adjustDGHeight();
                    dgProducts.Refresh();
                    dgProducts.Show();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Products: "+ex.Message);
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
            bool isChecked = (checkBoxSorting.Checked) ? true : false;

            switch (comboBoxSorting.SelectedItem.ToString())
            {
                case "ID":
                case "Šifra":

                    {
                        products = sortByProductId(isChecked);
                        break;
                    }

                case "Name":
                case "Naziv":
                    {
                        Console.WriteLine("Mrvica.");
                        products = sortByName(isChecked);
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
            adjustDGHeight();
        }
    }
    }

