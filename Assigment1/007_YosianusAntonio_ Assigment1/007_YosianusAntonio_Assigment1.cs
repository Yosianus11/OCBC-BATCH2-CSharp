using System;

namespace final_assignment1
{
    class final_assignment1
    {
        static void Main(string[] args)
        {
            int menu, submenu;
            string ulangi = "";
            do
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("=========== Selamat data di Assigment 1 App =============");
                Console.WriteLine("Nama       : Yosianus Antonio                           |");
                Console.WriteLine("No Peserta : FSDO002ONL007                              |");
                Console.WriteLine("Alamat     : Lampung                                    |");
                Console.WriteLine("=========================================================");
                Console.WriteLine("Pilih Menu Soal: ");
                Console.WriteLine("");
                Console.WriteLine("1. Segitiga Alfabet | Membuat segitiga dengan huruf");
                Console.WriteLine("2. Segitiga Angka   | Membuat segitiga dengan Angka");
                Console.WriteLine("3. Faktorial        | Faktorial dari input number");
                Console.WriteLine("4. Reversed number  | Membalikan angka yang diinpukan");
                Console.WriteLine("   1. Reversed dengan int variable");
                Console.WriteLine("   2. Reversed dengan string variable");
                Console.WriteLine("5. Number to Words  | Convert angka ke kata");
                Console.WriteLine("6. Fibonacci        | Penambahan angka sebelumnya selama looping");
                Console.WriteLine("7. Paliandrome      | Menentukan apakah value sama percis");
                Console.WriteLine("8. About Me         | Profile Peserta");
                Console.WriteLine("9. Exit             | Keluar Menu");
                Console.WriteLine("=========================================================");

                Console.Write("Masukan Pilihan Menu : ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("=============== Selamat Segitiga Alfabet ================");
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
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("=============== Selamat Segitiga Number  ================");
                            int a, j, k, m, num;

                            Console.Write("Enter the Range= ");
                            num = int.Parse(Console.ReadLine());
                            for (a = 1; a <= num; a++)
                            {
                                for (j = 1; j <= num - a; j++)
                                {
                                    Console.Write(" ");
                                }

                                //sisi kiri
                                for (k = 1; k <= a; k++)
                                {
                                    //limit digit jika diinput lebih dari 10
                                    if (k >= 10)
                                    {
                                        int lim = k % 10 + 1;
                                        if (lim >= 10)
                                        {
                                            lim = 1;
                                            Console.Write(lim);
                                        }
                                        else
                                        {
                                            Console.Write(lim);
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(k);
                                    }
                                }

                                //sisi kanan
                                for (m = a - 1; m >= 1; m--)
                                {
                                    if (m >= 10)
                                    {
                                        int lim = m % 10 + 1;
                                        if (lim >= 10)
                                        {
                                            lim = 1;
                                            Console.Write(lim);
                                        }
                                        else
                                        {
                                            Console.Write(lim);
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(m);
                                    }

                                }
                                Console.Write("\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("=================== Faktorial Number ====================");
                            int a = 1;
                            Console.Write("Enter any Number = ");
                            int n = int.Parse(Console.In.ReadLine());
                            Console.Write(n + "! =");

                            for (int i = 1; i <= n; i++)
                            {
                                a = a * i;

                                Console.Write(n - (i - 1));
                                if (n != i)
                                    Console.Write("*");
                            }
                            Console.WriteLine();
                            Console.Write("Factorial of " + n + " is ");
                            Console.Write("= ");

                            Console.WriteLine(a);
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("4. Reversed number  | Membalikan angka yang diinpukan");
                            Console.WriteLine("   1. Reversed dengan int variable");
                            Console.WriteLine("   2. Reversed dengan string variable");
                            Console.Write("Masukan Pilihan SubMenu : ");
                            submenu = int.Parse(Console.ReadLine());
                            switch (submenu)
                            {
                                case 1:
                                    {
                                        int n, reverse = 0, mod;
                                        Console.Write("Enter a number: ");
                                        n = int.Parse(Console.ReadLine());
                                        //looping memecah setiap angka yang ada
                                        while (n > 0)
                                        {
                                            // menggambil angka yang paling belakang
                                            mod = n % 10;
                                            Console.WriteLine("mod " + mod);

                                            //variable tampung untuk nilai dari hasil bagi/mod
                                            reverse = reverse * 10 + mod;
                                            Console.WriteLine("Reversed " + reverse);

                                            //membagi angka input untuk mengambil angka selanjutnya pada looping setelahnya
                                            n /= 10;
                                        }
                                        Console.WriteLine("Reversed Number: " + reverse);
                                        break;
                                    }
                                case 2:
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
                                            Console.WriteLine($"Reversed String: {reversed}");
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("=============== Number to Words ================");
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
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("=============== Bilangan Fibonacci ================");
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
                            Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("=============== Palindrome ================");
                            string s, reversed = "";
                            Console.Write("Masukan Kata : ");
                            s = Console.ReadLine();
                            for (int i = s.Length - 1; i >= 0; i--) //Decrement string mambalikan setiap huruf sesuai index  
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
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("======================   Biodata   ======================");
                            Console.WriteLine("Nama       : Yosianus Antonio                           |");
                            Console.WriteLine("No Peserta : FSDO002ONL007                              |");
                            Console.WriteLine("Alamat     : Lampung                                    |");
                            Console.WriteLine("hobby      : Coding, Music, Basket, technology          |");

                            break;
                        }
                    case 9:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.WriteLine("=========================================================");
                Console.Write("Ulangi Program y/n: ");
                ulangi = Console.ReadLine();
            } while (ulangi == "y");
        }
    }
}
