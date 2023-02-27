using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class CountLetters
    {
        public void GetString()
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letter = char.Parse(Console.ReadLine());

            int count = LetterOccurrences(input, letter);

            Console.WriteLine($"The letter {letter} appears {count} times in the string '{input}'.");
            Console.Read();


        }
        static int LetterOccurrences(string input, char letter)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }


        public void MyName()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("*******After Convert to Lower Case******* \n");
            Display(firstName, lastName);
            Console.Read();

        }
        static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
            Console.Read();
        }

    }



    class Student
    {
        private int rollno;
        private string name;
        private string className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollno, string name, string className, int semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        public Student()
        {

        }
        public void studentDetails()
        {
            Console.WriteLine("Roll No:");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name:");
            name = Console.ReadLine();
            Console.WriteLine($"Class:");
            className = Console.ReadLine();
            Console.WriteLine($"Semester: ");
            semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Branch: ");
            branch = Console.ReadLine();


        }

        public void GetDetails()
        {
            Console.WriteLine("Roll No:" + rollno);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");

        }
        public void GetMarks()
        {
            Console.WriteLine($"Enter the marks for {name}:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }

        public void DisplayResult()
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed");
                    return;
                }
            }

            double average = sum / (double)marks.Length;

            if (average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }


    }

}