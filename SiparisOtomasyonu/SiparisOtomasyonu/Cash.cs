using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Cash:Payment
    {
        public decimal CashTendered { get; set; }
        public override decimal Pay(decimal price)
        {
            CashTendered -=price;
            return CashTendered;
        }
    }
}
