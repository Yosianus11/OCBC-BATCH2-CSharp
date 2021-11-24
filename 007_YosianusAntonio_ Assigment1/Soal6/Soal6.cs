using System;

namespace Soal6
{
    class Soal6
    {
        static void Main(string[] args)
        {
            //nilai 1  & 2 di print terlebih dahulu karena akan memulai loopingan
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Masukan Panjang Fibonacci: ");
            number = int.Parse(Console.ReadLine());
            //Console.Write(n1 + " " + n2 + " "); //print 0 and 1 di awal    
            for (i = 2; i < number; ++i) //loop dimulai dari 2     
            {
                // 0+1=1 selanjutnya-> 1+1=2 -> 2+1=3 -> 3+2=5
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
