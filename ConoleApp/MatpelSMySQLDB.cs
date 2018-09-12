using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConoleApp
{
    class MatpelSMySQLDB
    {
        public DataTable Getall()
        {
            string query = "SELECT kd_matpel,nama_matpel FROM matpel";
            MySQLDB db = new MySQLDB();
            return db.GetData(query);
        }

        public MatpelMdl GetByKd_Matpel(string kd_matpel)
        {
            MatpelMdl data = null;
            string query = "SELECT kd_matpel,nama_matpel FROM matpel WHERE kd_matpel=@kreteria";
            MySQLDB db = new MySQLDB();
            DataTable dtmatpel = db.GetData(query, new Dictionary<string, dynamic>()
            {
                {"@kreteria",kd_matpel}
            });
            if (dtmatpel.Rows.Count == 1)
            {
                DataRow row = dtmatpel.Rows[0];
                data = new MatpelMdl();
                data.kd_matpel = row["kd_matpel"].ToString();
                data.nama_matpel = row["nama_matpel"].ToString();
            }
            return data;
        }

        public DataTable GetByNama_Matpel(string nama_matpel)
        {
            string query = "SELECT kd_matpel,nama_matpel FROM matpel WHERE kd_matpel LIKE @kreteria";
            MySQLDB db = new MySQLDB();
            return db.GetData(query, new Dictionary<string, dynamic>()
            {
                {"@kreteria", "%" + nama_matpel + "%"}
            });
        }
        public void Add(MatpelMdl data)
        {
            string query = "INSERT INTO matpel (kd_matpel,nama_matpel) VALUES (@kd_matpel,@nama_matpel)";
            MySQLDB db = new MySQLDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@kd_matpel",data.kd_matpel},
                {"@nama_matpel",data.nama_matpel}
            });
        }

        public void Edit(string kd_matpel, MatpelMdl data)
        {
            string query = "UPDATE matpel SET kd_matpel=@kd_matpelbaru,nama_matpel=@nama_matpelbaru WHERE kd_matpel=@kd_matpellama";
            MySQLDB db = new MySQLDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@kd_matpelbaru",data.kd_matpel},
                {"@nama_matpelbaru",data.nama_matpel},
                {"@kd_matpellama",kd_matpel}
            });

        }

        public void Hapus(string kd_matpel)
        {
            string query = "DELETE FROM kd_matpel WHERE kd_matpel=@kreteria";
            MySQLDB db = new MySQLDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@kreteria",kd_matpel}
            });
        }
    }
}
