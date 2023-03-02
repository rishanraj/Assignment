using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("-----------------1ST Question-------------------");
            //Saledetails s = new Saledetails(12, 34, 0, 0, Convert.ToDateTime("02/03/2023"));
            //s.Sales();
            //s.Showdata();
            Console.WriteLine("-----------------2ND Question-------------------");

            Scholarship s = new Scholarship(200, 45);
            float scholarshipamount = s.Merit()
            Console.WriteLine("Scholarship Amount:{0}", scholarshipamount);
            Doctor d = new Doctor("Rishan Raj Baruah", "Assam", "KIORTY", 1500, "DENTIST");

            Console.ReadLine();
        }

    }
}
