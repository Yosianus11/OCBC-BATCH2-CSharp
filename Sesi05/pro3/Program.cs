using System;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat = new pesawat();
            pesawat_tempur pswtempur = new pesawat_tempur();

            pesawat.Nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 Penumpang";

            pswtempur.Nama = "AZ500TPU";
            pswtempur.JumlahRoda = 5;
            pswtempur.Ketinggian = "200 kaki";
            pswtempur.JumlahPenumpang = "2 Penumpang plus kopoloy dan assitance";

            pesawat.terbang();
            pswtempur.terbangtinggi();
            Console.Read();
        }
    }
}
