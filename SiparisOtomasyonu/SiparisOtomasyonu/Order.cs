using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public class Order
    {
        public  DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public OrderDetail OrderDetail { get; set; }
      public const decimal SHIPMENTFEE = 11.11M;
       
        public decimal TotalFee { get; set; }
        public Order()
        {
            this.OrderDetail = new OrderDetail();
            
        }
        public decimal CalcTax()
        {
            return OrderDetail.Item.GetPriceForQuantity()*OrderDetail.TAX;

        }
        public decimal CalcTotal()
        {

           
            TotalFee= SHIPMENTFEE+OrderDetail.CalcSubTotal();
            return TotalFee;
        }
        public decimal CalcTotalWeight(decimal shippingWeight,decimal itemNumber)
        {
            decimal totalWeight = 0;
            totalWeight += shippingWeight*itemNumber;
            return totalWeight;
        }
    }
}
