using System;

namespace Soal1
{
    class Soal1
    {
        static void Main(string[] args)
        {
            //Deklarasi variable 
            char hrf = 'A';
            int a, j, k, m;

            Console.Write("Masukan tinggi segitiga : ");
            int tinggi = int.Parse(Console.ReadLine());

            // limit input huruf
            if (tinggi > 26)
            {
                Console.WriteLine("Maaf Alfabet hanya 26!");
            }
            else
            {
                for (a = 1; a <= tinggi; a++)
                {
                    //mebuat looping kosong pojok kiri atas
                    for (j = tinggi; j >= a; j--)
                    {
                        Console.Write(" ");
                    }

                    //sisi kiri
                    for (k = 1; k <= a; k++)
                    {
                        Console.Write(hrf++);
                    }

                    hrf--;
                    // sisi kanan
                    for (m = 1; m < a; m++)
                    {
                        Console.Write(--hrf);
                    }

                    Console.Write("\n");
                   
                }
            }
        }
    }
}