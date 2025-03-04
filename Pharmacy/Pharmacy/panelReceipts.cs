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
    public partial class panelReceipts : UserControl
    {
        public panelReceipts()
        {
            InitializeComponent();
            adjustDGHeight();
            loadReceipts();
            setLanguage();
            comboBoxSorting.SelectedIndex = 0;
            checkBoxSorting.Checked = true;
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
        public void setSerbian()
        {
            lblReceiptsHeader.Text = "Računi";
            
            btnNewReceipt.Text = "Novi račun";
            lblSearch.Text = "Pretraga";
            lblSorting.Text = "Sortiranje";
            dgReceipts.Columns[0].HeaderText = "R.B.";
            dgReceipts.Columns[1].HeaderText = "Šifra";
            dgReceipts.Columns[2].HeaderText = "Datum kreiranja";
            dgReceipts.Columns[3].HeaderText = "Farmaceut";
            dgReceipts.Columns[4].HeaderText = "Iznos(KM)";
            List<string> columns = new List<string>{ "R.B.", "Šifra", "Datum kreiranja", "Farmaceut", "Iznos(KM)"};
            List<string> items = new List<string> { "Datum", "Farmaceut", "Iznos(KM)"};
            int i = 0;
            foreach(var element in columns)
            {
                dgReceipts.Columns[i++].HeaderText = element;
            }
            i = 0;
            foreach(var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }
        }

        public void setEnglish()
        {
            lblReceiptsHeader.Text = "Receipts";
            
            btnNewReceipt.Text = "New receipt";
            lblSearch.Text = "Search";
            lblSorting.Text = "Sort by";
            dgReceipts.Columns[0].HeaderText = "S.N.";
            dgReceipts.Columns[1].HeaderText = "ID";
            dgReceipts.Columns[2].HeaderText = "Date of creation";
            dgReceipts.Columns[3].HeaderText = "Pharmacist";
            dgReceipts.Columns[4].HeaderText = "Amount(KM)";
            List<string> columns = new List<string> { "S.N.", "ID", "Date of creation", "Pharmacist", "Total price(KM)" };
            List<string> items = new List<string> { "Date", "Pharmacist", "Total price(KM)" };
            int i = 0;
            foreach (var element in columns)
            {
                dgReceipts.Columns[i++].HeaderText = element;
            }
            i = 0;
            foreach (var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }
        }

        public void setTheme(Theme theme)
        {
            panelReceiptsHeader.BackColor = panelReceiptsFooter.BackColor = theme.headerFooterColor;
            BackColor = theme.backColor;
            lblReceiptsHeader.ForeColor = theme.foreColorMain;
            lblSorting.ForeColor = lblSearch.ForeColor = btnNewReceipt.ForeColor = theme.foreColorText;
            lblReceiptsHeader.Font = new Font(theme.font, 12);
            
        }
       

      

        private decimal totalPrice(Receipt receipt)
        {
            decimal total = 0;
            foreach (var item in receipt.ReceiptItems)
            {
                total += (decimal)item.Product.Price.SellingPrice;
            }
            return total;
        }

        private void addReceiptItem(Product product)
        {
            //int quantity = (int)numQuantity.Value;
            int productId = product.ProductId;
            string name = product.Name;
            string description = product.Description;
            string manufacturerName = product.Manufacturer.Name;
            decimal price = (decimal)product.Price.SellingPrice;

            try
            {
                using (var context = new PharmacyDB())
                {


                    ReceiptItem item = new ReceiptItem
                    {
                        ProductId = product.ProductId,
                        //Quantity = (int)numQuantity.Value,
                    };

                    /*if (quantity == 0)
                    {
                        MessageBox.Show("Niste unijeli količinu", "Greška", MessageBoxButtons.OK);
                    }
                    else
                    {
                        context.ReceiptItems.Add(item);
                        context.SaveChanges();
                        //dgProducts.Rows.Add(item.ProductId, item.Product.Name, item.Quantity, item.Product.Description, item.Product.Manufacturer.Name, item.Product.Price.SellingPrice);
                        //dgProducts.Refresh();
                    }*/

                }
            }catch(Exception ex)
            {
                Console.WriteLine("Receipt item adding... " + ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new PharmacyDB())
            {
                var users = context.Products.ToArray();
                var words = tbSearch.Text.Trim().ToLower().Split(' ').ToList();
                int count = words.Count;

                /*foreach (DataGridViewRow row in dgProducts.Rows)
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

                }*/
            }
        }


        private List<Product> sortProducts(string criteria, bool ascending)
        {
            if (criteria == "Name" || criteria == "Naziv")
            {
                return sortByName(ascending);
            }
            else if (criteria == "Id" || criteria == "Šifra")
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
            List<Product> result = new List<Product>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var products = context.Products.ToList();
                    if (ascending == true)
                    {
                        result=products.OrderBy(p => p.Price.SellingPrice).ToList();
                    }
                    else
                    {
                        result=products.OrderByDescending(p => p.Price.SellingPrice).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }


        private void displayProducts(List<Product> products)
        {
            using (var context = new PharmacyDB())
            {
                foreach (Product product in products)
                {
                    string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
                    decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
                    decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;
                    //int r = dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, purchasePrice, sellingPrice);
                }
            }
        }

        private void loadReceipts()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var receipts = context.Receipts.ToArray();
                    int count = 1;
                    foreach (var receipt in receipts)
                    {
                        var pharmacist = context.Users.Where(u => u.UserId == receipt.PharmacistId).FirstOrDefault();
                        
                        int r = dgReceipts.Rows.Add(count,receipt.ReceiptId,receipt.Date,pharmacist.FirstName+" "+pharmacist.LastName,receipt.TotalPrice);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load receipts:" + ex.Message);
            }
        }

        private void adjustDGHeight()
        {
            int rowsHeight = dgReceipts.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight = dgReceipts.ColumnHeadersHeight;
            dgReceipts.Height = rowsHeight + headerHeight + 2;
        }


        public void setTitleReceiptsColor(Color color)
        {
            lblReceiptsHeader.ForeColor = color;
        }
    
        public void setPanelColors(Color headerFooterColor, Color backColor)
        {
            panelReceiptsHeader.BackColor = panelReceiptsFooter.BackColor = headerFooterColor;
            this.BackColor = backColor;

        }

        public void setPanelFont(FontFamily font)
        {
            lblReceiptsHeader.Font = new Font(font, (float)Convert.ToInt32(lblReceiptsHeader.Font.Size));
            
            //lblSorting.Font = new Font(font, (float)Convert.ToInt32(lblUsersHeader.Size));
            //lblSearch.Font = new Font(font, (float)Convert.ToInt32(lblUsersHeader.Size));
            btnNewReceipt.Font= new Font(font, (float)Convert.ToInt32(btnNewReceipt.Font.Size));
        }

        private void setPanelProperties(Color headerFooterColor, Color backColor, FontFamily font)
        {
            setPanelColors(headerFooterColor, backColor);
            setPanelFont(font);
        }
        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            
            new NewReceiptForm().Show();
        }

        private List<Receipt> sortByDateTime(bool ascending)
        {
            List<Receipt> result = new List<Receipt>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Receipts.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(r => r.Date).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(r => r.Date).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<Receipt> sortByTotalPrice(bool ascending)
        {
            List<Receipt> result = new List<Receipt>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Receipts.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(r => r.TotalPrice).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(r => r.TotalPrice).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<Receipt> sortByPharmacistName(bool ascending)
        {
            List<Receipt> result = new List<Receipt>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Receipts.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(r => r.User.FirstName).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(r => r.User.FirstName).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }



        private void resetPanel()
        {
            dgReceipts.Visible = btnNewReceipt.Visible = true;

            //dgProducts.Visible = dgReceipt.Visible = btnConfirm.Visible = btnNewReceiptItem.Visible
            //= numQuantity.Visible = comboBoxSorting.Visible = checkBoxSorting.Visible = false;

        }

        private void setPanelForNewReceipt()
        {
            dgReceipts.Visible =  
            btnNewReceipt.Visible = false;

        }



    }
}
