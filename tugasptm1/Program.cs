using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasptm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Masukkan angka (contoh: 99.3 atau 50.4):");
                string input = Console.ReadLine();

                input = input.Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double angka))
                {
                    int bagianBulat = (int)Math.Floor(angka);
                    int bagianDesimal = (int)Math.Round((angka - bagianBulat) * 10);

                    if (bagianDesimal <= 0)
                    {
                        Console.WriteLine("Masukkan angka desimal lebih besar dari 0.\n");
                        continue; 
                    }

                    Console.WriteLine("\nHasil pola segitiga:");

                    if (bagianBulat == 99) 
                    {
                        for (int i = bagianDesimal; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else 
                    {
                        for (int i = 1; i <= bagianDesimal; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka dengan format yang benar.\n");
                }
            }

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
    

