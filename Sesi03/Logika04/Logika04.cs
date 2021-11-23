using System;

namespace Logika04
{
    class Logika04
    {
        static void Main(string[] args)
        {
            double Nilai;
            Console.Write("Nilai : ");
            Nilai = Convert.ToDouble(Console.ReadLine());

            if(Nilai>=85){
                Console.Write("Kamu mndapat grade A");
            }
            else if(Nilai>=65){
                Console.Write("Kamu mndapat grade B");
            }
            else if(Nilai>=45){
                Console.Write("Kamu mndapat grade C");
            }
            else if(Nilai>=25){
                Console.Write("Kamu mndapat grade D");
            }
        }
    }
}