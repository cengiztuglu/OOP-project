using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Credit:Payment
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string ExpDate { get; set; }
        public string CVC { get; set; }

        public Credit()
        {

        }
        public override decimal Pay(decimal price)
        {
            Amount-= price; 
            return Amount;
        }

        public bool Authorized()
        {
            return true; //Yetkilendirme işlemini default doğru kabul ettim.
        }
    }
}
