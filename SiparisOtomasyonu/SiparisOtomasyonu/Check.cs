using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public class Check:Payment
    {
       public string BankId { get; set; }
        public string CheckName { get; set; }
        public Check()
        {

        }
        public override decimal Pay(decimal price)
        {
            Amount -= price;
            return Amount;                                                                                                        
        }

        public bool Authorized()
        {
            return true;
        }
    }
}
