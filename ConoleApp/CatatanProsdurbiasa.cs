using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class CatatanProsdurbiasa
    {
        static void main(string args)
        {
            //----------->PROSEDURE

            //MyPro.tuliswarna(44, 7, "-- Masukkan Data Siswa --", ConsoleColor.Black, ConsoleColor.DarkYellow);
            //MyPro.tulis(44, 8, "NIS      : ");
            //string nis = Console.ReadLine();
            //MyPro.tulis(44, 9, "NAMA     : ");
            //string nama = Console.ReadLine();
            //MyPro.tulis(44, 10, "KELAS    : ");
            //string kelas = Console.ReadLine();

            //MyPro.tulis(44, 11, "Apakah Menyimpan Data Siswa ? [Y/N] : ");
            //string dtsiswa = Console.ReadLine();

            //if (dtsiswa.ToUpper() == "Y")
            //{
            //    string query1 = "INSERT INTO siswa (nis,nama,kelas) VALUES (@nis,@nama,@kelas)";
            //    string koneksi1string = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb;";
            //    OleDbConnection koneksi1 = new OleDbConnection(koneksi1string);
            //    koneksi1.Open();
            //    OleDbCommand cmd1 = new OleDbCommand(query1, koneksi1);
            //    cmd1.Parameters.AddWithValue("nis", nis);
            //    cmd1.Parameters.AddWithValue("nama", nama);
            //    cmd1.Parameters.AddWithValue("kelas", kelas);
            //    cmd1.ExecuteNonQuery();
            //}

            //for (int a = 0; a < 5; a++)
            //{
            //    MyPro.tulis(44, 7 + a, "                                       ");
            //}


            //-------->PROCEDURE

            //MyPro.tuliswarna(44, 7, "// Tampil Data Siswa \\", ConsoleColor.DarkGreen, ConsoleColor.White);
            //MyPro.tuliswarna(44, 9, "Masukkan Nama Siswa / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
            //string cari = Console.ReadLine();

            //string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //koneksi.Open();

            //string query;
            //if (cari == "")
            //{
            //    query = "SELECT nis,nama,kelas FROM siswa";
            //}
            //else
            //{
            //    query = "SELECT nis,nama,kelas FROM siswa WHERE nama LIKE '%" + cari + "%'";
            //    //query = "SELECT nis,nama,kelas FROM siswa WHERE nama '" +cari+ "'";   ------> pencarian kata
            //};

            //OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //DataTable dtsiswa = new DataTable();
            //dtsiswa.Load(reader);

            //int baris = 0;
            //foreach (DataRow row in dtsiswa.Rows)
            //{
            //    MyPro.tulis(47, 14 + baris, row["nis"].ToString());
            //    MyPro.tulis(54, 14 + baris, row["nama"].ToString());
            //    MyPro.tulis(94, 14 + baris, row["kelas"].ToString());
            //    baris++;
            //    if (baris == 15)
            //    {

            //        Console.ReadKey();
            //        baris = 0;
            //        if (baris == 0)
            //        {
            //            for (int a = 0; a < 15; a++)
            //            {
            //                MyPro.tulis(47, 14 + a, "   ");
            //                MyPro.tulis(52, 14 + a, "                                ");
            //                MyPro.tulis(93, 14 + a, "     ");
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Data Not Found");
            //}

            //Console.ReadKey();
            //for (int a = 0; a < 23; a++)
            //{
            //    MyPro.tulis(44, 7 + a, "                                                                         ");
            //}

            //-------->PROCEDURE

            //MyPro.tuliswarna(44, 7, "_Edit Data Siswa_", ConsoleColor.Black, ConsoleColor.DarkGreen);
            //MyPro.tulis(44, 9, "Masukkkan Nis Yang Mau Dirubah : ");
            //string nislama = Console.ReadLine();

            //string query = "SELECT* FROM siswa WHERE nis=@nis";
            //string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //koneksi.Open();

            //OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //cmd.Parameters.AddWithValue("@nis", nislama);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //DataTable dtsiswa = new DataTable();
            //dtsiswa.Load(reader);

            //if(dtsiswa.Rows.Count == 1)
            //{
            //    DataRow row = dtsiswa.Rows[0];

            //    MyPro.tulis(44, 11, "Nis      : " + row["nis"]);
            //    MyPro.tulis(44, 12, "Nama     : " + row["nama"]);
            //    MyPro.tulis(44, 13, "Kelas    : " + row["kelas"]);

            //    MyPro.tulis(44, 15, "Nis Baru   : ");
            //    string nisbaru = Console.ReadLine();
            //    MyPro.tulis(44, 16, "Nama Baru  : ");
            //    string nama = Console.ReadLine();
            //    MyPro.tulis(44, 17, "Kelas Baru : ");
            //    string kelas = Console.ReadLine();

            //    MyPro.tulis(44, 19, "Update Data Siswa : [Y/N] ");
            //    string jawab = Console.ReadLine();

            //    if(jawab.ToUpper() == "Y")
            //    {
            //        query = "UPDATE siswa SET nis=@nisbaru,nama=@nama,kelas=@Kelas WHERE nis=@nis";
            //        cmd = new OleDbCommand(query, koneksi);

            //        cmd.Parameters.AddWithValue("@nisbaru", nisbaru);
            //        cmd.Parameters.AddWithValue("@nama", nama);
            //        cmd.Parameters.AddWithValue("@kelas", kelas);
            //        cmd.Parameters.AddWithValue("@nis", nisbaru);

            //        cmd.ExecuteNonQuery();
            //    }

            //    //try { }catch (OleDbException olex) { olex.Message -----> menampilkan pesan error } ----> untuk mengetes error dari oleDb
            //    //try { }catch (Exception) { }           ----> untuk mengetes error selain oleDb
            //}
            //if (dtsiswa.Rows.Count == 0)
            //{
            //    MyPro.tulis(44, 11, "Data Yang Anda Masukkan Salah....!!!!");
            //    Console.ReadLine();
            //    for (int a = 0; a < 5; a++)
            //    {
            //        MyPro.tulis(44, 7 + a, "                                                                         ");
            //    }
            //}



            //-------> PROCEDURE

            //MyPro.tuliswarna(44, 7, "+ Hapus Data Siswa +",ConsoleColor.Black,ConsoleColor.DarkGreen);
            //MyPro.tulis(44, 9, "Masukkan Nis Yang Mau Dihapus : ");
            //string nis = Console.ReadLine();

            //MyPro.tulis(44, 11, "Anda Yakin Data Siswa Ini ? [Y/N] ");
            //string jawab = Console.ReadLine();

            //if (jawab.ToUpper() == "Y")
            //{
            //    string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //    OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //    koneksi.Open();

            //    string query = "DELETE FROM siswa WHERE nis=@nis";
            //    OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //    cmd.Parameters.AddWithValue("@nis", nis);
            //    cmd.ExecuteNonQuery();
            //}
                                       
            //--------------->PROCEDURE

            //MyPro.tuliswarna(44, 7, "-- Masukkan Data Guru --", ConsoleColor.Black, ConsoleColor.DarkYellow);
            //MyPro.tulis(44, 8, "NIP      : ");
            //string nip = Console.ReadLine();
            //MyPro.tulis(44, 9, "NAMA     : ");
            //string nama = Console.ReadLine();
            //MyPro.tulis(44, 10, "JABATAN    : ");
            //string jabatan = Console.ReadLine();
            //MyPro.tulis(44, 11, "ALAMAT    : ");
            //string alamat = Console.ReadLine();

            //MyPro.tulis(44, 12, "Apakah Menyimpan Data Guru ? [Y/N] : ");
            //string dtsiswa = Console.ReadLine();

            //if (dtsiswa.ToUpper() == "Y")
            //{
            //    string query1 = "INSERT INTO guru (nip,nama,jabatan,alamat) VALUES (@nip,@nama,@jabatan,@alamat)";
            //    string koneksi1string = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb;";
            //    OleDbConnection koneksi1 = new OleDbConnection(koneksi1string);
            //    koneksi1.Open();
            //    OleDbCommand cmd1 = new OleDbCommand(query1, koneksi1);
            //    cmd1.Parameters.AddWithValue("nip", nip);
            //    cmd1.Parameters.AddWithValue("nama", nama);
            //    cmd1.Parameters.AddWithValue("jabatan", jabatan);
            //    cmd1.Parameters.AddWithValue("alamat", alamat);
            //    cmd1.ExecuteNonQuery();
            //}



            //------------>PROSEDURE

            //MyPro.tuliswarna(44, 7, "// Tampil Data Guru \\", ConsoleColor.DarkGreen, ConsoleColor.White);
            //MyPro.tuliswarna(44, 9, "Masukkan Nama Guru / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
            //string cari = Console.ReadLine();

            //string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //koneksi.Open();

            //string query;
            //if (cari == "")
            //{
            //    query = "SELECT nip,nama,jabatan FROM guru";
            //}
            //else
            //{
            //    query = "SELECT nip,nama,jabatan FROM guru WHERE nama LIKE '%" + cari + "%'";
            //    //query = "SELECT nis,nama,kelas FROM siswa WHERE nama '" +cari+ "'";   ------> pencarian kata
            //};

            //OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //DataTable dtguru = new DataTable();
            //dtguru.Load(reader);

            //int baris = 0;
            //if (dtguru.Rows.Count > 0)
            //{
            //    MyPro.tulis(48, 12, "NIP");
            //    MyPro.tulis(66, 12, "NAMA");
            //    MyPro.tulis(91, 12, "JABATAN");
            //    MyPro.kotakpemisah(45, 53, 11, 13, 84, 104, 29, ConsoleColor.Green, ConsoleColor.Black);

            //    foreach (DataRow row in dtguru.Rows)
            //    {
            //        MyPro.tulis(47, 14 + baris, row["nip"].ToString());
            //        MyPro.tulis(55, 14 + baris, row["nama"].ToString());
            //        MyPro.tulis(86, 14 + baris, row["jabatan"].ToString());
            //        baris++;
            //        if (baris == 15)
            //        {

            //            Console.ReadKey();
            //            baris = 0;
            //            if (baris == 0)
            //            {
            //                for (int a = 0; a < 15; a++)
            //                {
            //                    MyPro.tulis(47, 14 + a, "    ");
            //                    MyPro.tulis(55, 14 + a, "                            ");
            //                    MyPro.tulis(86, 14 + a, "                 ");
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MyPro.tulis(69, 11, "Data Not Found !!!!");
            //}

            //Console.ReadKey();
            //for (int a = 0; a < 23; a++)
            //{
            //    MyPro.tulis(44, 7 + a, "                                                                         ");
            //}


            //-------------->PROSEDURE

            //MyPro.tuliswarna(44, 7, "_Edit Data Guru_", ConsoleColor.Black, ConsoleColor.DarkGreen);
            //MyPro.tulis(44, 9, "Masukkkan Nip Yang Mau Dirubah : ");
            //string niplama = Console.ReadLine();

            //string query = "SELECT* FROM guru WHERE nip=@nip";
            //string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //koneksi.Open();

            //OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //cmd.Parameters.AddWithValue("@nip", niplama);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //DataTable dtguru = new DataTable();
            //dtguru.Load(reader);

            //if (dtguru.Rows.Count == 1)
            //{
            //    DataRow row = dtguru.Rows[0];

            //    MyPro.tulis(44, 11, "Nip        : " + row["nip"]);
            //    MyPro.tulis(44, 12, "Nama       : " + row["nama"]);
            //    MyPro.tulis(44, 13, "Jabatan    : " + row["jabatan"]);

            //    MyPro.tulis(44, 15, "Nip Baru     : ");
            //    string nipbaru = Console.ReadLine();
            //    MyPro.tulis(44, 16, "Nama Baru    : ");
            //    string nama = Console.ReadLine();
            //    MyPro.tulis(44, 17, "Jabatan Baru : ");
            //    string jabatan = Console.ReadLine();

            //    MyPro.tulis(44, 19, "Update Data Guru : [Y/N] ");
            //    string jawab = Console.ReadLine();

            //    if (jawab.ToUpper() == "Y")
            //    {
            //        query = "UPDATE guru SET nip=@nipbaru,nama=@nama,abatan=@jabatan WHERE nip=@nip";
            //        cmd = new OleDbCommand(query, koneksi);

            //        cmd.Parameters.AddWithValue("@nipbaru", nipbaru);
            //        cmd.Parameters.AddWithValue("@nama", nama);
            //        cmd.Parameters.AddWithValue("@jabatan", jabatan);
            //        cmd.Parameters.AddWithValue("@nis", nipbaru);

            //        cmd.ExecuteNonQuery();
            //    }

            //    //try { }catch (OleDbException olex) { olex.Message -----> menampilkan pesan error } ----> untuk mengetes error dari oleDb
            //    //try { }catch (Exception olex) { olex.massage }           ----> untuk mengetes error selain oleDb
            //}
            //else if (dtguru.Rows.Count == 0)
            //{
            //    MyPro.tulis(44, 11, "Data Yang Anda Masukkan Salah....!!!!");
            //    Console.ReadLine();
            //    for (int a = 0; a < 5; a++)
            //    {
            //        MyPro.tulis(44, 7 + a, "                                                                         ");
            //    }
            //}


            //------------->PROSEDURE

            //MyPro.tuliswarna(44, 7, "+ Hapus Data Guru +", ConsoleColor.Black, ConsoleColor.DarkGreen);
            //MyPro.tulis(44, 9, "Masukkan Nip Yang Mau Dihapus : ");
            //string nip = Console.ReadLine();

            //MyPro.tulis(44, 11, "Anda Yakin Data Guru Ini ? [Y/N] ");
            //string jawab = Console.ReadLine();

            //if (jawab.ToUpper() == "Y")
            //{
            //    string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
            //    OleDbConnection koneksi = new OleDbConnection(koneksistring);
            //    koneksi.Open();

            //    string query = "DELETE FROM guru WHERE nip=@nip";
            //    OleDbCommand cmd = new OleDbCommand(query, koneksi);
            //    cmd.Parameters.AddWithValue("@nip", nip);
            //    cmd.ExecuteNonQuery();
            //}
        }
    }
}
