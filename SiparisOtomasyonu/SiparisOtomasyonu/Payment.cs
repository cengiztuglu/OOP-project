using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public abstract class Payment
    {
        public decimal Amount { get; set; }
        public Payment()
        {

        }
        public abstract decimal Pay(decimal price);
        
    }
}
