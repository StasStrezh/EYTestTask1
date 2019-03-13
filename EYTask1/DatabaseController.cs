using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EYTask1
{
    public delegate void setText(string str);
    public delegate void setProgressValue(int am);


    class DatabaseController
    {
        public static Thread thread;
        public string connectionString = "Data Source=HOMENOTEBOOK\\SQLEXPRESS;Initial Catalog=TaskDB;Integrated Security=True";


        /// <summary>
        /// Constructor, where we create table and procedures
        /// </summary>
        public DatabaseController()
        {
            thread = new Thread(Insert);
            thread.IsBackground = true;
            //Connection to create a table and procedures
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            try
            {
                //Creating
                thisConnection.Open();
                nonqueryCommand.CommandText = "IF OBJECT_ID('dbo.FileLine', 'U') IS NOT NULL DROP TABLE dbo.FileLine";
                nonqueryCommand.ExecuteNonQuery();

                nonqueryCommand.CommandText = "CREATE TABLE FileLine(ID INT IDENTITY(1, 1) NOT NULL, RDate DATE NULL, Eng NCHAR(10) NULL, Rus NCHAR(10) NULL, IntNum INT NULL, DoubleNum FLOAT(53) NULL, primary key (ID))";
                nonqueryCommand.ExecuteNonQuery();

                nonqueryCommand.CommandText = "CREATE PROCEDURE dbo.CountSum AS SELECT SUM(CAST(IntNum AS BIGINT)) AS SumOfInt FROM FileLine";
                nonqueryCommand.ExecuteNonQuery();

                nonqueryCommand.CommandText = "CREATE PROCEDURE dbo.CountMedian AS SELECT MAX(d.DoubleNum) AS DoubleMedian FROM (SELECT TOP 50 PERCENT DoubleNum FROM FileLine ORDER BY DoubleNum) d";
                nonqueryCommand.ExecuteNonQuery();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
            finally
            {
                thisConnection.Close();
            }
        }

        public static event setProgressValue SetProgressValueEvent;
        public static void SetProgress(int ammount)
        {
            if (SetProgressValueEvent != null)
                SetProgressValueEvent(ammount);
        }


        /// <summary>
        /// Inserting lines in database
        /// </summary>
        public void Insert()
        {
            SqlConnection thisConnection = new SqlConnection(connectionString);
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();

            try
            {
                thisConnection.Open();

                nonqueryCommand.CommandText = "INSERT INTO FileLine VALUES (@date, @eng, @rus, @intNum, @doubleNum)";

                nonqueryCommand.Parameters.AddWithValue("@date", "1");
                nonqueryCommand.Parameters.AddWithValue("@eng", "2");
                nonqueryCommand.Parameters.AddWithValue("@rus", "3");
                nonqueryCommand.Parameters.AddWithValue("@intNum", "4");
                nonqueryCommand.Parameters.AddWithValue("@doubleNum", "5");

                int ammountOfLines = System.IO.File.ReadAllLines("all.txt").Length;
                int count = 0;
                SetProgress(ammountOfLines);
                using (StreamReader reader = File.OpenText("all.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] items = line.Split(new char[] { '|', '|' });
                        if (items.Length == 9)
                        {

                            nonqueryCommand.Parameters["@date"].Value = DateTime.Parse(items[0]);
                            nonqueryCommand.Parameters["@eng"].Value = items[2];
                            nonqueryCommand.Parameters["@rus"].Value = items[4];
                            nonqueryCommand.Parameters["@intNum"].Value = Int32.Parse(items[6]);
                            nonqueryCommand.Parameters["@doubleNum"].Value = Double.Parse(items[8]);
                            nonqueryCommand.ExecuteNonQuery();
                            count++;
                        }
                        Print(count, ammountOfLines - count);
                    }
                }

            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
            finally
            {
                thisConnection.Close();
            }
        }


        /// <summary>
        /// Provide numbers of inserted lines and left ones
        /// </summary>
        public static event setText SetTextEvent;
        public static void Print(int done, int left)
        {
            String text = "Inserted lines: " + done + " ; " + "Left lines: " + left + ". ";
            if (left == 0) text = "Finished";
            if (SetTextEvent != null)
                SetTextEvent(text);
        }


        public void Run()
        {
            thread.Start();
        }
        public void Stop()
        {
            thread.Abort();
        }
        public bool isAlive()
        {
            if (thread.IsAlive)
                return true;
            else return false;
        }
    }
}
