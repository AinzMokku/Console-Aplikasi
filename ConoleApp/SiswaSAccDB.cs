using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ConoleApp
{
    class SiswaSAccDB
    {
        //--------------->untuk Access

        public DataTable GetAll()
        {
            string query = "SELECT nis,nama,kelas FROM siswa";
            AccessDB db = new AccessDB();
            return db.GetData(query);
        }

        public SiswaMdl GetByNis(string nis)
        {
            SiswaMdl data = null;
            string query = "SELECT nis,nama,kelas FROM siswa WHERE nis=@kreteria";
            AccessDB db = new AccessDB();
            DataTable dtsiswa = db.GetData(query, new Dictionary<string, dynamic>() 
            { 
                { "@kriteria", nis }
            });
            if (dtsiswa.Rows.Count == 1)
            {
                DataRow row = dtsiswa.Rows[0];
                data = new SiswaMdl();
                data.nis = row["nis"].ToString();
                data.nama = row["nama"].ToString();
                data.kelas = row["kelas"].ToString();
            }
            return data;
        }

        public DataTable GetByName(string nama)
        {
            string query = "SELECT nis,nama,kelas FROM siswa WHERE nama LIKE @kreteria";
            AccessDB db = new AccessDB();
            return db.GetData(query, new Dictionary<string, dynamic>()
            { 
                { "@kreteria", "%" + nama + "%" } 
            });
        }

        public void Add(SiswaMdl data)
        {
            string query = "INSERT INTO siswa (nis,nama,kelas) VALUES (@nis,@nama,@kelas)";
            AccessDB db = new AccessDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@nis",data.nis},
                {"@nama",data.nama},
                {"@kelas",data.kelas}
            });
        }

        public void Edit(string nis, SiswaMdl data)
        {
            string query = "UPDATE siswa SET nis=@nisbaru,nama=@namabaru,kelas=@kelasbaru WHERE nis=@nislama";
            AccessDB db = new AccessDB();
            db.Execute(query,new Dictionary<string,dynamic>()
            {
                {"@nisbaru",data.nis},
                {"@namabaru",data.nama},
                {"@kelasbaru",data.kelas},
                {"@nislama",nis}
            });

        }

        public void Hapus(string nis)
        {
            string query = "DELETE FROM siswa WHERE nis=@kreteria";
            AccessDB db = new AccessDB();
            db.Execute(query, new Dictionary<string, dynamic>()
            {
                {"@kreteria",nis}
            });
        }
    }
}
