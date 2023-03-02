using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Saledetails
    {
        int SalesNo;
        int ProductNo;
        int Price;
        DateTime dateofsale;
        int Qty;
        private double TotalAmount;

        public void Sales()
        {
            unsafe
            {
                Price = 150;
                Qty = 2;
                fixed (int* ptr1 = &Price) ;
                fixed (int* ptr2 = &Qty) ;
                TotalAmount = Qty * Price;
            
            }
        }

        public Saledetails(int salesno, int productno, int qnty, int price, DateTime dateOFsale) //constructor
        {
            SalesNo = salesno;
            ProductNo = productno;
            Qty = qnty;
            Price = price;
            dateofsale = dateOFsale;

        }

        public void Showdata()
        {
            Console.WriteLine("*********INVOICE**********");
            Console.WriteLine("Salesno: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Qty : " + Qty);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Date of Sale : " + dateofsale);
            Console.WriteLine("Total Amount " + Qty + Price + " = " + TotalAmount);
        }
    }
}
