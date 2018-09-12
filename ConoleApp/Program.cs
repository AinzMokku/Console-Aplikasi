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
            MyPro.buatkotak(30,1,90,5,ConsoleColor.Green,ConsoleColor.Black);
            MyPro.buatkotak(2, 6, 20, 11, ConsoleColor.DarkGray, ConsoleColor.Black);
            MyPro.buatkotak(21, 6, 42, 13, ConsoleColor.DarkGray, ConsoleColor.Black);
            MyPro.buatkotak(43, 6, 118, 30, ConsoleColor.DarkGray, ConsoleColor.Black);

            string kepala = "Wearnes Education Center Madiun";
            MyPro.tuliswarna((120 - kepala.Length) / 2, 2, kepala,ConsoleColor.DarkRed,ConsoleColor.Black);


            string subkepala = "Inforkom 1 - 2018";
            MyPro.tulis((120 - subkepala.Length) / 2, 3, subkepala);

            MyPro.tuliswarna(6, 7, ":: MENU ::", ConsoleColor.DarkMagenta, ConsoleColor.Green);

            string[] menu = new string[3];
            menu[0] = "Siswa";
            menu[1] = "Guru";
            menu[2] = "Matpel";

            for (int a = 0; a < 3 ; a++)
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
                    if (menu[pilih] == menu[2])
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
                        pilih = 2;
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
                                        //-------------->OOP ACCESS

                                        SiswaMdl data = new SiswaMdl();
                                        MyPro.tuliswarna(44, 7, "-- Masukkan Data Siswa --", ConsoleColor.Black, ConsoleColor.DarkYellow);
                                        MyPro.tulis(44, 8, "Nis     : ");
                                        data.nis = Console.ReadLine();
                                        MyPro.tulis(44, 9, "Nama    : ");
                                        data.nama = Console.ReadLine();
                                        MyPro.tulis(44, 10, "Kelas   : ");
                                        data.kelas = Console.ReadLine();

                                        MyPro.tulis(44,11,"Apakah Menyimpan Data Siswa ? [Y/N] : ");
                                        string jawab = Console.ReadLine();

                                        if (jawab.ToUpper() == "Y")
                                        {
                                            SiswaSAccDB siswa = new SiswaSAccDB();
                                            siswa.Add(data);
                                        }
                                        for (int a = 0; a < 5; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }
                                    }               
                                }

                                if (tombol.Key == ConsoleKey.RightArrow)
                                { 
                                    if(pilihansiswa[psiswa] == pilihansiswa[1])
                                    {
                                        //------------>OOP ACCESS

                                        MyPro.tuliswarna(44, 7, "// Tampil Data Siswa \\", ConsoleColor.DarkGreen, ConsoleColor.White);
                                        MyPro.tuliswarna(44, 9, "Masukkan Nama Siswa / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
                                        string cari = Console.ReadLine();

                                        SiswaSAccDB siswa = new SiswaSAccDB();
                                        DataTable dtsiswa;
                                        if (cari == "")
                                            dtsiswa = siswa.GetAll();
                                        else
                                            dtsiswa = siswa.GetByName(cari);


                                        if (dtsiswa.Rows.Count > 0)
                                        {
                                            MyPro.tulis(47, 12, "NIS");
                                            MyPro.tulis(69, 12, "NAMA");
                                            MyPro.tulis(94, 12, "KELAS");
                                            MyPro.pemisah3x2(45, 51, 11, 13, 92, 100, 29, ConsoleColor.Green, ConsoleColor.Black);
                                            

                                            int baris = 0;
                                            foreach (DataRow row in dtsiswa.Rows)
                                            {
                                                MyPro.tulis(47,14+baris, row["nis"].ToString());
                                                MyPro.tulis(54, 14 + baris, row["nama"].ToString());
                                                MyPro.tulis(94, 14 + baris, row["kelas"].ToString());
                                                baris++;
                                                if (baris == 15)
                                                {

                                                    Console.ReadKey();
                                                    baris = 0;
                                                    if (baris == 0)
                                                    {
                                                        for (int a = 0; a < 15; a++)
                                                        {
                                                            MyPro.tulis(47, 14 + a, "   ");
                                                            MyPro.tulis(52, 14 + a, "                                    ");
                                                            MyPro.tulis(93, 14 + a, "     ");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MyPro.tulis(69,11,"Data Not Found !!!!");
                                        }

                                        Console.ReadKey();
                                        for (int a = 0; a < 23; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }
                                    }
                                    
                                }
                                if(tombol.Key == ConsoleKey.RightArrow)
                                {
                                    if (pilihansiswa[psiswa] == pilihansiswa[2])
                                    {

                                        //------------>OOP ACCESS

                                        MyPro.tuliswarna(44, 7, "_Edit Data Siswa_", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                        MyPro.tulis(44, 9, "Masukkkan Nis Yang Mau Dirubah : ");
                                        string nislama = Console.ReadLine();

                                        SiswaSAccDB siswa = new SiswaSAccDB();
                                        SiswaMdl data = siswa.GetByNis(nislama);
                                        if (data != null)
                                        {
                                            MyPro.tulis(44, 11, "Nis   : " + data.nis);
                                            MyPro.tulis(44, 12, "Nama  : " + data.nama);
                                            MyPro.tulis(44, 13, "Kelas : " + data.kelas);

                                            SiswaMdl databaru = new SiswaMdl();
                                            MyPro.tulis(44, 15, "Nis Baru    : ");
                                            databaru.nis = Console.ReadLine();
                                            MyPro.tulis(44, 16, "Nama Baru   : ");
                                            databaru.nama = Console.ReadLine();
                                            MyPro.tulis(44, 17, "Kelas Baru  : ");
                                            databaru.kelas = Console.ReadLine();
                                            MyPro.tulis(44, 18, "Update Data Siswa ? [Y/N] : ");
                                            string jawab = Console.ReadLine();
                                            if (jawab.ToUpper() == "Y")
                                            {
                                                siswa.Edit(data.nis, databaru);
                                            }
                                        }
                                        for (int a = 0; a < 23; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }
                                    }
                                }
                                if (tombol.Key == ConsoleKey.RightArrow)
                                {
                                    if (pilihansiswa[psiswa] == pilihansiswa[3])
                                    {

                                        //-------------->OOP ACCESS

                                        MyPro.tuliswarna(44, 7, "+ Hapus Data Siswa +", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                        MyPro.tulis(44, 9, "Masukkan Nis Yang Mau Dihapus : ");
                                        string nis = Console.ReadLine();

                                        MyPro.tulis(44, 11, "Anda Yakin Data Siswa Ini ? [Y/N] ");
                                        string jawab = Console.ReadLine();

                                        if (jawab.ToUpper() == "Y")
                                        {
                                            SiswaSAccDB siswa = new SiswaSAccDB();
                                            siswa.Hapus(nis);
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
                        pilihanguru[0] = "Tambah Data Guru";
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
                                    //---------------->OOP ACCESS

                                    GuruMdl data = new GuruMdl();
                                    MyPro.tuliswarna(44, 7, "-- Masukkan Data Guru --", ConsoleColor.Black, ConsoleColor.DarkYellow);
                                    MyPro.tulis(44, 8, "Nip       : ");
                                    data.nip = Console.ReadLine();
                                    MyPro.tulis(44, 9, "Nama      : ");
                                    data.nama = Console.ReadLine();
                                    MyPro.tulis(44, 10, "Jabatan   : ");
                                    data.jabatan = Console.ReadLine();

                                    MyPro.tulis(44, 11, "Apakah Menyimpan Data Guru ? [Y/N] : ");
                                    string jawab = Console.ReadLine();

                                    if (jawab.ToUpper() == "Y")
                                    {
                                        GuruSAccDB Guru = new GuruSAccDB();
                                        Guru.Add(data);
                                    }
                                    for (int a = 0; a < 5; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }
                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[1])
                                {
                                    //------------> OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "// Tampil Data Guru \\", ConsoleColor.DarkGreen, ConsoleColor.White);
                                    MyPro.tuliswarna(44, 9, "Masukkan Nama Guru / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
                                    string cari = Console.ReadLine();

                                    GuruSAccDB guru = new GuruSAccDB();
                                    DataTable dtguru;
                                    if (cari == "")
                                        dtguru = guru.GetAll();
                                    else
                                        dtguru = guru.GetByName(cari);

                                    int baris = 0;
                                    if (dtguru.Rows.Count > 0)
                                    {
                                        MyPro.pemisah3x2(45, 53, 11, 13, 84, 104, 29, ConsoleColor.Green, ConsoleColor.Black);
                                        MyPro.tulis(48, 12, "NIP");
                                        MyPro.tulis(66, 12, "NAMA");
                                        MyPro.tulis(91, 12, "JABATAN");
                                        

                                        foreach (DataRow row in dtguru.Rows)
                                        {
                                            MyPro.tulis(47, 14 + baris, row["nip"].ToString());
                                            MyPro.tulis(55, 14 + baris, row["nama"].ToString());
                                            MyPro.tulis(86, 14 + baris, row["jabatan"].ToString());
                                            baris++;
                                            if (baris == 15)
                                            {

                                                Console.ReadKey();
                                                baris = 0;
                                                if (baris == 0)
                                                {
                                                    for (int a = 0; a < 15; a++)
                                                    {
                                                        MyPro.tulis(47, 14 + a, "    ");
                                                        MyPro.tulis(55, 14 + a, "                            ");
                                                        MyPro.tulis(86, 14 + a, "                 ");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MyPro.tulis(69, 11, "Data Not Found !!!!");
                                    }

                                    Console.ReadKey();
                                    for (int a = 0; a < 23; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }
                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[2])
                                {
                                    //---------------> OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "_Edit Data Guru_", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkkan Nip Yang Mau Dirubah : ");
                                    string niplama = Console.ReadLine();

                                    GuruSAccDB guru = new GuruSAccDB();
                                    GuruMdl data = guru.GetBynip(niplama);
                                    if (data != null)
                                    {
                                        MyPro.tulis(44, 11, "Nip     : " + data.nip);
                                        MyPro.tulis(44, 12, "Nama    : " + data.nama);
                                        MyPro.tulis(44, 13, "jabatan : " + data.jabatan);

                                        GuruMdl databaru = new GuruMdl();
                                        MyPro.tulis(44, 15, "Nip Baru      : ");
                                        databaru.nip = Console.ReadLine();
                                        MyPro.tulis(44, 16, "Nama Baru     : ");
                                        databaru.nama = Console.ReadLine();
                                        MyPro.tulis(44, 17, "Jabatan Baru  : ");
                                        databaru.jabatan = Console.ReadLine();
                                        MyPro.tulis(44, 18, "Update Data Guru ? [Y/N] : ");
                                        string jawab = Console.ReadLine();
                                        if (jawab.ToUpper() == "Y")
                                        {
                                            guru.Edit(data.nip, databaru);
                                        }
                                    }
                                        for (int a = 0; a < 23; a++)
                                        {
                                            MyPro.tulis(44, 7 + a, "                                                                         ");
                                        }

                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanguru[pguru] == pilihanguru[3])
                                { 
                                    //-------------->OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "+ Hapus Data Guru +", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkan Nip Yang Mau Dihapus : ");
                                    string nip = Console.ReadLine();

                                    MyPro.tulis(44, 11, "Anda Yakin Data Guru Ini ? [Y/N] ");
                                    string jawab = Console.ReadLine();

                                    if (jawab.ToUpper() == "Y")
                                    {
                                        GuruSAccDB guru = new GuruSAccDB();
                                        guru.Hapus(nip);
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
                        }
                    }
                }
                if (tombol.Key == ConsoleKey.RightArrow)
                {
                    if (menu[pilih] == menu[2])
                    {
                        MyPro.tuliswarna(22, 7, "< Menu Data Matpel >", ConsoleColor.Black, ConsoleColor.Magenta);
                        Console.SetCursorPosition(22, 8);
                        string[] pilihanmatpel = new string[4];
                        pilihanmatpel[0] = "Tambah Data Matpel";
                        pilihanmatpel[1] = "Tampil Data Matpel";
                        pilihanmatpel[2] = "Edit Data Matpel";
                        pilihanmatpel[3] = "Hapus Data Matpel";

                        for (int a = 0; a < 4; a++)
                        {
                            MyPro.tulis(22, 8 + a, pilihanmatpel[a]);
                        }
                        int pmatpel = 0;
                        MyPro.tuliswarna(22, 8, pilihanmatpel[pmatpel], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);



                        do
                        {
                            tombol = Console.ReadKey(true);
                            if (tombol.Key == ConsoleKey.DownArrow)
                            {
                                MyPro.tuliswarna(22, 8 + pmatpel, pilihanmatpel[pmatpel], ConsoleColor.White, ConsoleColor.Black);
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[3])
                                {
                                    pmatpel = 0;
                                }
                                else { pmatpel++; };
                                MyPro.tuliswarna(22, 8 + pmatpel, pilihanmatpel[pmatpel], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);

                            }

                            if (tombol.Key == ConsoleKey.UpArrow)
                            {
                                MyPro.tuliswarna(22, 8 + pmatpel, pilihanmatpel[pmatpel], ConsoleColor.White, ConsoleColor.Black);
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[0])
                                {
                                    pmatpel = 3;
                                }
                                else { pmatpel--; };
                                MyPro.tuliswarna(22, 8 + pmatpel, pilihanmatpel[pmatpel], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                            }


                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[0])
                                {
                                    //---------------->OOP ACCESS

                                    MatpelMdl data = new MatpelMdl();
                                    MyPro.tuliswarna(44, 7, "-- Masukkan Data Matpel --", ConsoleColor.Black, ConsoleColor.DarkYellow);
                                    MyPro.tulis(44, 8, "Kode Matpel      : ");
                                    data.kd_matpel = Console.ReadLine();
                                    MyPro.tulis(44, 9, "Nama Matpel     : ");
                                    data.nama_matpel = Console.ReadLine();

                                    MyPro.tulis(44, 11, "Apakah Menyimpan Data Matpel ? [Y/N] : ");
                                    string jawab = Console.ReadLine();

                                    if (jawab.ToUpper() == "Y")
                                    {
                                        MatpelSAccDB matpel = new MatpelSAccDB();
                                        matpel.Add(data);
                                    }
                                    for (int a = 0; a < 5; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }
                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[1])
                                {
                                    //------------> OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "// Tampil Data Matpel \\", ConsoleColor.DarkGreen, ConsoleColor.White);
                                    MyPro.tuliswarna(44, 9, "Masukkan Nama Matpel / Kosong Untuk Menampilkan Semua Data ? : ", ConsoleColor.Black, ConsoleColor.White);
                                    string cari = Console.ReadLine();

                                    MatpelSAccDB matpel = new MatpelSAccDB();
                                    DataTable dtmatpel;
                                    if (cari == "")
                                        dtmatpel = matpel.GetAll();
                                    else
                                        dtmatpel = matpel.GetByNama_Matpel(cari);

                                    int baris = 0;
                                    if (dtmatpel.Rows.Count > 0)
                                    {
                                        MyPro.pemisah2x2(45, 53, 11, 13, 84, 29, ConsoleColor.Green, ConsoleColor.Black);
                                        MyPro.tulis(47, 12, "KODE");
                                        MyPro.tulis(62, 12, "NAMA MATPEL");


                                        foreach (DataRow row in dtmatpel.Rows)
                                        {
                                            MyPro.tulis(47, 14 + baris, row["kd_matpel"].ToString());
                                            MyPro.tulis(55, 14 + baris, row["nama_matpel"].ToString());
                                            baris++;
                                            if (baris == 15)
                                            {

                                                Console.ReadKey();
                                                baris = 0;
                                                if (baris == 0)
                                                {
                                                    for (int a = 0; a < 15; a++)
                                                    {
                                                        MyPro.tulis(47, 14 + a, "    ");
                                                        MyPro.tulis(55, 14 + a, "                            ");
                                                        MyPro.tulis(86, 14 + a, "                 ");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MyPro.tulis(69, 11, "Data Not Found !!!!");
                                    }

                                    Console.ReadKey();
                                    for (int a = 0; a < 23; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }
                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[2])
                                {
                                    //---------------> OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "_Edit Data Matpel_", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkkan Kode Matpel Yang Mau Dirubah : ");
                                    string kd_matpellama = Console.ReadLine();

                                    MatpelSAccDB matpel = new MatpelSAccDB();
                                    MatpelMdl data = matpel.GetByKd_Matpel(kd_matpellama);
                                    if (data != null)
                                    {
                                        MyPro.tulis(44, 11, "Kode Matpel    : " + data.kd_matpel);
                                        MyPro.tulis(44, 12, "Nama Matpel   : " + data.nama_matpel);

                                        MatpelMdl databaru = new MatpelMdl();
                                        MyPro.tulis(44, 15, "Kode Matpel baru      : ");
                                        databaru.kd_matpel = Console.ReadLine();
                                        MyPro.tulis(44, 16, "Nama Matpel baru     : ");
                                        databaru.nama_matpel = Console.ReadLine();
                                        MyPro.tulis(44, 17, "Update Data Matpel ? [Y/N] : ");
                                        string jawab = Console.ReadLine();
                                        if (jawab.ToUpper() == "Y")
                                        {
                                            matpel.Edit(data.kd_matpel, databaru);
                                        }
                                    }
                                    for (int a = 0; a < 23; a++)
                                    {
                                        MyPro.tulis(44, 7 + a, "                                                                         ");
                                    }

                                }
                            }
                            if (tombol.Key == ConsoleKey.RightArrow)
                            {
                                if (pilihanmatpel[pmatpel] == pilihanmatpel[3])
                                {
                                    //-------------->OOP ACCESS

                                    MyPro.tuliswarna(44, 7, "+ Hapus Data Matpel +", ConsoleColor.Black, ConsoleColor.DarkGreen);
                                    MyPro.tulis(44, 9, "Masukkan Kode Matpel Yang Mau Dihapus : ");
                                    string kd_matpel = Console.ReadLine();

                                    MyPro.tulis(44, 11, "Anda Yakin Data Matpel Ini ? [Y/N] ");
                                    string jawab = Console.ReadLine();

                                    if (jawab.ToUpper() == "Y")
                                    {
                                        MatpelSAccDB matpel = new MatpelSAccDB();
                                        matpel.Hapus(kd_matpel);
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
                        }
                    }
                }
            } while (mainmenu);
                   
            

               

            

            Console.ReadKey();
        }
    }
}
