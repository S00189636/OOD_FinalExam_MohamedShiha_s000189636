using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamadShiha_S00189636
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }



        public void IncreasePrice(decimal percentage)
        {
            if (Price <= 0) return;
            decimal addedValue = (percentage / Price) * 100;
            Price += addedValue;
        }
    }
}
