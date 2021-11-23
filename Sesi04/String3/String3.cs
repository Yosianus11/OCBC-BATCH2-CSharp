using System;
using System.Collections.Generic;
using System.Linq;

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
            
            string newElement = "| Ini Coba Push NEW!";
            List<string> list = new List<string>(str.ToList());
            list.Add(newElement);
            str = list.ToArray();

            Console.WriteLine("Array termodifikasi : ");

            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
        }
    }
}