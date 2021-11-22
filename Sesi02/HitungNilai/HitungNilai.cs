using System;

namespace HitungNilai
{
    class HitungNilai
    {
        static void Main(string[] args)
        {
            int pertama, kedua, ketiga, total;
            double rata;

            Console.WriteLine("=== Menghitung Nilai ===");
            Console.Write("Masukan nilai PERTAMA:");
            pertama = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KEDUA:");
            kedua = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KETIGA:");
            ketiga = int.Parse(Console.ReadLine());

            total = pertama+kedua+ketiga;
            rata= total/3.0;

            Console.WriteLine("Total Nilai adalah: "+total);
            Console.WriteLine("Rata - Rata Nilai adalah: " + rata);
            Console.Read();
        }
    }
}