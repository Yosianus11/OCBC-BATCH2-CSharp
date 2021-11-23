using System;

namespace Logika03
{
    class Logika03
    {
        static void Main(string[] args)
        {
            Console.Write("Username :");
            String username = Console.ReadLine();
            Console.Write("Password :");
            String password = Console.ReadLine();

            bool isUsername = username == "ocbc";
            bool isPasswordValid = password == "bootcamp";

            if (isUsername && isPasswordValid)
            {
                Console.WriteLine("Anda Berhasil Login");
            }
            else
            {
                Console.WriteLine("Username atau Password anda salah");
            }
        }
    }
}