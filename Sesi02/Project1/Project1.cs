using System;

namespace Project1
{
    class Project1
    {
        static void Main(string[] args)
        {
            int panjang=0;
            double lebar=0;

            Console.WriteLine("Hitung Luas Persegi Panjang");
            Console.Write("Masukan Panjang :");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar :");
            lebar = double.Parse(Console.ReadLine());

            Console.WriteLine("Luas =" + panjang+"x"+lebar);
            Console.WriteLine("Luas=" +panjang*lebar);
            Console.ReadLine();

        }
    }
}