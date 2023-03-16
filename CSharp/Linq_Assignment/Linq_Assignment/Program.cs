using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AllEmployee();
            //NotMumbai();
            // Asstmanger();
            //LastName();
            // DOJbefore();
            // DOBafter();
            //consultantNassoc();
            // TotalEmp();
            //TotalEmpChennai();
            // MaxID();
            //TotalAfter();
            //TotalNotAssoc();
            //TotalBasedonCity();
            //TotalBasedonCityNtitle();
            //youngest();

            Console.Read();
        }

        static void AllEmployee()
        {


            Console.WriteLine("-----ALL EMPLOYEE--");

            IEnumerable<Employee> emps = from emp in Employee.GetEmployeeData()
                                         select emp;


            //Display the details of all Empoyees
            foreach (Employee e in emps)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e.EmployeeId + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.city);
            }
            Console.Read();
        }

        static void NotMumbai()
        {
            Console.WriteLine("-----EMPLOYEE WHICH CITY IS NOT MUMBAI-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.city != "Mumbai"
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();
        }
        static void Asstmanger()
        {
            Console.WriteLine("-----EMPLOYEE WHICH TITLE IS ASSGMANAGER-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.Title.Equals("AsstManager")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void LastName()
        {
            Console.WriteLine("-----EMPLOYEE LASTNAME START WITH S-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.LastName.StartsWith("S")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void DOJbefore()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DOJ BEFORE 01/01/2015-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.DOJ < Convert.ToDateTime("01/01/2015")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void DOBafter()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DOB AFTER 01/01/1990-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.DOB > Convert.ToDateTime("01/01/1990")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void consultantNassoc()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DESIGNATION IS CONSULTANT AND ASSOCIATE -------- ");
            //Employee e1 = Employee.GetEmployeeData().Find(emp => (emp.Title == "Associate"));
            Employee e1 = Employee.GetEmployeeData().Find(emp => (emp.Title == "Consultant"));

            Console.Read();

        }
        static void TotalEmp()
        {

            Console.WriteLine("-----TOTAL EMPLOYEE-------- ");

            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmp = (from e1 in Employee.GetEmployeeData()
                            select e1).Count();

            Console.WriteLine("Total No of Employees = " + TotalEmp);
            Console.Read();
        }
        static void TotalEmpChennai()
        {

            Console.WriteLine("-----TOTAL EMPLOYEE FOR CHENNAI-------- ");

            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmp = (from e1 in Employee.GetEmployeeData()
                            where e1.city == "Chennai"
                            select e1).Count();

            Console.WriteLine("Total No of Employees = " + TotalEmp);
            Console.Read();
        }
        static void MaxID()
        {

            Console.WriteLine("----- Highest Employee ID from the List-------- ");

            var emp = Employee.GetEmployeeData().Max(e => e.EmployeeId);
            //Using Query Syntax
            var MaxId = (from e1 in Employee.GetEmployeeData()
                         select e1).Max(e => e.EmployeeId);

            Console.WriteLine(" Highest Employee ID : " + MaxId);
            Console.Read();
        }

        static void TotalAfter()
        {



            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmpafter = (from e1 in Employee.GetEmployeeData()
                                 where e1.DOJ > Convert.ToDateTime("01/01/2015")
                                 select e1).Count();

            Console.WriteLine("Total No of Employees  Who join After 01/01/2015: " + TotalEmpafter);
            Console.Read();

        }



        static void TotalNotAssoc()
        {



            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmpafter = (from e1 in Employee.GetEmployeeData()
                                 where e1.Title != "Associate"
                                 select e1).Count();

            Console.WriteLine("Total No of Employees whose designation is not An Associate: " + TotalEmpafter);
            Console.Read();

        }
        static void TotalBasedonCity()
        {


            var GroupByQS = from std in Employee.GetEmployeeData()
                                //First store the data into a group
                            group std by std.city into stdGroup
                            //Then Sorting the data based on key in Descending Order
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Employees = stdGroup.OrderBy(x => x.FirstName)
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Employees.Count());

                foreach (var emp in group.Employees)
                {
                    // Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
                    Console.WriteLine("ID" + emp.EmployeeId + ",  FirstName :" + emp.FirstName + ", Lastname: " + emp.LastName + ", Designation :" + emp.Title + ", DOB :" + emp.DOB + ",  DOJ:" + emp.DOJ + ",City:" + emp.city);
                }
            }



            Console.Read();

        }

        static void TotalBasedonCityNtitle()
        {

            Console.WriteLine("-----------------Total Number of Employees based on City And title----------------");
            var GroupBy = from emp in Employee.GetEmployeeData()
                              //First store the data into a group
                          group emp by new
                          {
                              emp.city,
                              emp.Title

                          } into empGrp
                          select new
                          {
                              City = empGrp.Key.city,
                              Title = empGrp.Key.Title,



                              Employees = empGrp.OrderBy(x => x.FirstName)
                          };

            //Then Sorting the data based on key in Descending Order

            //It will iterate through each groups
            foreach (var group in GroupBy)
            {
                Console.WriteLine($"City: {group.City} ,Title : {group.Title} ,No of Employee : {group.Employees.Count()} ");

                foreach (var emp in group.Employees)
                {
                    // Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
                    Console.WriteLine("ID" + emp.EmployeeId + ",  FirstName :" + emp.FirstName + ", Lastname: " + emp.LastName + ", Designation :" + emp.Title + ", DOB :" + emp.DOB + ",  DOJ:" + emp.DOJ + ",City:" + emp.city);
                }
            }



            Console.Read();

        }

        static void youngest()
        {

            Console.WriteLine("----- Youngest Employee from the List-------- ");

            var emp = Employee.GetEmployeeData().Max(e => e.DOB);
            //Using Query Syntax
            var maxyear = (from e1 in Employee.GetEmployeeData()
                           select e1).Max(e => e.DOB);

            Console.WriteLine(" Youngest Employee ID : " + maxyear);
            Console.Read();
        }



    }


}

