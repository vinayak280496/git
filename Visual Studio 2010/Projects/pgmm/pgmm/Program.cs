using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace pgmm
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=Items; user ID=sa; Password=Password@123";
            string querystring = "Select * from items";

            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
        }
    }
}
