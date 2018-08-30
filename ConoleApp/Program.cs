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

                }else if (tombol.Key == ConsoleKey.UpArrow)
                {
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.White, ConsoleColor.Black);
                    if (menu[pilih] == menu[0])
                    {
                        pilih = 6;
                    }
                    else { pilih--; };
                    MyPro.tuliswarna(6, 8 + pilih, menu[pilih], ConsoleColor.DarkYellow, ConsoleColor.DarkBlue);
                }

                if (tombol.Key == ConsoleKey.RightArrow)
                    {
                        if (menu[pilih] == menu[0])
                        {
                            
                            List<string[]> siswa = new List<string[]>();
                            string jawaban;
                            do
                            {
                                string[] data = new string[5];
                                MyPro.tulis(22, 7, "Input data Guru ");
                                MyPro.tulis(22, 8, "NIM      : ");
                                data[0] = Console.ReadLine();
                                MyPro.tulis(22, 9, "NAMA     : ");
                                data[1] = Console.ReadLine();
                                MyPro.tulis(22, 10, "KELAS    : ");
                                data[2] = Console.ReadLine();
                                MyPro.tulis(22, 11, "ALAMAT   : ");
                                data[3] = Console.ReadLine();
                                MyPro.tulis(22, 12, "AGAMA    : ");
                                data[4] = Console.ReadLine();
                                siswa.Add(data);
                                System.Threading.Thread.Sleep(25);


                                MyPro.tulis(22, 13, "Apakah anda masih mau menambah data siswa [Y/N]");
                                jawaban = Console.ReadLine();
                                for (int a = 1; a <= 7; a++)
                                {
                                    MyPro.tulis(22, 6 + a, "                                                                    ");
                                }
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;
                            } while (jawaban.ToUpper() == "Y");
                        }
                    }
            } while ((tombol.Key != ConsoleKey.Enter) || (tombol.Key != ConsoleKey.LeftArrow));

               

            

            Console.ReadKey();
        }
    }
}
