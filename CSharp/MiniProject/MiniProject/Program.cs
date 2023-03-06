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
             //SelectData(); 
            // InsertData();
           // DeleteData();
            //UpdateData();

            Console.Read();
        }
        #region


        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=localhost\\SQLEXPRESS ;Initial Catalog=employee;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }

        public static void SelectData()
        {
            try
            {
                con = getConnection(); // gets the connection details after executing the getConnection method
                cmd = new SqlCommand("select * from emp", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Employee NO : {0}", dr[0]);
                    Console.WriteLine("Employee Name : {0}", dr[1]);
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

            Console.WriteLine("Enter Employee NO, NAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO");
            int EMPNO = Convert.ToInt32(Console.ReadLine());
            string ENAME = Console.ReadLine();
            string JOB = Console.ReadLine();
            decimal MGR = Convert.ToDecimal(Console.ReadLine());
            DateTime HIREDATE = Convert.ToDateTime(Console.ReadLine());
            decimal SAL = Convert.ToDecimal(Console.ReadLine());
            decimal COMM = Convert.ToDecimal(Console.ReadLine());
            decimal DEPTNO = Convert.ToDecimal(Console.ReadLine());
            cmd = new SqlCommand("insert into emp values(@eno,@empname,@ejob,@emgr,@ehiredate,@esal,@ecomm,@edeptno)", con);
            cmd.Parameters.AddWithValue("@eno", EMPNO);
            cmd.Parameters.AddWithValue("@empname", ENAME);
            cmd.Parameters.AddWithValue("@ejob", JOB);
            cmd.Parameters.AddWithValue("@emgr", MGR);
            cmd.Parameters.AddWithValue("@ehiredate", HIREDATE);
            cmd.Parameters.AddWithValue("@esal", SAL);
            cmd.Parameters.AddWithValue("@ecomm", COMM);
            cmd.Parameters.AddWithValue("@edeptno", DEPTNO);

            int rows = cmd.ExecuteNonQuery();
            if(rows>0)
            {
                 Console.WriteLine("Record Inserted Successfully.");
            }
             else
                 Console.WriteLine("Not Inserted..");
        }

        public static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee NO :");
            int empno = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from emp where empno = @eid");
            cmd1.Parameters.AddWithValue("@eid", empno);
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
            Console.WriteLine("Are you sure you want to delete this employee ? Y/N");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "Y")
            {
                cmd = new SqlCommand("delete from emp where empno = @eid", con);
                cmd.Parameters.AddWithValue("@eid", empno);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Deleted..");
                else
                    Console.WriteLine("Not Deleted..");

            }
            
        }
        #endregion

        public static void UpdateData()
        {
            con = getConnection();
            Console.WriteLine("Update Employee JOB");
            Console.WriteLine("Enter Employee NO : \n");
            int EMPNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Employee JOB :\n");
            string JOB = Console.ReadLine();

            SqlCommand cmd1 = new SqlCommand("Select * from emp where EMPNO = @eno");
            cmd1.Parameters.AddWithValue("@eno", EMPNO);
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

            Console.WriteLine("Are you sure you want to update this employee ? Y/N");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                cmd = new SqlCommand("update  emp set JOB = @ejob where empno = @empno", con);
                cmd.Parameters.AddWithValue("@empno", EMPNO);
                cmd.Parameters.AddWithValue("@ejob", JOB);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                {
                    Console.WriteLine("Record Updated..");
                    Console.WriteLine("*********************************");
                    Console.WriteLine("New Employee JOB:" + JOB);
                }

                else
                    Console.WriteLine("Not Updated..");


            }
        }
    }
}