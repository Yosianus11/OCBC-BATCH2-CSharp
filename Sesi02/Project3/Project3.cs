using System;

namespace Project3
{
    class Project3
    {
        static void Main(string[] args)
        {
            String nama;
            int umur;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.Write("Masukan Nama: ");
            nama = Console.ReadLine();
            Console.Write("Masukan Alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukan Umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terimakasih");
            Console.WriteLine("Data Beriku");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur}tahun");

            Console.WriteLine("SUDAH DISIMPAN!");

        }
    }
}