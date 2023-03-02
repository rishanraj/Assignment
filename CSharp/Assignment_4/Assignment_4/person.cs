using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Person
    {
        protected string Name;
        protected string Address;


        public Person(string name, string address)  // constructor with 2 parameters
        {
            this.Name = name;
            this.Address = address;
            Console.WriteLine("*******DETAILS********");
            Name = name;
            Address = address;

            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Address : " + Address);

        }


    }

    class Doctor : Person
    {

        private string RegnNo;
        private int Feescharged;
        private string specialization;

        public Doctor(string name, string address, string regnNo, int feescharged, string Specialization) :
            base(name, address)
        {

            RegnNo = regnNo;
            Feescharged = feescharged;
            specialization = Specialization;

            Console.WriteLine("RegnNo :" + RegnNo);
            Console.WriteLine("FessCharged: " + Feescharged);
            Console.WriteLine("Specialization : " + specialization);



        }




    }


}
