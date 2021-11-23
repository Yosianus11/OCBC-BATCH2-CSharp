using System;

namespace String3
{
    class String3
    {
        static void Main()
        {
            string[] str = { "Ini", "adalah", "Sebuah", "test." };
            Console.WriteLine("Array Asli: ");

            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");

            Console.WriteLine("\n");

            str[1] = "Merupakan";
            str[3] = "test, juga!";

            Console.WriteLine("Array termodifikasi : ");

            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
        }
    }
}