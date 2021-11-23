using System;

namespace Soal4
{
    class Soal4new
    {
        static void Main()
        {
            string number;

            Console.Write("Insert The Number : ");
            number = Console.ReadLine();
            string reversed = "";

            //validate the number length tidak 0 atau kosong
            if (number.Length > 0)
            {
                // looping decrement untuk membalik inputan string
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    //Menampung seluruh pecahan dari index array
                    reversed += number[i];
                }
                //print hasil reversed
                Console.Write($"Reversed String: {reversed}");
            }
        }
    }
}