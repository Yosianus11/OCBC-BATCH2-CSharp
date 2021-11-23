using System;

namespace Array
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, mod;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n >0)
            {
                Console.WriteLine("Number "+n);
                mod = n%10;
                Console.WriteLine("mod "+mod);
                reverse = reverse * 10 + mod;
                Console.WriteLine("Reversed "+reverse);
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}