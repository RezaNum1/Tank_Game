using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latian_bos
{
    class Tank
    {
        public bool sembunyikan;

        public bool Dead = false;
        int live = 0;
        public string[,] modelTank;
        string[] rancanganModelTank;

        public int x = 0;
        public int y = 0;

        public Tank(int xAwal, int yAwal, bool dibalik)
        {
            Dead = false;
            live = 0;
            x = xAwal;
            y = yAwal;

            modelTank = new string[80, 4];
            rancanganModelTank = new string[5];

            //Buat model tank
            if (!dibalik)
            {
                rancanganModelTank[0] = "AAAAAAAA        ";
                rancanganModelTank[1] = "AAAAAAAA        ";
                rancanganModelTank[2] = "AAAAAAAA AAAAAAA";
                rancanganModelTank[3] = "AAAAAAAA        ";
                rancanganModelTank[4] = "AAAAAAAA        ";
            }
            else
            {
                rancanganModelTank[0] = "        AAAAAAAA";
                rancanganModelTank[1] = "        AAAAAAAA";
                rancanganModelTank[2] = "AAAAAAA AAAAAAAA";
                rancanganModelTank[3] = "        AAAAAAAA";
                rancanganModelTank[4] = "        AAAAAAAA";
            }

            //Replace A with block
            rancanganModelTank[0] = rancanganModelTank[0].Replace("A", Char.ConvertFromUtf32(9619));
            rancanganModelTank[1] = rancanganModelTank[1].Replace("A", Char.ConvertFromUtf32(9619));
            rancanganModelTank[2] = rancanganModelTank[2].Replace("A", Char.ConvertFromUtf32(9619));
            rancanganModelTank[3] = rancanganModelTank[3].Replace("A", Char.ConvertFromUtf32(9619));
            rancanganModelTank[4] = rancanganModelTank[4].Replace("A", Char.ConvertFromUtf32(9619));

            int indeksModelTank = 0;
            for (int i = 0; i < rancanganModelTank.Length; i++)
            {
                for (int j = 0; j < rancanganModelTank[i].Length; j++)
                {
                    modelTank[indeksModelTank, 0] = rancanganModelTank[i].Substring(j, 1);
                    modelTank[indeksModelTank, 1] = Convert.ToString(x + (j * 1));
                    modelTank[indeksModelTank, 2] = Convert.ToString(y + (i * 1));
                    modelTank[indeksModelTank, 3] = Convert.ToString(i);
                    indeksModelTank += 1;
                }
            }
        }

        public static void GambarTank(Tank tank1, Tank tank2, Tank tank3, Tank tank4)
        {
            if (tank1.Dead) tank1.Gambar();
            else tank1.Gambar(true);

            if (tank2.Dead) tank2.Gambar();
            else tank2.Gambar(true);

            if (tank3.Dead) tank3.Gambar();
            else tank3.Gambar(true);

            if (tank4.Dead) tank4.Gambar();
            else tank4.Gambar(true);
        }

        public void Gambar(bool hapus = false)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < rancanganModelTank.Length; i++)
            {
                string gambarKosong = "                ";
                Console.CursorLeft = x;
                if (!hapus) Console.Write(rancanganModelTank[i]);
                else Console.Write(gambarKosong);
                Console.CursorTop += 1;
            }
        }
    }
}
