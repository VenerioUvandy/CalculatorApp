using System;

namespace CalculatorApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double Tambah(double a, double b)
            {

                return (a + b);
            }

            double Kurang(double a, double b)
            {
                return (a - b);
            }

             double Kali(double a, double b)
            {
                return (a * b);
            }

             double Bagi(double a, double b)
            {
                return (a / b);
            }

            double satu;
            double dua;
            int operasi;

            Console.WriteLine("1. Tambah ");
            Console.WriteLine("2. Kurang ");
            Console.WriteLine("3. Kali ");
            Console.WriteLine("4. Bagi ");
            Console.Write("Pilih operasi yang diinginkan (normor) : ");
            operasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Masukkan Nilai ke-1 : ");
            satu = Convert.ToDouble (Console.ReadLine());
            Console.Write("Masukkan Nilai ke-2 : ");
            dua = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            if (operasi == 1)
            {
                Console.WriteLine("Hasil niali 1 + nilai 2 = " + Tambah(satu, dua));
            }
            
            else if (operasi == 2)
            {
                Console.WriteLine("Hasil niali 1 - nilai 2 = " + Kurang(satu, dua));
            }
            
            else if (operasi == 3)
            {
                Console.WriteLine("Hasil niali 1 x nilai 2 = " + Kali(satu, dua));
            }
            
            else
            {
                Console.WriteLine("Hasil niali 1 : nilai 2 = " + Bagi(satu, dua));
            }
        }
            
    }
}
