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
