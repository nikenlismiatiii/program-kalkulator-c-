using System;
namespace CalculatorConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menu calculator");
            List();

            Console.Write("Input nomor menu [1..4] : ");
            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan > 4)
            {
                Console.WriteLine("Maaf menu yang anda pilih tidak tersedia");
                //Console.WriteLine("Tekan Sembarang key untuk keluar");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.Write("Inputkan nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (pilihan)
            {
                case 1:
                    Penambahan(a, b);
                    break;
                case 2:
                    Pengurangan(a, b);
                    break;
                case 3:
                    Perkalian(a, b);
                    break;
                case 4:
                    Pembagian(a, b);
                    break;
                default:
                    Console.WriteLine("Maaf menu yang anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine("Tekan Sembarang key untuk keluar");
            Console.ReadLine();

        }

        static void List()
        {
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        static int Penambahan(int c, int d)
        {
            int hasil = c + d;
            Console.WriteLine("Hasil Penambahan " + c + " + " + d + " : " + hasil);
            return 0;
        }

        static int Pengurangan(int c, int d)
        {
            int hasil = c - d;
            Console.WriteLine("Hasil Pengurangan " + c + " - " + d + " : " + hasil);
            return 0;
        }

        static int Perkalian(int c, int d)
        {
            int hasil = c * d;
            Console.WriteLine("Hasil Perkalian " + c + " X " + d + " : " + hasil);
            return 0;
        }

        static int Pembagian(int c, int d)
        {
            int hasil = c / d;
            Console.WriteLine("Hasil Pembagian " + c + " / " + d + " : " + hasil);
            return 0;
        }


    }
}

