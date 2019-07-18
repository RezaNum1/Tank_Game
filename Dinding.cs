using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latian_bos
{
    class Dinding
    {
        public void Gambar(int x_awal, int y_awal, int p_lapangan, int l_lapangan, bool hapus = false)
        {
            int p_setengah_lapangan = p_lapangan / 2;

            Console.SetCursorPosition(x_awal, y_awal);
            for (int i = 0; i < p_lapangan; i++)
            {
                if (!hapus) Console.Write("▓");
                else Console.Write(" ");

                //if(i < l_lapangan - 1) 
            }

            Console.SetCursorPosition(x_awal, y_awal + l_lapangan - 1);
            for (int i = 0; i < p_lapangan; i++)
            {
                if (!hapus) Console.Write("▓");
                else Console.Write(" ");
            }

            Console.SetCursorPosition(x_awal + p_setengah_lapangan - 1, y_awal);
            for (int i = 0; i < l_lapangan - 1; i++)
            {
                Console.CursorLeft = x_awal + p_setengah_lapangan - 1;

                if (!hapus) Console.Write("▓");
                else Console.Write(" ");

                Console.CursorTop += 1;
            }


            Console.SetCursorPosition(x_awal, y_awal);
            for (int i = 0; i < l_lapangan - 1; i++)
            {
                Console.CursorLeft = x_awal;

                if (!hapus) Console.Write("▓");
                else Console.Write(" ");

                Console.CursorTop += 1;
            }
            Console.SetCursorPosition(x_awal, y_awal);
            for (int i = 0; i < l_lapangan - 1; i++)
            {
                Console.CursorLeft = x_awal + p_lapangan - 1;

                if (!hapus) Console.Write("▓");
                else Console.Write(" ");

                Console.CursorTop += 1;
            }
        }
    }
}
