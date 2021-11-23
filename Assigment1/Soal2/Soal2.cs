using System;

namespace Assignment2
{
    class Assignment2
    {
        static void Main(string[] args)
        {

            int a, j, k, m, num;

            Console.Write("Enter the Range=");
            num = int.Parse(Console.ReadLine());
            for (a = 1; a <= num; a++)
            {
                for (j = 1; j <= num - a; j++)
                {
                    Console.Write(" ");
                }

                //sisi kiri
                for (k = 1; k <= a; k++)
                {
                    if (k >= 10)
                    {
                        int lim = k % 10 + 1;
                        if (lim >= 10)
                        {
                            lim = 1;
                            Console.Write(lim);
                        }
                        else
                        {
                            Console.Write(lim);
                        }
                    }
                    else
                    {
                        Console.Write(k);
                    }
                }

                //sisi kanan
                for (m = a - 1; m >= 1; m--)
                {
                    if (m >= 10)
                    {
                        int lim = m % 10 + 1;
                        if (lim >= 10)
                        {
                            lim = 1;
                            Console.Write(lim);
                        }
                        else
                        {
                            Console.Write(lim);
                        }
                    }
                    else
                    {
                        Console.Write(m);
                    }

                }
                Console.Write("\n");
            }
        }
    }
}