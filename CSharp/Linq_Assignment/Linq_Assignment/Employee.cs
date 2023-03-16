using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string city { get; set; }




        public static List<Employee> GetEmployeeData()
        {
            List<Employee> employees = new List<Employee>()
            {
                (new Employee{EmployeeId =1001,FirstName ="Malcolm",LastName = "Daruwalla" ,Title="Manager",DOB=Convert.ToDateTime("16/11/1984"),DOJ=Convert.ToDateTime("08/06/2011"),city ="Mumbai"}),
                (new Employee{EmployeeId =1002,FirstName ="Asdin",LastName = "Dhalla" ,Title="AsstManager",DOB=Convert.ToDateTime("20/08/1984"),DOJ=Convert.ToDateTime("07/07/2012"),city ="Mumbai"}),
                (new Employee{EmployeeId =1003,FirstName ="Madhavi",LastName = "Oza" ,Title="Consultant",DOB=Convert.ToDateTime("14/11/1987"),DOJ=Convert.ToDateTime("12/04/2015"),city ="Pune"}),
                (new Employee{EmployeeId =1004,FirstName ="Saba",LastName = "Shaikh" ,Title="SE",DOB=Convert.ToDateTime("3/6/1990"),DOJ=Convert.ToDateTime("2/2/2016"),city ="Pune"}),
                (new Employee{EmployeeId =1005,FirstName =" Nazia",LastName = "Shaikh" ,Title="SE",DOB=Convert.ToDateTime("08/03/1991"),DOJ=Convert.ToDateTime("02/06/2006"),city ="Mumbai"}),
                (new Employee{EmployeeId =1006,FirstName ="Amit",LastName = "Pathak" ,Title="Consultant",DOB=Convert.ToDateTime("07/11/1989"),DOJ=Convert.ToDateTime("08/08/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1007,FirstName =" Vijay",LastName = "Natrajan" ,Title="SE",DOB=Convert.ToDateTime("02/12/1989"),DOJ=Convert.ToDateTime("01/06/2015"),city ="Mumbai"}),
                (new Employee{EmployeeId =1008,FirstName =" Rahul",LastName = "Dubey" ,Title="Associate",DOB=Convert.ToDateTime("11/11/1993") ,DOJ=Convert.ToDateTime("06/11/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1009,FirstName =" Suresh",LastName = "Mistry" ,Title="Associate",DOB=Convert.ToDateTime("12/08/1992"),DOJ=Convert.ToDateTime("03/12/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1010,FirstName =" Sumit",LastName = "Shah" ,Title="Manager",DOB=Convert.ToDateTime("12/04/1991"),DOJ=Convert.ToDateTime("02/01/2016"),city ="Pune"}),

            };
            return employees;
        }
    }
}
