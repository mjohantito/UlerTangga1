using System;

namespace UlarTangga_Papan1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kotak = new string[100];
            for (int n = 0; n < 100; n++)
            {
                kotak[n] = "*";
            }
            int nomorkotak = 100;
            for (int m = 0; m < 10; m++) // 10x kebawah
            {
                if (m % 2 == 0 && m != 0)
                {
                    nomorkotak -= 1;
                }
                else if (m % 2 != 0 && m != 0)
                {
                    nomorkotak -= 19; // untuk kotak di baris berikutnya agar mempunyai angka yang berbeda
                }
                for (int k = 0; k < 4; k++) // 4x kebawah
                {
                    for (int j = 0; j < 10; j++) // 10x ke kanan
                    {
                        if (k == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(kotak[nomorkotak - 1] + " ");
                            }
                            if (nomorkotak == 100)
                            {
                                Console.Write(nomorkotak + " ");
                            }
                            else if (nomorkotak < 10)
                            {
                                Console.Write(nomorkotak + "   ");
                            }
                            else
                            {
                                Console.Write(nomorkotak + "  ");
                            }

                        }
                        else if (k == 1)
                        {
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("1" + " ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("2" + " ");
                            Console.ResetColor();
                            Console.Write(kotak[nomorkotak - 1] + "   ");

                        }
                        else if (k == 2)
                        {
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("3" + " ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("4" + " ");
                            Console.ResetColor();
                            Console.Write(kotak[nomorkotak - 1] + "   ");

                        }
                        else
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Console.Write(kotak[nomorkotak - 1] + " ");
                            }
                            Console.Write(kotak[nomorkotak - 1] + "   ");

                        }

                        if (m % 2 == 0)
                        {
                            nomorkotak--;
                        }
                        else
                        {
                            nomorkotak++;
                        }

                    }
                    if (m % 2 == 0)
                    {
                        nomorkotak += 10;
                    }
                    else
                    {
                        nomorkotak -= 10; // untuk bintang di dalam kotak berada di array yang sama
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
