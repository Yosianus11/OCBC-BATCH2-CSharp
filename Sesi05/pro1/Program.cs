using System;

namespace Laptop
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Laptop laptop1 = new Laptop();

            Console.Write("Masukan Merk Laptop:");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukan Kapasitas Ram:");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kapasitas Memory:");
            laptop1.memory = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Merek Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("\n Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("\n Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
