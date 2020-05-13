using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MohamadShiha_S00189636
{
    public class PhoneData :DbContext
    {

        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones;
    }
}
