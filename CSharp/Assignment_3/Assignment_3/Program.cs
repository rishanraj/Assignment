using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {

        static void Main(string[] args)
        {

            // CountLetters cs = new CountLetters();
            Student s = new Student();
            s.studentDetails();
            s.GetMarks();
            s.DisplayResult();
            s.GetDetails();
            //cs.MyName();
            //cs.GetString();


            Console.Read();
        }



    }

}