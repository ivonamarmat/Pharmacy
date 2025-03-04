using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Price
    {
        public Price(decimal purchasePrice, decimal soldPriceWithPrescription, decimal soldPriceWithoutPrescription)
        {
            PurchasePrice = purchasePrice;
            SoldPriceWithPrescription = soldPriceWithPrescription;
            SoldPriceWithoutPrescription = soldPriceWithoutPrescription;
        }

        public decimal PurchasePrice { get; set; }
        public decimal SoldPriceWithPrescription { get; set; }
        public decimal SoldPriceWithoutPrescription { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Price price &&
                   PurchasePrice == price.PurchasePrice &&
                   SoldPriceWithPrescription == price.SoldPriceWithPrescription &&
                   SoldPriceWithoutPrescription == price.SoldPriceWithoutPrescription;
        }

        public override int GetHashCode()
        {
            int hashCode = 1866845271;
            hashCode = hashCode * -1521134295 + PurchasePrice.GetHashCode();
            hashCode = hashCode * -1521134295 + SoldPriceWithPrescription.GetHashCode();
            hashCode = hashCode * -1521134295 + SoldPriceWithoutPrescription.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
