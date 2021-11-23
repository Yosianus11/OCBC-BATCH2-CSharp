using System;

namespace Soal5
{
    class Soal5
    {
        static void Main(string[] args)
        {
            int number, lanjut, num_digits;
            int[] a = new int[10];
            
            // kata dari setiap huruf 0 - 9
            string[] digits_words = {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
         };
            // input number
            Console.Write("Instert Number : ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Number (words): ");
            lanjut = 0;
            num_digits = 0;
            //looping selama var-> number belum 0 untuk memecah number ke satuan
            do
            {
                //mendapatkan angka terakhir dari setiap loop number
                lanjut = number % 10;

                // memasukan hasil mod ke dalam number digit yang akan di looping
                a[num_digits] = lanjut;
                //Console.WriteLine(a[num_digits]); - Help

                //increment number of digits
                num_digits++;
                
                // Bagi number input untuk dapat digit ke dua dari belakang yang kemudian akan dilooping kembali dan di mod
                number = number / 10;
            } while (number > 0);
            
            num_digits--;
            //looping reverse dari loopingan split di atas
            for (; num_digits >= 0; num_digits--)
            //pring hasil convert sesuai indek dari angak yang di simpan pada var -> num_digits di array a
                Console.Write(digits_words[a[num_digits]] + " ");
            Console.ReadLine();
        }
    }
}
