using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{




    public class OrderDetail
    {

        public decimal Quantity { get; set; }
        public decimal TaxStatus { get; set; }
        public Item Item { get; set; } //Ürün ve Emir Detayı arasında zayıf ilişki kurdum(aggregation).

        public const decimal TAX = 0.18M;
        public OrderDetail()
        {
            this.Item = new Item();
        }

        public decimal CalcSubTotal()
        {
            TaxStatus = Item.GetPriceForQuantity() * TAX;
            return Quantity = TaxStatus + Item.GetPriceForQuantity();


        }

        public decimal CalcWeight(decimal shippingWeight, decimal itemNumber)
        {
            
            decimal weight ;
            return weight = shippingWeight * itemNumber;
        }
    }
}





