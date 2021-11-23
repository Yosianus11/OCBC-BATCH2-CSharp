using System;

namespace String1
{
    class String1
    {
        static void Main()
        {
            char[] charray = { '1', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };
            string str1 = new string(charray);
            string str2 = "String lain.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}