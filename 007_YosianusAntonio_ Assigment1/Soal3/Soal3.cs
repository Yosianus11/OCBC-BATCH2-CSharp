using System;

namespace Assignment3
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.Write("Enter any Number = ");
            int n = int.Parse(Console.In.ReadLine());
            Console.Write(n + "! =");

            for (int i = 1; i <= n; i++)
            {
                a = a * i;

                Console.Write(n - (i - 1));
                if (n != i)
                    Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("Factorial of " + n + " is ");
            Console.Write("= ");

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}