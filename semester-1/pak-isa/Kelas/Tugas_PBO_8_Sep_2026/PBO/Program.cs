using System;
namespace Matematika
{
    class Home
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator kal = new Kalkulator();
            BangubDatar Bdatar = new BangubDatar();
            BangunRuang BRuang = new BangunRuang();
            kal.penjumlahan();
            kal.pengurangan();
            kal.perkalian();
        }
    }

    class Kalkulator
    {
        public void penjumlahan ()
        {
            Console.WriteLine("Penjumlahan");
        }

        public void pengurangan ()
        {
            Console.WriteLine("Pengurangan");
        }

        public void perkalian ()
        {
            Console.WriteLine("Perkalian");
        }
    }

    class BangubDatar
    {
        public static void KelilingPersegiPanjang ()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void KelilingLingkaran ()
        {
            Console.WriteLine("Keliling Lingkaran");
        }

        public static void LuasPersegiPanjang ()
        {
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void LuasLingkaran ()
        {
            Console.WriteLine("Luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void VolumeBalok ()
        {
            Console.WriteLine("Volume Balok");
        }

        public void VolumeTabung ()
        {
            Console.WriteLine("Volume Tabung");
        }
    }


}