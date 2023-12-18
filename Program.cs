using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssesment8_P1
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=NAVEEN-BOOK-8C9;database=Assesment8;trusted_connection=true";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select top 5 * from Products order by PName DESC"
                };
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("PId \t\tProduct Name \tProduct Price \t Mnf Date\t\t\t Exp Date");
                while (reader.Read())
                {
                    Console.Write(reader[0] + "\t\t");
                    Console.Write(reader[1] + "\t\t ");
                    Console.Write(reader[2] + "\t\t ");
                    Console.Write(reader[3] + "\t\t ");
                    Console.Write(reader[4]);
                    Console.Write("\n");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }


        }
    }
}
