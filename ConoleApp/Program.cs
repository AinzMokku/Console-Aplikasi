using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MyPro.buatkotak(2,1,118,5,ConsoleColor.Green,ConsoleColor.Black);
            MyPro.buatkotak(2, 6, 20, 30, ConsoleColor.DarkGray, ConsoleColor.Black);
            MyPro.buatkotak(21, 6, 118, 30, ConsoleColor.DarkGray, ConsoleColor.Black);

            string kepala = "Wearnes Education Center Madiun";
            MyPro.tuliswarna((120 - kepala.Length) / 2, 2, kepala,ConsoleColor.DarkRed,ConsoleColor.Black);


            string subkepala = "Inforkom 1 - 2018";
            MyPro.tulis((120 - subkepala.Length) / 2, 3, subkepala);

            MyPro.tuliswarna(6, 7, ":: MENU ::", ConsoleColor.DarkGreen, ConsoleColor.White);

            string[] menu = new string[7];
            menu[0] = "siswa";
            menu[1] = "dosen";
            menu[2] = "matkul";
            menu[3] = "nilai";
            menu[4] = "absen";
            menu[5] = "bayar";
            menu[6] = "keluar";

            for (int a = 0; a < 7; a++)
            {
                MyPro.tulis(6, 8 + a, menu[a]);
            }

            int pilih = 0;
            MyPro.tuliswarna(6, 8, menu[pilih], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);

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
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);

                }
                
                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.White, ConsoleColor.Black);
                    if (menu[pilih] == menu[0])
                    {
                        pilih = 6;
                    }
                    else { pilih--; };
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                }

                if (tombol.Key == ConsoleKey.LeftArrow)
                {
                    mainmenu = false;
                }

                if (tombol.Key == ConsoleKey.RightArrow)
                    {
                        if (menu[pilih] == menu[0])
                        {
                                Console.SetCursorPosition(22,8);
                                string[] pilihansiswa = new string[4];
                                pilihansiswa[0] = "TAMBAH DATA SISWA";
                                pilihansiswa[1] = "TAMPIL DATA SISWA";
                                pilihansiswa[2] = "EDIT DATA SISWA";
                                pilihansiswa[3] = "HAPUS DATA SISWA";
                                

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
                                            MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.White, ConsoleColor.Black);
                                            if (pilihansiswa[psiswa] == pilihansiswa[0])
                                            {
                                                psiswa = 3;
                                            }
                                            else { psiswa++; };
                                            MyPro.tuliswarna(22, 8 + psiswa, pilihansiswa[psiswa], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                                        }
                                    } while (tombol.Key != ConsoleKey.LeftArrow);
                        


                               
                        }
                    }
            } while (mainmenu);

               

            

            Console.ReadKey();
        }
    }
}
