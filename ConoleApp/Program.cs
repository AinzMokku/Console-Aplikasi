using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace ConoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MyPro.buatkotak(2,1,118,5,ConsoleColor.Green,ConsoleColor.Black);
            MyPro.buatkotak(2, 6, 20, 30, ConsoleColor.DarkGray, ConsoleColor.Black);
            MyPro.buatkotak(21, 6, 42, 30, ConsoleColor.DarkGray, ConsoleColor.Black);
            MyPro.buatkotak(43, 6, 118, 30, ConsoleColor.DarkGray, ConsoleColor.Black);

            string kepala = "Wearnes Education Center Madiun";
            MyPro.tuliswarna((120 - kepala.Length) / 2, 2, kepala,ConsoleColor.DarkRed,ConsoleColor.Black);


            string subkepala = "Inforkom 1 - 2018";
            MyPro.tulis((120 - subkepala.Length) / 2, 3, subkepala);

            MyPro.tuliswarna(6, 7, ":: MENU ::", ConsoleColor.DarkMagenta, ConsoleColor.Green);

            string[] menu = new string[7];
            menu[0] = "Siswa";
            menu[1] = "Dosen";
            menu[2] = "Matkul";
            menu[3] = "Nilai";
            menu[4] = "Absen";
            menu[5] = "Bayar";
            menu[6] = "Keluar";

            for (int a = 0; a < 7; a++)
            {
                MyPro.tulis(6, 8 + a, menu[a]);
            }

            int pilih = 0;
            MyPro.tuliswarna(6, 8, menu[pilih], ConsoleColor.Black, ConsoleColor.White);

            ConsoleKeyInfo tombol;
            bool mainmenu = true;
            
            do
            {
                tombol = Console.ReadKey(true);
                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.White, ConsoleColor.Black);
                    if (menu[pilih] == menu[6])
                    {
                        pilih = 0;
                    }
                    else { pilih++; };
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.Black, ConsoleColor.White);

                }
                
                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.White, ConsoleColor.Black);
                    if (menu[pilih] == menu[0])
                    {
                        pilih = 6;
                    }
                    else { pilih--; };
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.Black, ConsoleColor.White);
                }

                if (tombol.Key == ConsoleKey.LeftArrow)
                {
                    mainmenu = false;
                }

                if (tombol.Key == ConsoleKey.RightArrow)
                    {
                        if (menu[pilih] == menu[0])
                        {
                            MyPro.tuliswarna(22,7,"< Menu Data Siswa >",ConsoleColor.Black,ConsoleColor.Magenta);
                            Console.SetCursorPosition(22, 8);
                            string[] pilihansiswa = new string[4];
                            pilihansiswa[0] = "Tambah Data Siswa";
                            pilihansiswa[1] = "Tampil Data Siswa";
                            pilihansiswa[2] = "Edit Data Siswa";
                            pilihansiswa[3] = "Hapus Data Siswa";

                            for (int a = 0; a < 4; a++)
                            {
                                MyPro.tulis(22, 8 + a, pilihansiswa[a]);
                            }
                            int psiswa = 0;
                            MyPro.tuliswarna(22, 8, pilihansiswa[psiswa], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                            
                            

                            do
                            {
                                tombol = Console.ReadKey(true);
                                if (tombol.Key == ConsoleKey.DownArrow)
                                {
                                    MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.White, ConsoleColor.Black);
                                    if (pilihansiswa[psiswa] == pilihansiswa[3])
                                    {
                                        psiswa = 0;
                                    }
                                    else { psiswa++; };
                                    MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);

                                }

                                if (tombol.Key == ConsoleKey.UpArrow)
                                {
                                    MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.White, ConsoleColor.Black);
                                    if (pilihansiswa[psiswa] == pilihansiswa[0])
                                    {
                                        psiswa = 3;
                                    }
                                    else { psiswa--; };
                                    MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                                }
                                
                                                                
                                if (tombol.Key == ConsoleKey.RightArrow)
                                {
                                    if (pilihansiswa[psiswa] == pilihansiswa[0])
                                    {
                                        MyPro.tuliswarna(44, 7, "-- Masukkan Data Siswa --", ConsoleColor.Black, ConsoleColor.DarkYellow);
                                        MyPro.tulis(44, 8, "NIS      : ");
                                        string nis = Console.ReadLine();
                                        MyPro.tulis(44, 9, "NAMA     : ");
                                        string nama = Console.ReadLine();
                                        MyPro.tulis(44, 10, "KELAS    : ");
                                        string kelas = Console.ReadLine();

                                        MyPro.tulis(44, 11, "Apakah Menyimpan Data Siswa ? [Y/N] : ");
                                        string dtsiswa = Console.ReadLine();

                                        if (dtsiswa.ToUpper() == "Y")
                                        {
                                            string query1 = "INSERT INTO siswa (nis,nama,kelas) VALUES (@nis,@nama,@kelas)";
                                            string koneksi1string = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb;";
                                            OleDbConnection koneksi1 = new OleDbConnection(koneksi1string);
                                            koneksi1.Open();
                                            OleDbCommand cmd1 = new OleDbCommand(query1, koneksi1);
                                            cmd1.Parameters.AddWithValue("nis", nis);
                                            cmd1.Parameters.AddWithValue("nama", nama);
                                            cmd1.Parameters.AddWithValue("kelas", kelas);
                                            cmd1.ExecuteNonQuery();
                                        }
                                        
                                        for (int a = 0; a < 5; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                       ");
                                        }
                                    }               
                                }

                                if (tombol.Key == ConsoleKey.RightArrow)
                                { 
                                    if(pilihansiswa[psiswa] == pilihansiswa[1])
                                    {
                                        MyPro.tuliswarna(44,7,"// Tampil Data Siswa \\",ConsoleColor.DarkGreen,ConsoleColor.White);
                                        MyPro.tuliswarna(44, 9, "Masukkan Nama Siswa / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
                                        string cari = Console.ReadLine();

                                        string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                        OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                        koneksi.Open();

                                        string query;
                                        if(cari == "")
                                        {
                                            query = "SELECT nis,nama,kelas FROM siswa";
                                        }
                                        else
                                        {
                                            query = "SELECT nis,nama,kelas FROM siswa WHERE nama '"+ cari +"'";
                                            //query = "SELECT nis,nama,kelas FROM siswa WHERE nama LIKE '%" +cari+ "%'";   ------> pendcarian sebagian kata
                                        };

                                        OleDbCommand cmd = new OleDbCommand(query,koneksi);
                                        OleDbDataReader reader = cmd.ExecuteReader();

                                        DataTable dtsiswa = new DataTable();
                                        dtsiswa.Load(reader);

                                        Console.SetCursorPosition(44, 11);
                                        if(dtsiswa.Rows.Count > 0)
                                        {
                                            foreach (DataRow row in dtsiswa.Rows)
                                            {
                                                Console.SetCursorPosition(44,10);
                                                Console.Write(" | {0,-10} | {1,-50} | {2,-5} | ",row["nis"],row["nama"],row["kelas"]);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Data Not Found");
                                        }
                                    }
                                    
                                }
                                if(tombol.Key == ConsoleKey.RightArrow)
                                {
                                    if (pilihansiswa[psiswa] == pilihansiswa[2])
                                    {
                                        MyPro.tuliswarna(44, 7, "_Edit Data Siswa_", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                        MyPro.tulis(44, 9, "Masukkkan Nis Yang Mau Dirubah : ");
                                        string nislama = Console.ReadLine();

                                        string query = "SELECT* FROM siswa WHERE nis=@nis";
                                        string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                        OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                        koneksi.Open();

                                        OleDbCommand cmd = new OleDbCommand(query, koneksi);
                                        cmd.Parameters.AddWithValue("@nis", nislama);
                                        OleDbDataReader reader = cmd.ExecuteReader();

                                        DataTable dtsiswa = new DataTable();
                                        dtsiswa.Load(reader);
                                        
                                        if(dtsiswa.Rows.Count == 1)
                                        {
                                            DataRow row = dtsiswa.Rows[0];

                                            MyPro.tulis(44, 11, "Nis      : " + row["nis"]);
                                            MyPro.tulis(44, 12, "Nama     : " + row["nama"]);
                                            MyPro.tulis(44, 13, "Kelas    : " + row["kelas"]);

                                            MyPro.tulis(44, 15, "Nis Baru   : ");
                                            string nisbaru = Console.ReadLine();
                                            MyPro.tulis(44, 16, "Nama Baru  : ");
                                            string nama = Console.ReadLine();
                                            MyPro.tulis(44, 17, "Kelas Baru : ");
                                            string kelas = Console.ReadLine();

                                            MyPro.tulis(44, 19, "Update Data Siswa : [Y/N] ");
                                            string jawab = Console.ReadLine();

                                            if(jawab.ToUpper() == "Y")
                                            {
                                                query = "UPDATE siswa SET nis=@nisbaru,nama=@nama,kelas=@Kelas WHERE nis=@nis";
                                                cmd = new OleDbCommand(query, koneksi);

                                                cmd.Parameters.AddWithValue("@nisbaru", nisbaru);
                                                cmd.Parameters.AddWithValue("@nama", nama);
                                                cmd.Parameters.AddWithValue("@kelas", kelas);
                                                cmd.Parameters.AddWithValue("@nis", nisbaru);

                                                cmd.ExecuteNonQuery();
                                            }

                                            //try { }catch (OleDbException olex) { olex.Message -----> menampilkan pesan error } ----> untuk mengetes error dari oleDb
                                            //try { }catch (Exception) { }           ----> untuk mengetes error selain oleDb
                                        }else if(dtsiswa.Rows.Count == 0)
                                            {
                                                MyPro.tulis(44, 11, "Data Yang Anda Masukkan Salah....!!!!");
                                                    Console.ReadLine();
                                                    for (int a = 0; a < 5; a++)
                                                    {
                                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                                    }
                                            }

                                    }
                                }
                                if (tombol.Key == ConsoleKey.RightArrow)
                                {
                                    if (pilihansiswa[psiswa] == pilihansiswa[3])
                                    {
                                        MyPro.tuliswarna(44, 7, "+ Hapus Data Siswa +",ConsoleColor.Black,ConsoleColor.DarkGreen);
                                        MyPro.tulis(44, 9, "Masukkan Nis Yang Mau Dihapus : ");
                                        string nis = Console.ReadLine();

                                        MyPro.tulis(44, 11, "Anda Yakin Data Siswa Ini ? [Y/N] ");
                                        string jawab = Console.ReadLine();

                                        if (jawab.ToUpper() == "Y")
                                        {
                                            string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                            OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                            koneksi.Open();

                                            string query = "DELETE FROM siswa WHERE nis=@nis";
                                            OleDbCommand cmd = new OleDbCommand(query, koneksi);
                                            cmd.Parameters.AddWithValue("@nis", nis);
                                            cmd.ExecuteNonQuery();
                                        }
                                        for (int a = 0; a < 5; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }

                                    }
                                }
                            } while (tombol.Key != ConsoleKey.LeftArrow);

                            for (int a = 0; a < 5; a++)
                            {
                                MyPro.tulis(22, 7 + a, "                    ");
                                MyPro.tulis(44, 7 + a, "                                                                         ");
                            }
                        }
                }
                
                if (tombol.Key == ConsoleKey.RightArrow)
                {
                    if (menu[pilih] == menu[1])
                    {
                        MyPro.tuliswarna(22, 7, "< Menu Data Guru >", ConsoleColor.Black, ConsoleColor.Magenta);
                        Console.SetCursorPosition(22, 8);
                        string[] pilihanguru = new string[4];
                        pilihanguru[0] = "Tambah Data GUru";
                        pilihanguru[1] = "Tampil Data Guru";
                        pilihanguru[2] = "Edit Data Guru";
                        pilihanguru[3] = "Hapus Data Guru";

                        for (int a = 0; a < 4; a++)
                        {
                            MyPro.tulis(22, 8 + a, pilihanguru[a]);
                        }
                        int pguru = 0;
                        MyPro.tuliswarna(22, 8, pilihanguru[pguru], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);



                        do
                        {
                            tombol = Console.ReadKey(true);
                            if (tombol.Key == ConsoleKey.DownArrow)
                            {
                                MyPro.tuliswarna(22, 8 + pguru, pilihanguru[pguru], ConsoleColor.White, ConsoleColor.Black);
                                if (pilihanguru[pguru] == pilihanguru[3])
                                {
                                    pguru = 0;
                                }
                                else { pguru++; };
                                MyPro.tuliswarna(22, 8 + pguru, pilihanguru[pguru], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                                 
                            }

                            if (tombol.Key == ConsoleKey.UpArrow)
                            {
                                MyPro.tuliswarna(22, 8 + pguru, pilihanguru[pguru], ConsoleColor.White, ConsoleColor.Black);
                                if (pilihanguru[pguru] == pilihanguru[0])
                                {
                                    pguru = 3;
                                }
                                else { pguru--; };
                                MyPro.tuliswarna(22, 8 + pguru, pilihanguru[pguru], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                            }


                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[0])
                                {

                                    if (tombol.Key == ConsoleKey.Backspace)
                                    {
                                        mainmenu = false;
                                    }
                                    MyPro.tuliswarna(44, 7, "-- Masukkan Data Guru --", ConsoleColor.Black, ConsoleColor.DarkYellow);
                                    MyPro.tulis(44, 8, "NIP      : ");
                                    string nip = Console.ReadLine();
                                    MyPro.tulis(44, 9, "NAMA     : ");
                                    string nama = Console.ReadLine();
                                    MyPro.tulis(44, 10, "JABATAN    : ");
                                    string jabatan = Console.ReadLine();
                                    MyPro.tulis(44, 11, "ALAMAT    : ");
                                    string alamat = Console.ReadLine();

                                    MyPro.tulis(44, 12, "Apakah Menyimpan Data Guru ? [Y/N] : ");
                                    string dtsiswa = Console.ReadLine();

                                    if (dtsiswa.ToUpper() == "Y")
                                    {
                                        string query1 = "INSERT INTO guru (nip,nama,jabatan,alamat) VALUES (@nip,@nama,@jabatan,@alamat)";
                                        string koneksi1string = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb;";
                                        OleDbConnection koneksi1 = new OleDbConnection(koneksi1string);
                                        koneksi1.Open();
                                        OleDbCommand cmd1 = new OleDbCommand(query1, koneksi1);
                                        cmd1.Parameters.AddWithValue("nip", nip);
                                        cmd1.Parameters.AddWithValue("nama", nama);
                                        cmd1.Parameters.AddWithValue("jabatan", jabatan);
                                        cmd1.Parameters.AddWithValue("alamat", alamat);
                                        cmd1.ExecuteNonQuery();
                                    }

                                    for (int a = 0; a < 6; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                       ");
                                    }
                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[1])
                                {
                                    MyPro.tuliswarna(44, 7, "// Tampil Data Guru \\", ConsoleColor.DarkGreen, ConsoleColor.White);
                                    MyPro.tuliswarna(44, 9, "Masukkan Nama Guru / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
                                    string cari = Console.ReadLine();

                                    string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                    OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                    koneksi.Open();

                                    string query;
                                    if (cari == "")
                                    {
                                        query = "SELECT nip,nama,jabatan FROM guru";
                                    }
                                    else
                                    {
                                        query = "SELECT nip,nama,jabatan FROM guru WHERE nama '" + cari + "'";
                                        //query = "SELECT nis,nama,kelas FROM siswa WHERE nama LIKE '%" +cari+ "%'";   ------> pendcarian sebagian kata
                                    };

                                    OleDbCommand cmd = new OleDbCommand(query, koneksi);
                                    OleDbDataReader reader = cmd.ExecuteReader();

                                    DataTable dtguru = new DataTable();
                                    dtguru.Load(reader);

                                    Console.SetCursorPosition(44, 11);
                                    if (dtguru.Rows.Count > 0)
                                    {
                                        foreach (DataRow row in dtguru.Rows)
                                        {
                                            Console.SetCursorPosition(44, 10);
                                            Console.Write(" | {0,-10} | {1,-50} | {2,-5} | ", row["nis"], row["nama"], row["kelas"]);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Data Not Found");
                                    }
                                }

                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[2])
                                {
                                    MyPro.tuliswarna(44, 7, "_Edit Data Guru_", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkkan Nip Yang Mau Dirubah : ");
                                    string niplama = Console.ReadLine();

                                    string query = "SELECT* FROM guru WHERE nip=@nip";
                                    string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                    OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                    koneksi.Open();

                                    OleDbCommand cmd = new OleDbCommand(query, koneksi);
                                    cmd.Parameters.AddWithValue("@nip", niplama);
                                    OleDbDataReader reader = cmd.ExecuteReader();

                                    DataTable dtguru = new DataTable();
                                    dtguru.Load(reader);

                                    if (dtguru.Rows.Count == 1)
                                    {
                                        DataRow row = dtguru.Rows[0];

                                        MyPro.tulis(44, 11, "Nip        : " + row["nip"]);
                                        MyPro.tulis(44, 12, "Nama       : " + row["nama"]);
                                        MyPro.tulis(44, 13, "Jabatan    : " + row["jabatan"]);

                                        MyPro.tulis(44, 15, "Nip Baru     : ");
                                        string nipbaru = Console.ReadLine();
                                        MyPro.tulis(44, 16, "Nama Baru    : ");
                                        string nama = Console.ReadLine();
                                        MyPro.tulis(44, 17, "Jabatan Baru : ");
                                        string jabatan = Console.ReadLine();

                                        MyPro.tulis(44, 19, "Update Data Guru : [Y/N] ");
                                        string jawab = Console.ReadLine();

                                        if (jawab.ToUpper() == "Y")
                                        {
                                            query = "UPDATE guru SET nip=@nipbaru,nama=@nama,abatan=@jabatan WHERE nip=@nip";
                                            cmd = new OleDbCommand(query, koneksi);

                                            cmd.Parameters.AddWithValue("@nipbaru", nipbaru);
                                            cmd.Parameters.AddWithValue("@nama", nama);
                                            cmd.Parameters.AddWithValue("@jabatan", jabatan);
                                            cmd.Parameters.AddWithValue("@nis", nipbaru);

                                            cmd.ExecuteNonQuery();
                                        }

                                        //try { }catch (OleDbException olex) { olex.Message -----> menampilkan pesan error } ----> untuk mengetes error dari oleDb
                                        //try { }catch (Exception) { }           ----> untuk mengetes error selain oleDb
                                    }
                                    else if (dtguru.Rows.Count == 0)
                                    {
                                        MyPro.tulis(44, 11, "Data Yang Anda Masukkan Salah....!!!!");
                                        Console.ReadLine();
                                        for (int a = 0; a < 5; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }
                                    }

                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[3])
                                {
                                    MyPro.tuliswarna(44, 7, "+ Hapus Data Guru +", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkan Nip Yang Mau Dihapus : ");
                                    string nip = Console.ReadLine();

                                    MyPro.tulis(44, 11, "Anda Yakin Data Guru Ini ? [Y/N] ");
                                    string jawab = Console.ReadLine();

                                    if (jawab.ToUpper() == "Y")
                                    {
                                        string koneksistring = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=Database.accdb";
                                        OleDbConnection koneksi = new OleDbConnection(koneksistring);
                                        koneksi.Open();

                                        string query = "DELETE FROM guru WHERE nip=@nip";
                                        OleDbCommand cmd = new OleDbCommand(query, koneksi);
                                        cmd.Parameters.AddWithValue("@nip", nip);
                                        cmd.ExecuteNonQuery();
                                    }
                                    for (int a = 0; a < 5; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }

                                }
                            }
                        } while (tombol.Key != ConsoleKey.LeftArrow);

                        for (int a = 0; a < 5; a++)
                        {
                            MyPro.tulis(22, 7 + a, "                    ");
                            MyPro.tulis(44, 7 + a, "                                                                         ");
                        }
                    }
                }
            } while (mainmenu);
                   
            

               

            

            Console.ReadKey();
        }
    }
}
