using System;

namespace Array
{
    class AksesArray
    {
        static void Main(string[] args)
        {
            String[] contoh = new String[4]{
                "Motherbord", "Processor", "Power Supply", "Video Card"
            };

            Console.WriteLine("Menampilkan Semua data dalam array");
            Console.WriteLine("");

            foreach (string contoh1 in contoh)
            {
                Console.WriteLine(contoh1);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}