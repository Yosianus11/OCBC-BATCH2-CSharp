using System;

namespace Soal7
{
    class Soal7
    {
        static void Main(string[] args)
        {
            string s,reversed="";  
            Console.Write("Masukan Kata : ");  
            s = Console.ReadLine();  
            for (int i = s.Length-1; i >=0; i--) //Decrement string mambalikan setiap huruf sesuai index  
            {  
                reversed += s[i];  
            }  
            if (reversed == s) // menyamakan apakah kata yang sudah di balik dan kata awal sama   
            {  
                Console.WriteLine("Kata adalah Palindrome \nKata yang dimasukan {0} Kata yang direversed {1}", s, reversed);  
            }  
            else  
            {  
                Console.WriteLine("Kata bukan Palindrome \nKata yang dimasukan {0} Kata yang direversed {1}", s, reversed);  
            }  
           
        }
    }
}
