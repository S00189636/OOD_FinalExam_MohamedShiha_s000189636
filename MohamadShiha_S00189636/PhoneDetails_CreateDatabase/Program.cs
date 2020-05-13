using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MohamadShiha_S00189636;

namespace PhoneDetails_CreateDatabase
{
    class Program
    {


        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

                db.Phones.Add(p1);
                db.Phones.Add(p2);
                Console.WriteLine("Phones Add to table ");

                db.SaveChanges();
                Console.WriteLine("Changes Saved to Database");
            }
            
        }
    }
}
