using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginAppMVC.Models
{
    public class LoginConnect
    {
        private readonly string ConnectionString = "Server=localhost;Database=ismetsdb;User ID=root;Password=Pridvorci99;Pooling=false;SslMode=none;convert zero datetime=True;";


        public DataTable GetAllUsers() {
            MySqlConnection dbcon = new MySqlConnection(ConnectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable userTable = ds.Tables["result"];
            dbcon.Close();

            return userTable;

        }
    }
}
