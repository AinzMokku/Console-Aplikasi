using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class MyPro
    {
        static public void buatkotak(int kiri, int atas, int kanan, int bawah, ConsoleColor warnateks, ConsoleColor warnabackgroud)
        {
            Console.SetCursorPosition(kiri,atas);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackgroud;
            Console.Write("╒"); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Thread.Sleep(200);

            for (int a = kiri+1; a <= kanan-1; a++)
            { 
                Console.SetCursorPosition(a,atas);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackgroud;
                Console.Write("═");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black; 
            }
            //System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(kanan,atas);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackgroud;
            Console.Write("╕");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Thread.Sleep(200);

            for (int a = atas+1; a <= bawah-1; a++)
            {
                Console.SetCursorPosition(kanan, a);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackgroud;
                Console.Write("│");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(kanan, bawah);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackgroud;
            Console.Write("╛");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Thread.Sleep(200);

            for (int a = kanan-1; a >= kiri+1; a--)
            {
                Console.SetCursorPosition(a, bawah);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackgroud;
                Console.Write("═");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(kiri, bawah);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackgroud;
            Console.Write("╘");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Thread.Sleep(200);

            for (int a = bawah-1; a >= atas +1; a--)
            {
                Console.SetCursorPosition(kiri, a);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackgroud;
                Console.Write("│");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //System.Threading.Thread.Sleep(200);

        }


        static public void tulis(int kiri, int atas, string teks)
        {
           Console.SetCursorPosition(kiri, atas);
                Console.Write(teks);
        }


        static public void tuliswarna(int kiri, int atas, string teks, ConsoleColor warnateks, ConsoleColor warnabackgroud)
        {
                Console.SetCursorPosition(kiri, atas);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackgroud;
                Console.Write(teks);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;    
        }

        static public string Input(int kiri, int atas)
        {
            string hasil;
            do
            {
                Console.SetCursorPosition(kiri, atas);
                hasil = Console.ReadLine();
            } while (hasil == "");
            return hasil;
        }
    }
}
