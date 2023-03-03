using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public abstract class Student
    {
        public string Name;
        public int Stud_Id;
        public int Stud_Grade;
        public abstract bool Ispassed(double Grade);
    }

    class UnderGraduate : Student
    {
        public override bool Ispassed(double Grade)
        {
            if (Grade  > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(double Grade)
        {
            if (Grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Student1
    {
        static void Main(string[] args)
        {
            UnderGraduate ug = new UnderGraduate();

            Console.WriteLine("__________UnderGraduate__________");
            Console.WriteLine("Enter the UG Student Name: ");
            ug.Name = Console.ReadLine();

            Console.WriteLine("Enter the Student ID :");
            ug.Stud_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Grade :");
            ug.Stud_Grade = Convert.ToInt32(Console.ReadLine());

            bool status = ug.Ispassed(ug.Stud_Grade);
            Console.WriteLine("status for {0} with ID {1}: {2}", ug.Name, ug.Stud_Id, ug.Stud_Grade);

            Graduate g = new Graduate();

            Console.WriteLine("__________Graduate_________");
            Console.Write("Enter the UG Student Name: ");
            g.Name = Console.ReadLine();

            Console.WriteLine("Enter the Student ID :");
            g.Stud_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Grade :");
            g.Stud_Grade = Convert.ToInt32(Console.ReadLine());

            status = g.Ispassed(g.Stud_Grade);
            Console.WriteLine("Status for {0} with ID {1}:{2}", g.Name, g.Stud_Id, g.Stud_Grade);

            Console.ReadLine();
        }
    }
}
