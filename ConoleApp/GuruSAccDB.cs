using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ConoleApp
{
    class GuruSAccDB
    {
        //--------------->untuk Access

        public DataTable GetAll()
        {
            string query = "SELECT nip,nama,jabatan FROM guru";
            AccessDB db = new AccessDB();
            return db.GetData(query);
        }

        public GuruMdl GetBynip(string nip)
        {
            GuruMdl data = null;
            string query = "SELECT nip,nama,jabatan FROM guru WHERE nip=@kreteria";
            AccessDB db = new AccessDB();
            DataTable dtguru = db.GetData(query, new Dictionary<string, dynamic>() 
            { 
                { "@kriteria", nip }
            });
            if (dtguru.Rows.Count == 1)
            {
                DataRow row = dtguru.Rows[0];
                data = new GuruMdl();
                data.nip = row["nip"].ToString();
                data.nama = row["nama"].ToString();
                data.jabatan = row["jabatan"].ToString();
            }
            return data;
        }

        public DataTable GetByName(string nama)
        {
            string query = "SELECT nip,nama,jabatan FROM guru WHERE nama LIKE @kreteria";
            AccessDB db = new AccessDB();
            return db.GetData(query, new Dictionary<string, dynamic>()
            { 
                { "@kreteria", "%" + nama + "%" } 
            });
        }

        public void Add(GuruMdl data)
        {
            string query = "INSERT INTO guru (nip,nama,jabatan) VALUES (@nip,@nama,@jabatan)";
            AccessDB db = new AccessDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@nip",data.nip},
                {"@nama",data.nama},
                {"@jabatan",data.jabatan}
            });
        }

        public void Edit(string nip, GuruMdl data)
        {
            string query = "UPDATE guru SET nip=@nipbaru,nama=@namabaru,jabatan=@jabatanbaru WHERE nip=@niplama";
            AccessDB db = new AccessDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@nipbaru",data.nip},
                {"@namabaru",data.nama},
                {"@jabatanbaru",data.jabatan},
                {"@niplama",nip}
            });

        }

        public void Hapus(string nip)
        {
            string query = "DELETE FROM guru WHERE nip=@kreteria";
            AccessDB db = new AccessDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@kreteria",nip}
            });
        }
    }
}
