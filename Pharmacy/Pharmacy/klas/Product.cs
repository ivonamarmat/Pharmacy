using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SoldPriceWithPerscription { get; set; }

        public decimal SoldPriceWithoutPerscription { get; set; }

        public int StockID { get; set; }


    }
}
