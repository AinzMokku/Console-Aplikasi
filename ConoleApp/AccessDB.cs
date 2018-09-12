using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ConoleApp
{
    class AccessDB
    {
        OleDbConnection koneksi;

        public AccessDB()
        {
            string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb;";
            koneksi = new OleDbConnection(koneksistring);
            koneksi.Open();

        }

        public void Execute(string query, Dictionary<string, dynamic> data = null)
        {
            OleDbCommand cmd = new OleDbCommand(query,koneksi);
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
            OleDbCommand cmd = new OleDbCommand(query, koneksi);
            if (data != null)
            {
                foreach (string key in data.Keys)
                {
                    cmd.Parameters.AddWithValue(key, data[key]);
                }
            }
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable result = new DataTable();
            result.Load(reader);

            return result;
            
        }

        //~AccessDB()
        //{
        //    koneksi.Close();
        //}
    }
}
