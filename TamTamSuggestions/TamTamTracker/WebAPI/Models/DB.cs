using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public static class DB {
        private static MySqlConnection MyConnection;
        private static MySqlDataReader MyReader;


        // Requirements : Install-Package MySql.Data
        // MySql driver for visual studio https://dev.mysql.com/downloads/file/?id=476476
        public static void OpenCon() {

            MySqlConnection MyConnection = null;
            MyConnection = new MySqlConnection("Server=(local);DataBase=suggestions;Integrated Security=SSPI");
            MyConnection.Open();

        }
        public static void CloseCon()
        {
            MyConnection.Close();
        }
        public static List<T> Query<T>(string query)
        {
           
            MySqlDataReader MyReader = null;
            MySqlCommand MyCommand = new MySqlCommand(query, MyConnection);

            List<T> results = new List<T>();
            MyReader = MyCommand.ExecuteReader();
            // ...
            MyReader.Close();
            return results;

        }
    }
}