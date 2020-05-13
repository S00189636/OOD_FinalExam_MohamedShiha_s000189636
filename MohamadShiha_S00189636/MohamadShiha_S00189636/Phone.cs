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

        // used in test project
        public Phone() { }
        public Phone(string name,decimal price,string operatingSystem,string oS_Image,string phone_Image) 
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = oS_Image;
            Phone_Image = phone_Image;
        }


        public void IncreasePrice(decimal percentage)
        {
            if (Price <= 0) return;
            decimal addedValue = (percentage / Price) * 100;
            Price += addedValue;
        }
    }
}
