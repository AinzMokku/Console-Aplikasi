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

        static public void tbawah(int kiri, int atas, string teks)
        {
            Console.SetCursorPosition(kiri, atas);
            Console.WriteLine(teks);
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
        public static void pemisah3x2(int kiri,int tengah_vkiri,int atas,int tengah_h,int tengah_vkanan,int kanan,int bawah,ConsoleColor garis,ConsoleColor block)
        {
            Console.ForegroundColor = garis;
            Console.BackgroundColor = block;                
            MyPro.buatkotak(kiri, atas, tengah_vkiri, tengah_h, garis,block);                        //------------->kotak kiri atas
            MyPro.buatkotak(tengah_vkiri, atas, tengah_vkanan, tengah_h, garis, block);              //------------->kotak tengah atas
            MyPro.buatkotak(tengah_vkanan, atas, kanan, tengah_h, garis, block);                     //------------->kotak kanan atas
            MyPro.buatkotak(kiri, atas, tengah_vkiri, bawah, garis, block);                          //------------->kotak kiri bawah
            MyPro.buatkotak(tengah_vkiri, atas, tengah_vkanan, bawah, garis, block);                 //------------->kotak tengah bawah
            MyPro.buatkotak(tengah_vkanan, atas, kanan, bawah, garis, block);                        //------------->kotak kanan bawah
            MyPro.tuliswarna(tengah_vkiri, atas, "╤", garis, block);                                 //------------->celah kotak kiri & tengah atas
            MyPro.tuliswarna(tengah_vkanan, atas, "╤", garis, block);                                //------------->celah kotak tengah & kanan atas
            MyPro.tuliswarna(kiri, tengah_h, "╞", garis, block);                                     //------------->celah kotak kiri atas & kiri bawah
            MyPro.tuliswarna(tengah_vkiri, tengah_h, "╪", garis, block);                             //------------->celah kotak kiri atas & tengah atas & kiri bawah & tengah bawah
            MyPro.tuliswarna(tengah_vkanan, tengah_h, "╪", garis, block);                            //------------->celah kotak tengah atas & kanan atas & tengah bawah & kanan bawah
            MyPro.tuliswarna(kanan, tengah_h, "╡", garis, block);                                    //------------->celah kotak kanan atas & kanan bawah
            MyPro.tuliswarna(tengah_vkiri, bawah, "╧", garis, block);                                //------------->celah kotak kiri & tengah bawah
            MyPro.tuliswarna(tengah_vkanan, bawah, "╧", garis, block);                               //------------->celah kotak tengah & bawah bawah
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void pemisah2x2(int kiri, int tengah_v, int atas, int tengah_h, int kanan, int bawah, ConsoleColor garis, ConsoleColor block)
        {
            Console.ForegroundColor = garis;
            Console.BackgroundColor = block;
            MyPro.buatkotak(kiri, atas, tengah_v, tengah_h, garis, block);                       //------------->kotak kiri atas
            MyPro.buatkotak(tengah_v, atas, kanan, tengah_h, garis, block);                      //------------->kotak tengah atas
            MyPro.buatkotak(kiri, atas, tengah_v, bawah, garis, block);                          //------------->kotak kiri bawah
            MyPro.buatkotak(tengah_v, atas, kanan, bawah, garis, block);                         //------------->kotak tengah bawah
            MyPro.tuliswarna(tengah_v, atas, "╤", garis, block);                                 //------------->celah kotak kiri & tengah atas
            MyPro.tuliswarna(kiri, tengah_h, "╞", garis, block);                                 //------------->celah kotak kiri atas & kiri bawah
            MyPro.tuliswarna(kanan, tengah_h, "╡", garis, block);                                //------------->celah kotak kanan atas & kanan bawah
            MyPro.tuliswarna(tengah_v, tengah_h, "╪", garis, block);                             //------------->celah kotak tengah
            MyPro.tuliswarna(tengah_v, bawah, "╧", garis, block);                                //------------->celah kotak kiri & tengah bawah
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }               
    }
}



                
                        
                                     
                        