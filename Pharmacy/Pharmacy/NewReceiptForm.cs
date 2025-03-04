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
    public partial class NewReceiptForm : Form
    {
        //Receipt receipt = new Receipt();
        List<Product> products = new PharmacyDB().Products.ToList();
        public NewReceiptForm()
        {
            InitializeComponent();
            dgReceiptItems.Rows.Clear();
           
            addColumnButtons();
            displayProducts();
            adjustDGHeight();
        }

       
        private void displayProducts()
        {
            //dgProducts.Rows.Clear();

            using (var context = new PharmacyDB())
            {
                var products = context.Products.ToList();
                foreach (Product product in products)
                {
                    if (product.IsDeleted == 0)
                    {
                        string manufactName = context.Manufacturers.Where(m => m.ManufacturerId == product.ManufacturerId).FirstOrDefault().Name;
                        decimal purchasePrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().PurchasePrice;
                        decimal sellingPrice = (decimal)context.Prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault().SellingPrice;

                        int r = dgProducts.Rows.Add(product.ProductId, product.Name, product.Quantity, product.Description, manufactName, sellingPrice);
                    }
                }
                adjustDGHeight();
                dgProducts.Refresh();
                dgProducts.Show();
            }
        }

        public void dgProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            var row = dgProducts.Rows[e.RowIndex];
            int r = dgReceiptItems.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value,1);
            int productId = (int)dgProducts.Rows[e.RowIndex].Cells[0].Value;
            decimal price = (decimal)products.Find(p => p.ProductId == productId).Price.SellingPrice;
            //receipt.TotalPrice += price;
            refreshTotalPrice();
            dgReceiptItems.Refresh();
            dgReceiptItems.Show();
            adjustDGHeight();
        }

        private void refreshTotalPrice()
        {
            tbTotalPrice.Text = totalPrice().ToString();
        }

        private decimal totalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgReceiptItems.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells[5].Value);
                decimal price = (decimal)row.Cells[4].Value;
                total += quantity * price;
            }
            return total;
            //return quantity * price;
        }

        private void adjustDGHeight()
        {
            int rowsHeight1 = dgProducts.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight1 = dgProducts.ColumnHeadersHeight;
            dgProducts.Height = rowsHeight1 + headerHeight1 + 2;

            int rowsHeight2 = dgReceiptItems.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight2 = dgReceiptItems.ColumnHeadersHeight;
            dgReceiptItems.Height = rowsHeight2 + headerHeight2 + 2;
        }

        private void addColumnButtons()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Text = "Ukloni";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgReceiptItems.Columns.Add(deleteButtonColumn);
        }
        private void InsertReceipt(Receipt receipt)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    context.Receipts.Add(receipt);
                    context.SaveChanges();
                    //
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            try
            {


                using (var context = new PharmacyDB())
                {

                    foreach (DataGridViewRow row in dgReceiptItems.Rows)
                    {
                        int productId = Convert.ToInt32(row.Cells[0].Value);
                        int quantity = Convert.ToInt32(row.Cells[5].Value);

                        ReceiptItem item = new ReceiptItem
                        {
                            ProductId = productId,
                            Quantity = quantity
                        };

                        //context.ReceiptItems.Add(item);
                        context.SaveChanges();
                        receipt.ReceiptItems.Add(item);
                    }
                    receipt.Date = DateTime.Now;
                    context.Receipts.Add(receipt);
                    context.SaveChanges();
                }
            }catch(Exception ex){
                Console.WriteLine("Receipt: " + ex.Message);
            }
        }

        
        //OMOGUCAVA FUNKCIONALNOST DUGMETA ZA UKLANJANJE STAVKE SA RACUNA
        private void dgReceiptItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                int quantity =Convert.ToInt32(dgReceiptItems.Rows[e.RowIndex].Cells[5].Value);
                decimal price = (decimal)dgReceiptItems.Rows[e.RowIndex].Cells[4].Value;
                dgReceiptItems.Rows.Remove(dgReceiptItems.Rows[e.RowIndex]);
                //receipt.TotalPrice -= quantity * price;
                adjustDGHeight();
                refreshTotalPrice();
                dgReceiptItems.Refresh();
                dgReceiptItems.Show();
            }
        }

        //OMOGUCAVA PROMJENU IZNOSA RACUNA NAKON PROMJENE BROJA ARTIKALA NEKOG PROIZVODA
        private void dgReceiptItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                object cellValue = dgReceiptItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    refreshTotalPrice();
                }
            }
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
            }catch(Exception ex)
            {
                Console.WriteLine("Search " + ex.Message);
            }

            adjustDGHeight();
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
    }



}
