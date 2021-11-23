using System;

namespace Soal1
{
    class Soal1
    {
        static void Main(string[] args)
        {
            char hrf = 'A';
            int a, j, k, m;

            Console.Write("Masukan tinggi segitiga : ");
            int tinggi= int.Parse(Console.ReadLine());
            for (a = 1; a <= tinggi; a++)
            {
                //mebuat looping kosong pojok kiri atas
                for (j = tinggi; j >= a; j--){
                    Console.Write(" ");
                }
 
                for (k = 1; k <= a; k++){
                     Console.Write(hrf++);
                }
                   
                hrf--;
                for (m = 1; m < a; m++){
                    Console.Write(--hrf);
                }

                Console.Write("\n");
                hrf = 'A';
            }
        }
    }
}