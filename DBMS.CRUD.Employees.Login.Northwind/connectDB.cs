using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.CRUD.Employees.Login.Northwind
{
    internal class connectDB
    {
        public static SqlConnection ConnectNorthwind()
        {
            string server = @"ADM403-32\SQLEXPRESS";
            string db = "Northwind";
            string strCon = string.Format(@"Data Source={0}; Initial Catalog={1};"
                      + "Integrated Security=True;Encrypt=False", server, db);
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;
        }

        internal SqlConnection ConnectNortwind()
        {
            throw new NotImplementedException();
        }
    }
}
