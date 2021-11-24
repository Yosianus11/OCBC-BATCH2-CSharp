using System;


namespace Laptop
{
    class Laptop
    {
        public string merk;
        public int ram;
        public int memory;

        public void Chatting()
        {
            Console.WriteLine("\n{0} Sedang chatting", this.merk);
        }

        public void Sosmed()
        {
            Console.WriteLine("{0} Sedang sosmed", this.merk);
        }

        public void OnlineShop()
        {
            Console.WriteLine("{0} Sedang Online Shop", this.merk);
        }
    }
}
