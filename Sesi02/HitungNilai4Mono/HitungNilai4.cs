using System;

namespace HitungNilai4Mono
{
    class HitungNilai4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password :");
            String password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "OCBC";

            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("WELLCOME TO THE CLUB!");
            }
            else
            {
                Console.WriteLine("Sorry Try Again!");
            }
        }
    }
}
