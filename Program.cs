using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace latian_bos
{
    class FileRead
    {

        public void ReadData()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("^");
                Thread.Sleep(10);
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                    WELCOME                                    ");
            Console.WriteLine("                              Are You Ready For War                            ");
            Console.ResetColor();
            for (int i = 0; i < 80; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=");
                Thread.Sleep(10);
            }
            FileStream fs_tank = new FileStream("Tank.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr_tank = new StreamReader(fs_tank);
            //Read till the end of the file is encountered
            sr_tank.BaseStream.Seek(0, SeekOrigin.Begin);
            string str_tank = sr_tank.ReadLine();
            while (str_tank != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}", str_tank);
                str_tank = sr_tank.ReadLine();
            }
            sr_tank.Close();
            fs_tank.Close();

        }
    }
    class MainMenu
    {

        int num1;
        int num2;
        char option;
        string result;
        int back1;
        int back2;
        int optionsmenu;
        int YesOrNo;
        int back3;
        int back4;
        int ans;


        public void proses()
        {
        start:

            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                    WELCOME                                    ");
            Console.WriteLine("                              Are You Ready For War                            ");
            Console.ResetColor();
            Console.WriteLine("\n1. Play");
            Console.WriteLine("2. Option");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Exit");

            Console.WriteLine("\nEnter The Number :");
            Console.ResetColor();
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Console.Beep();
                    Console.Clear();
                    
                    for (int i = 0; i < 121; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("=");
                        Thread.Sleep(0);
                    }
                    Console.WriteLine("\nAttention: The game will start, when the game starts, the player will automatically A first path");
                    Console.WriteLine("\n                                       Enjoy The Game :)");
                    Console.WriteLine("                     \n\n\n\n\n\nPress any key to start the game");
                    Console.ReadKey();

                    break;

                case '2':
                optionlagi:
                    Console.Beep();
                    Console.Clear();
                    for (int i = 0; i < 121; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("=");
                        Thread.Sleep(0);
                    }
                    Console.WriteLine("\n1. How To Play");
                    Console.WriteLine("2. Sound");
                    Console.WriteLine("3. Back");
                    Console.WriteLine("\nEnter The Number:");
                    optionsmenu = Convert.ToChar(Console.ReadLine());
                    switch (optionsmenu)
                    {
                        case '1':


                            Console.Beep();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (int i = 0; i < 121; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("=");
                                Thread.Sleep(0);
                            }

                            Console.WriteLine("                                                     How to play:");
                            Console.WriteLine("1. use the W, A, S, D to move the tanker player 1 and 2 alternately");
                            Console.WriteLine("2. The first player will be given the opportunity to shoot the first bullet certain radius, hereinafter player 2 will run after the player one shot");
                            Console.WriteLine("3. When one of the first player, the screen will be black opponent for the tanks was not detected");
                            Console.WriteLine("4. if one payer hit the tanker opponent is declared the player wins and the game ends");
                            Console.WriteLine("                                         \n\n\nENJOY THE GAME :)     ");
                            Console.WriteLine("                                         \n\n\nPress Any Key ");
                            Console.ReadKey();
                            Console.WriteLine("\n\nAre You Understand?");
                            Console.WriteLine("1. Yes");
                            Console.WriteLine("2. No");
                            Console.WriteLine("Enter The Number");
                            YesOrNo = Convert.ToChar(Console.ReadLine());
                            switch (YesOrNo)
                            {

                                case '1':
                                    {
                                        Console.Beep();
                                        goto start;
                                    }
                                case '2':
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        goto optionlagi;
                                    }
                            }

                            break;

                        case '2':
                            Console.Clear();
                            for (int i = 0; i < 121; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("=");
                                Thread.Sleep(0);
                            }
                            Console.WriteLine("\nTo the sound settings, you can go to the settings windows by choosing speakers / headphones, and then set the game sound big and small. :)");
                            Console.WriteLine("\n\n1. Back");
                            Console.WriteLine("Enter The Number");
                            back3 = int.Parse(Console.ReadLine());
                            if (back3 == 1)
                            {
                                goto optionlagi;
                            }

                            Console.ReadLine();

                            break;

                        case '3':
                            {
                                Console.Beep();
                                goto start;
                            }
                    }
                    break;



                case '3':
                    Console.Beep();
                    Console.Clear();
                    for (int i = 0; i < 121; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("=");
                        Thread.Sleep(0);
                    }
                    Console.WriteLine("\nTank is a game console that was created from the programming language C #");
                    Console.WriteLine("\n\nCreator:");
                    Console.WriteLine("1. Rusyd Perdana Widodo");
                    Console.WriteLine("2. Reza Fadli Harris");
                    Console.WriteLine("\n\nFaculty:");
                    Console.WriteLine("Muhammad Riza Iqbal Latief");
                    Console.WriteLine("\nCCIT FTUI");
                    Console.WriteLine("\n\n\n1. Back");
                    Console.WriteLine("Enter The Number");
                    back4 = int.Parse(Console.ReadLine());
                    if (back4 == 1)
                    {
                        goto start;
                    }


                    break;


                case '4':
                    Console.Beep();
                    Console.Clear();
                    for (int i = 0; i < 121; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("=");
                        Thread.Sleep(0);
                    }
                    Console.WriteLine("\nDo you Want To Exit The Game?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("\nEnter The Number:");
                    ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else if (ans == 2)
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Option", result);
                    goto start;



            }



        }
    }
    

    
    class Program
    {
        public enum Status
        {
            Player1, Player2
        }

        public static void Main(string[] args)
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 26;
            Console.BufferWidth = 80;
            Console.BufferHeight = 26;
            
            FileRead lala = new FileRead();
            lala.ReadData();

        MenuUtama:
            Console.Clear();

            MainMenu mn = new MainMenu();
            mn.proses();

        Game:
            Console.Clear();

            int panjang_arena = Console.WindowWidth;
            int lebar_arena = Console.WindowHeight;

            Status stat = Status.Player1;

            //bidang permainan
            int p_lapangan = 79;
            int p_setengah_lapangan = p_lapangan / 2;
            int l_lapangan = 26;
            int l_setengah_lapangan = l_lapangan / 2;
            int x_awal = (panjang_arena - p_lapangan) / 2;
            int y_awal = (lebar_arena - l_lapangan) / 2;

            int x = 42;
            int y = 6;
            int xSebelumnya = 0;
            int ySebelumnya = 0;

            //Skor pemain
            int skorPemain1 = 0;
            int skorPemain2 = 0;

            Dinding dinding = new Dinding();
            dinding.Gambar(x_awal, y_awal, p_lapangan, l_lapangan);

            //Acak tank
            Random random = new Random();

            int acakX = random.Next(x_awal + 3, (x_awal + p_setengah_lapangan - 1) - 16);
            int acakY = random.Next(y_awal + 4, (y_awal + l_setengah_lapangan - 1) - 5);
            Tank tank1 = new Tank(acakX, acakY, false);

            acakX = random.Next(x_awal + 3, (x_awal + p_setengah_lapangan - 1) - 16);
            acakY = random.Next((y_awal + l_setengah_lapangan - 1) + 2, (y_awal + l_lapangan - 1) - 7);
            Tank tank2 = new Tank(acakX, acakY, false);

            acakX = random.Next((x_awal + p_setengah_lapangan) + 3, 79 - 18);
            acakY = random.Next(y_awal + 4, (y_awal + l_setengah_lapangan - 1) - 5);
            Tank tank3 = new Tank(acakX, acakY, true);

            acakX = random.Next((x_awal + p_setengah_lapangan) + 3, 79 - 18);
            acakY = random.Next((y_awal + l_setengah_lapangan - 1) + 2, (y_awal + l_lapangan - 1) - 7);
            Tank tank4 = new Tank(acakX, acakY, true);

            //Kalau player 1, tank 3 dan 4 disembunyikan
            if (stat == Status.Player1)
            {
                tank1.Dead = true;
                tank2.Dead = true;
                tank3.Dead = false;
                tank4.Dead = false;
            }
            //Kalau player 2, tank 1 dan 2 disembunyikan
            else if (stat == Status.Player2)
            {
                tank1.Dead = false;
                tank2.Dead = false;
                tank3.Dead = true;
                tank4.Dead = true;
            }

            Tank.GambarTank(tank1, tank2, tank3, tank4);

            Kursor kursor = new Kursor(x, y);
            kursor.Gambar(kursor.X, kursor.Y, "*");

            bool deteksitombol = true;
            bool sudahTembak = false;

            //Tampilkan skor
            Console.SetCursorPosition(3, 2);
            Console.Write(skorPemain1);

            Console.SetCursorPosition((x_awal + p_setengah_lapangan - 1) + 3, 2);
            Console.Write(skorPemain2);

            //Babak
            int banyakTembak = 0;
            int babakKe = 1;
            int maksimalBabak = 5;

            while (deteksitombol)
            {
                ConsoleKeyInfo infoKey = Console.ReadKey(true);

                kursor.XSebelumnya = kursor.X;
                kursor.YSebelumnya = kursor.Y;

                if (infoKey.Key == ConsoleKey.LeftArrow) 
                { 
                    kursor.X -= 1; 
                }
                else if (infoKey.Key == ConsoleKey.RightArrow) 
                { 
                    kursor.X += 1; 
                }
                else if (infoKey.Key == ConsoleKey.UpArrow) 
                { 
                    kursor.Y -= 1;
                    if (kursor.Y < 4) kursor.Y = 4;
                }
                else if (infoKey.Key == ConsoleKey.DownArrow) 
                { 
                    kursor.Y += 1; 
                }
                else if (infoKey.Key == ConsoleKey.Enter)
                {
                    sudahTembak = true;
                    banyakTembak += 1;

                    bool keluarPerulangan = false;
                    for (int i = 0; i < kursor.jangkauanBom.GetLength(0); i++)
                    {
                        for (int j = 0; j < tank3.modelTank.GetLength(0); j++)
                        {
                            if (kursor.jangkauanBom[i, 0] == Convert.ToInt16(tank3.modelTank[j, 1]) && kursor.jangkauanBom[i, 1] == Convert.ToInt16(tank3.modelTank[j, 2]))
                            {
                                tank3.Dead = true;
                                keluarPerulangan = true;
                                break;
                            }
                        }

                        if (keluarPerulangan) break;
                    }

                    keluarPerulangan = false;
                    for (int i = 0; i < kursor.jangkauanBom.GetLength(0); i++)
                    {
                        for (int j = 0; j < tank4.modelTank.GetLength(0); j++)
                        {
                            if (kursor.jangkauanBom[i, 0] == Convert.ToInt16(tank4.modelTank[j, 1]) && kursor.jangkauanBom[i, 1] == Convert.ToInt16(tank4.modelTank[j, 2]))
                            {
                                tank4.Dead = true;
                                keluarPerulangan = true;
                                break;
                            }
                        }

                        if (keluarPerulangan) break;
                    }

                    keluarPerulangan = false;
                    for (int i = 0; i < kursor.jangkauanBom.GetLength(0); i++)
                    {
                        for (int j = 0; j < tank2.modelTank.GetLength(0); j++)
                        {
                            if (kursor.jangkauanBom[i, 0] == Convert.ToInt16(tank2.modelTank[j, 1]) && kursor.jangkauanBom[i, 1] == Convert.ToInt16(tank2.modelTank[j, 2]))
                            {
                                tank2.Dead = true;
                                keluarPerulangan = true;
                                break;
                            }
                        }
                        if (keluarPerulangan) break;
                    }

                    keluarPerulangan = false;
                    for (int i = 0; i < kursor.jangkauanBom.GetLength(0); i++)
                    {
                        for (int j = 0; j < tank1.modelTank.GetLength(0); j++)
                        {
                            if (kursor.jangkauanBom[i, 0] == Convert.ToInt16(tank1.modelTank[j, 1]) && kursor.jangkauanBom[i, 1] == Convert.ToInt16(tank1.modelTank[j, 2]))
                            {
                                tank1.Dead = true;
                                keluarPerulangan = true;
                                break;
                            }
                        }
                        if (keluarPerulangan) break;
                    }
                }

                kursor.Gambar(kursor.XSebelumnya, kursor.YSebelumnya, " ");

                dinding.Gambar(x_awal, y_awal, p_lapangan, l_lapangan, false);

                Tank.GambarTank(tank1, tank2, tank3, tank4);

                kursor.Gambar(kursor.X, kursor.Y, "*");

                kursor.UpdateJangkauan(kursor.X, kursor.Y);

                string kesimpulan = "";
                if (sudahTembak)
                {
                    kursor.Gambar(kursor.XSebelumnya, kursor.YSebelumnya, " ");

                    Tank.GambarTank(tank1, tank2, tank3, tank4);
                    
                    if (stat == Status.Player1)
                    {
                        if (tank3.Dead)
                        {
                            if (kesimpulan == "") kesimpulan += "Tank 3";
                            else kesimpulan += "& Tank 3";
                            skorPemain1 += 1;
                        }

                        if (tank4.Dead)
                        {
                            if (kesimpulan == "") kesimpulan += "Tank 4";
                            else kesimpulan += "& Tank 4";
                            skorPemain1 += 1;
                        }
                    }
                    else if (stat == Status.Player2)
                    {
                        if (tank1.Dead)
                        {
                            if (kesimpulan == "") kesimpulan += "Tank 1";
                            else kesimpulan += "& Tank 1";
                            skorPemain2 += 1;
                        }

                        if (tank2.Dead)
                        {
                            if (kesimpulan == "") kesimpulan += "Tank 2";
                            else kesimpulan += "& Tank 2";
                            skorPemain2 += 1;
                        }
                    }

                    if (kesimpulan != "") kesimpulan += " Dead.";
                    
                    //Menuliskan kesimpulan
                    if (stat == Status.Player2) Console.SetCursorPosition(2, (lebar_arena - 1) - 2);
                    else Console.SetCursorPosition(x_awal + p_setengah_lapangan + 2, (lebar_arena - 1) - 2);
                    Console.Write(kesimpulan);

                    //Sleep bentar
                    bool sleep = true;
                    int waktuSleep = 10;
                    while (sleep)
                    {
                        waktuSleep -= 1;
                        if (waktuSleep <= 0) sleep = false;
                        else System.Threading.Thread.Sleep(50);
                    }

                    if (banyakTembak == 2)
                    {
                        banyakTembak = 0;
                        babakKe += 1;
                        if (babakKe > maksimalBabak) deteksitombol = false;
                    }

                    //Membersihkan kesimpulan
                    if (stat == Status.Player2) Console.SetCursorPosition(2, (lebar_arena - 1) - 2);
                    else Console.SetCursorPosition(x_awal + p_setengah_lapangan + 2, (lebar_arena - 1) - 2);
                    for (int i = 0; i < kesimpulan.Length; i++)
                    {
                        Console.Write(" ");
                    }

                    //Hapus dulu tanknya
                    tank1.Dead = false;
                    tank2.Dead = false;
                    tank3.Dead = false;
                    tank4.Dead = false;
                    Tank.GambarTank(tank1, tank2, tank3, tank4);

                    if (stat == Status.Player1) stat = Status.Player2;
                    else stat = Status.Player1;

                    //Kalau player 1, tank 3 dan 4 disembunyikan
                    if (stat == Status.Player1)
                    {
                        tank1.Dead = true;
                        tank2.Dead = true;
                        tank3.Dead = false;
                        tank4.Dead = false;
                    }
                    //Kalau player 2, tank 1 dan 2 disembunyikan
                    else if (stat == Status.Player2)
                    {
                        tank1.Dead = false;
                        tank2.Dead = false;
                        tank3.Dead = true;
                        tank4.Dead = true;
                    }


                    acakX = random.Next(x_awal + 3, (x_awal + p_setengah_lapangan - 1) - 16);
                    acakY = random.Next(y_awal + 4, (y_awal + l_setengah_lapangan - 1) - 5);
                    tank1.x = acakX;
                    tank1.y = acakY;

                    acakX = random.Next(x_awal + 3, (x_awal + p_setengah_lapangan - 1) - 16);
                    acakY = random.Next((y_awal + l_setengah_lapangan - 1) + 2, (y_awal + l_lapangan - 1) - 7);
                    tank2.x = acakX;
                    tank2.y = acakY;

                    acakX = random.Next((x_awal + p_setengah_lapangan) + 3, 79 - 18);
                    acakY = random.Next(y_awal + 4, (y_awal + l_setengah_lapangan - 1) - 5);
                    tank3.x = acakX;
                    tank3.y = acakY;

                    acakX = random.Next((x_awal + p_setengah_lapangan) + 3, 79 - 18);
                    acakY = random.Next((y_awal + l_setengah_lapangan - 1) + 2, (y_awal + l_lapangan - 1) - 7);
                    tank4.x = acakX;
                    tank4.y = acakY;

                    kursor.XSebelumnya = kursor.X;
                    kursor.YSebelumnya = kursor.Y;
                    
                    if(stat == Status.Player1)
                    {
                        kursor.X = (x_awal + p_setengah_lapangan) + 10;
                        kursor.Y = 10;
                    }
                    else if(stat == Status.Player2) 
                    {
                        kursor.X = 10;
                        kursor.Y = 10;
                    }

                    kursor.Gambar(kursor.XSebelumnya, kursor.YSebelumnya, " ");

                    //Persiapkan gambar tank dan kursornya
                    Tank.GambarTank(tank1, tank2, tank3, tank4);
                    sudahTembak = false;

                    kursor.Gambar(kursor.X, kursor.Y, "*");

                    //Bersihkan skor
                    Console.SetCursorPosition(3, 2);
                    string teksSkorPemain1 = skorPemain1.ToString();
                    for (int i = 0; i < teksSkorPemain1.Length; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.SetCursorPosition((x_awal + p_setengah_lapangan - 1) + 3, 2);
                    string teksSkorPemain2 = skorPemain2.ToString();
                    for (int i = 0; i < teksSkorPemain2.Length; i++)
                    {
                        Console.Write(" ");
                    }

                    //Tampilkan skor
                    Console.SetCursorPosition(3, 2);
                    Console.Write(skorPemain1);

                    Console.SetCursorPosition((x_awal + p_setengah_lapangan - 1) + 3, 2);
                    Console.Write(skorPemain2);

                }
            }

            //Tampilkan Skor Kedua Pemain
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.Write("Skor Terakhir:");
            Console.CursorLeft = 2;
            Console.WriteLine("");
            Console.CursorLeft = 2;
            Console.WriteLine("Player 1: " + skorPemain1);
            Console.CursorLeft = 2;
            Console.WriteLine("Player 2: " + skorPemain2);
            Console.WriteLine("");
            Console.CursorLeft = 2;
            Console.WriteLine("Tekan spasi untuk pergi ke menu utama.");
            Console.CursorLeft = 2;
            Console.WriteLine("Tekan enter untuk restart.");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Spacebar)
            {
                goto MenuUtama;
            }
            else
            {
                goto Game;
            }
        }
    }
}
