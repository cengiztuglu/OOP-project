using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Item
    {

        public decimal ShippingWeight { get; set; }
        public string Description { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }

        public decimal ItemNumber { get; set; }/*Meyve & sebze alımlarında kullanabilmek adına Ürün Adedini
                                                 decimal yapmayı tercih ettim.*/

        public Item()
        {

        }

        public Item(string itemName, decimal itemPrice, string description, decimal shippingWeight, decimal itemNumber,int itemId)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.Description = description;
            this.ShippingWeight = shippingWeight;
            this.ItemNumber = itemNumber;
        }

        public decimal GetPriceForQuantity()
        {
            return ItemNumber * ItemPrice; //Ürün sayısı ile ürün fiyatını çarpıp toplam tutarı elde ediyoruz.
        }

        public decimal GetWeight(decimal shippingWeight)
        {
            return this.ShippingWeight; //Kargo ağırlığı ve ürün adedi çarpımı bize sipariş ağırlını verir.
        }
    }
}
