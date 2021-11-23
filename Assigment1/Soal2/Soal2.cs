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
                for (k = 1; k <= a; k++)
                {
                    Console.Write(k);
                }
                
                for (m = a-1 ; m >= 1; m--)
                {
                    Console.Write(m);
                }
                Console.Write("\n");
            }
        }
    }
}