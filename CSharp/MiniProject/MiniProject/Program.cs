using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {

            Console.WriteLine("Employee Management System: ");
            Console.WriteLine("\r\nType: ADMIN = 1 ,USER = 2 ");
            int role = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose required operation");
            if (role == 1)
                Console.WriteLine("ADMIN \n1:DISPLAY \n2:INSERT \n3:UPDATE \n4:DELETE");
            else
                Console.WriteLine("USER \n1:DISPLAY \n2:UPDATE PROFILES ");
            int operation = Convert.ToInt32(Console.ReadLine());


            switch (role)

            {

                case 1:

                    switch (operation)

                    {

                        case 1:
                            DisplayEmp();


                            break;

                        case 2:

                            InsertData();

                            break;


                        case 3:

                            UpdateData();

                            break;

                        case 4:
                            DeleteData();

                            break;

                    }

                    break;



                case 2:

                    switch (operation)

                    {

                        case 1:

                            DisplayEmp();
                            break;

                        case 2:

                            UpdateProfiles();

                            break;

                    }

                    break;



                default:

                    Console.WriteLine("Invalid Role/Usertype");

                    break;

            }

            Console.ReadLine();





        }
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=localhost\\SQLEXPRESS ;Initial Catalog=employee;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }

        public static void DisplayEmp()
        {
            try
            {
                con = getConnection(); // gets the connection details after executing  getConnection method
                cmd = new SqlCommand("select * from emp", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Employee NO : {0}", dr[0]);
                    Console.WriteLine("Employee NAME : {0}", dr[1]);
                    Console.WriteLine("Employee JOB : {0}", dr[2]);
                    Console.WriteLine("Employee MGR : {0}", dr[3]);
                    Console.WriteLine("Employee HIREDATE : {0}", dr[4]);
                    Console.WriteLine("Employee SAL : {0}", dr[5]);
                    Console.WriteLine("Employee COMM : {0}", dr[6]);
                    Console.WriteLine("Employee DEPTNO : {0}", dr[7]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some Error Occured.. Try after sometime");
                Console.WriteLine(se.Message);
            }

        }
        public static void InsertData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee NO:");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee NAME:");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee JOB:");
            string empjob = Console.ReadLine();
            Console.WriteLine("Enter Employee MGR:");
            int empmgr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee HIREDATE:");
            string emphiredate = Console.ReadLine();
            Console.WriteLine("Enter Employee SAL:");
            int empsal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee COMM:");
            float empcomm = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Employee DEPTNO:");
            int empdeptno = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("insert into Employee values(@eno,@ename,@ejob,@emgr,@ehiredate,@esal,@ecomm,@edeptno)", con);
            cmd.Parameters.AddWithValue("@eno", empno);
            cmd.Parameters.AddWithValue("@ename", empname);
            cmd.Parameters.AddWithValue("@ejob", empjob);
            cmd.Parameters.AddWithValue("@emgr", empmgr);
            cmd.Parameters.AddWithValue("@ehiredate", emphiredate);
            cmd.Parameters.AddWithValue("@esal", empsal);
            cmd.Parameters.AddWithValue("@ecomm", empcomm);
            cmd.Parameters.AddWithValue("edeptno", empdeptno);

            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                Console.WriteLine("Record inserted..");
            else
                Console.WriteLine("not inserted");
        }


        public static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee NO :");
            int empno = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from emp where empno=@empno");
            cmd1.Parameters.AddWithValue("@empno", empno);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to delete this employee ? Y/N");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                cmd = new SqlCommand("delete from emp where empno=@empno", con);
                cmd.Parameters.AddWithValue("@ecode", empno);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Deleted..");
                else
                    Console.WriteLine("Not deleted");
            }

        }

        public static void UpdateData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee NO :");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee New DEPTNO :");
            int empdeptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee New SAL :");
            float empsal = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from emp where empno=@eno");
            cmd1.Parameters.AddWithValue("@eno", empno);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to updates the records ?  Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                cmd = new SqlCommand("update employee set deptID = @empdno,empsal = @empsal  where empid=@empcode", con);
                cmd.Parameters.AddWithValue("@eno", empno);
                cmd.Parameters.AddWithValue("@edeptno", empdeptno);
                cmd.Parameters.AddWithValue("@esal", empsal);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Updated..");
                else
                    Console.WriteLine("Not updated");
            }

        }
        public static void UpdateProfiles()
        {
            con = getConnection();
            Console.WriteLine("Enter  Your Employee NO :");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee JOB:");
            string empjob = Console.ReadLine();
            SqlCommand cmd1 = new SqlCommand("Select * from emp where empno=@eno");
            cmd1.Parameters.AddWithValue("@eno", empno);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to updates the records ?  Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                cmd = new SqlCommand("update emp set job = @empjob  where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", empno);
                cmd.Parameters.AddWithValue("@ejob", empjob);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Updated..");
                else
                    Console.WriteLine("Not updated");
            }

        }
    }
}
