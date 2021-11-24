using System;

namespace Soal4
{
    class Soal4
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, mod;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            //looping memecah setiap angka yang ada
            while (n >0)
            {
                // menggambil angka yang paling belakang
                mod = n%10;
                Console.WriteLine("mod "+mod);

                //variable tampung untuk nilai dari hasil bagi/mod
                reverse = reverse * 10 + mod;
                Console.WriteLine("Reversed "+reverse);

                //membagi angka input untuk mengambil angka selanjutnya pada looping setelahnya
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}