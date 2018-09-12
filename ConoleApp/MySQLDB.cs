using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace ConoleApp
{
    class MySQLDB
    {
        MySqlConnection koneksi;

        public MySQLDB()
        {
            string koneksistring = "Server=127.0.0.1;User=root;Password=;Databese=dbsekolah";
            koneksi = new MySqlConnection(koneksistring);
            koneksi.Open();
        }

        public void Execute(string query, Dictionary<string, dynamic> data = null)
        {
            MySqlCommand cmd = new MySqlCommand(query, koneksi);
            if (data != null)
            {
                foreach (string key in data.Keys)
                {
                    cmd.Parameters.AddWithValue(key, data[key]);
                }
            }
            cmd.ExecuteNonQuery();
        }

        public DataTable GetData(string query, Dictionary<string, dynamic> data = null)
        {
            MySqlCommand cmd = new MySqlCommand(query, koneksi);
            if (data != null)
            {
                foreach (string key in data.Keys)
                {
                    cmd.Parameters.AddWithValue(key, data[key]);
                }
            }
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable result = new DataTable();
            result.Load(reader);

            return result;
        }
        //~MySQLDB()
        //{
        //    koneksi.Close();
        //}
    }
}
