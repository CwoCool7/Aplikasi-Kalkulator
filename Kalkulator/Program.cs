using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Title = "Aplikasi Kalkulator";
                Console.WriteLine("Pilih operasi : ");
                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("5. Keluar");

                int pilihan;
                if (!int.TryParse(Console.ReadLine(), out pilihan) || pilihan < 1 || pilihan > 5)
                {
                    Console.WriteLine("Pilihan tidak valid. Silahkan pilih 1-5.");
                    continue;
                }
                if (pilihan == 5)
                {
                    Console.WriteLine("Teima kaish telah menggunakan kalkulator ini.");
                    break;
                }

                Console.Write("Inputkan nilai a = "); double a;
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Angka tidak valid.");
                    continue;
                }

                Console.Write("Inputkan nilai a = "); double b;
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Angka tidak valid.");
                    continue;
                }

                double hasil = 0;
                string operasi = "";
                switch (pilihan)
                {
                    case 1:
                        hasil = a + b;
                        break;
                    case 2:
                        hasil = a - b;
                        break;
                    case 3:
                        hasil = a * b;
                        break;
                    case 4:
                        if (b == 0)
                            {
                            Console.WriteLine("Tidak bisa membagi dengan nol.");
                            continue;
                        }
                        hasil = a / b;
                        break;

                }

                Console.WriteLine($"Hasil {operasi} adalah: {hasil} ");

                Console.WriteLine("Lakukan operasi lagi? (y/n)");
                pilihan = char.Parse(Console.ReadLine());

            } 

        }
    }
}