using System;

namespace String4
{
    class String4
    {
        static void Main()
        {
            String stringawal ="C# membuat string mudah";

            string substr = stringawal.Substring(5,12);

            Console.WriteLine("stringawal: "+ stringawal);
            Console.WriteLine("substring: "+ substr);
        }
    }
}