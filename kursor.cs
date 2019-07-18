using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace latian_bos
{
    class Kursor
    {
        
        int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        int y;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        int xSebelumnya;
        public int XSebelumnya
        {
            get
            {
                return xSebelumnya;
            }
            set
            {
                xSebelumnya = value;
            }
        }

        int ySebelumnya;
        public int YSebelumnya
        {
            get
            {
                return ySebelumnya;
            }
            set
            {
                ySebelumnya = value;
            }
        }

        public int[,] jangkauanBom;

        int panjangJangkauan; int lebarJangkauan;
        public Kursor(int xArg, int yArg)
        {
            X = xArg;
            Y = yArg;
            XSebelumnya = 0;
            YSebelumnya = 0;

            panjangJangkauan = 5;
            lebarJangkauan = 5;

            UpdateJangkauan(X, Y);
        }

        public void UpdateJangkauan(int xArg, int yArg)
        {
            jangkauanBom = new int[panjangJangkauan * lebarJangkauan, 2];
            int xKe = 0;
            int yKe = 0;
            int xAwal = X - ((panjangJangkauan - 1) / 2);
            int yAwal = Y - ((lebarJangkauan - 1) / 2);
            for (int i = 0; i < jangkauanBom.GetLength(0); i++)
            {
                jangkauanBom[i, 0] = xAwal + (xKe * 1);
                jangkauanBom[i, 1] = yAwal + (yKe * 1);
                if (xKe == panjangJangkauan - 1)
                {
                    xKe = 0;
                    yKe += 1;
                }
                else
                {
                    xKe += 1;
                }
            }
        }

        public void Gambar(int xArg, int yArg, string karakter)
        {
            Console.SetCursorPosition(xArg, yArg);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg, yArg + 1);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg, yArg - 1);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg - 1, yArg);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg - 2, yArg);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg + 1, yArg);
            Console.Write(karakter);
            Console.SetCursorPosition(xArg + 2, yArg);
            Console.Write(karakter);
        }
    }
}
