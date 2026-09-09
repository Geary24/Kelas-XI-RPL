using System;
namespace jadwal
{
    class Home 
    {
        static void Main(string[] args)
        {
            Senin senin = new Senin();
            Console.WriteLine("==JADWAL HARI SENIN==\n");
            Console.WriteLine("sesi1");
            senin.sesi1();
            Console.WriteLine("sesi2");
            senin.sesi2();
            Console.WriteLine("sesi3");
            senin.sesi3();

            Selasa selasa = new Selasa();
            Console.WriteLine("==JADWAL HARI SELASA==\n");
            Console.WriteLine("sesi1");
            selasa.sesi1();
            Console.WriteLine("sesi2");
            selasa.sesi2();
            Console.WriteLine("sesi3");
            selasa.sesi3();

            Rabu rabu = new Rabu();
            Console.WriteLine("==JADWAL HARI RABU==\n");
            Console.WriteLine("sesi1");
            rabu.sesi1();
            Console.WriteLine("sesi2");
            rabu.sesi2();
            Console.WriteLine("sesi3");
            rabu.sesi3();

            Kamis kamis = new Kamis();
            Console.WriteLine("==JADWAL HARI Kamis==\n");
            Console.WriteLine("sesi1");
            kamis.sesi1();
            Console.WriteLine("sesi2");
            kamis.sesi2();
            Console.WriteLine("sesi3");
            kamis.sesi3();

            Jumat jumat = new Jumat();
            Console.WriteLine("==JADWAL HARI Jumat==\n");
            Console.WriteLine("sesi1");
            jumat.sesi1();
            Console.WriteLine("sesi2");
            jumat.sesi2();

            Console.ReadKey();
        }
    }
    }
    class Senin()
    {
        public void sesi1() 
        {
            Console.WriteLine("Upacara");
            Console.WriteLine("Bahasa Jepang");
            Console.WriteLine("Bahasa Inggris\n");
        }
        public void sesi2() 
        {
            Console.WriteLine("Matematika\n");
        }
        public void sesi3() 
        {
            Console.WriteLine("PPLG\n");
        }

    }
    class Selasa()
    {
        public void sesi1() 
        {
            Console.WriteLine("PKWU");
            Console.WriteLine("PJOK\n");
        }
        public void sesi2() 
        {
            Console.WriteLine("Bahasa Indonesia\n");
        }
        public void sesi3() 
        {
            Console.WriteLine("PPLG\n");
        }
    }
    class Rabu() 
    {
        public void sesi1() 
        {
            Console.WriteLine("PPLG\n");
        }
        public void sesi2() 
        {
            Console.WriteLine("PPLG\n");
        }
        public void sesi3() 
        {
            Console.WriteLine("PPLG");
            Console.WriteLine("BK\n");
        }
    }
    class Kamis()
    {
        public void sesi1() 
        {
            Console.WriteLine("Bahasa Jerman");
            Console.WriteLine("Bahasa Jawa\n");
        }
        public void sesi2() 
        {
            Console.WriteLine("PKWU");
            Console.WriteLine("PAI\n");
        }
        public void sesi3() 
        {
            Console.WriteLine("PAI\n");
        }
    }
    class Jumat() 
    {
        public void sesi1() 
        {
            Console.WriteLine("Bahasa Inggris");
            Console.WriteLine("Sejarah\n");
        }
        public void sesi2() 
        {
            Console.WriteLine("Sejarah");
            Console.WriteLine("PP\n");
        }
    }