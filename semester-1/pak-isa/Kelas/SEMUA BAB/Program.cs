using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("        PROGRAM BAB 1 - 14");
            Console.WriteLine("================================");
            Console.WriteLine("1. BAB 1");
            Console.WriteLine("2. BAB 2");
            Console.WriteLine("3. BAB 3");
            Console.WriteLine("4. BAB 4");
            Console.WriteLine("5. BAB 5");
            Console.WriteLine("6. BAB 6");
            Console.WriteLine("7. BAB 7");
            Console.WriteLine("8. BAB 8");
            Console.WriteLine("9. BAB 9");
            Console.WriteLine("10. BAB 10");
            Console.WriteLine("11. BAB 11");
            Console.WriteLine("12. BAB 12");
            Console.WriteLine("13. BAB 13");
            Console.WriteLine("14. BAB 14");
            Console.WriteLine("15. Keluar");
            Console.WriteLine("================================");
            Console.Write("Pilih BAB: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Bab1();
                    break;
                case 2:
                    Bab2();
                    break;
                case 3:
                    Bab3();
                    break;
                case 4:
                    Bab4();
                    break;
                case 5:
                    Bab5();
                    break;
                case 6:
                    Bab6();
                    break;
                case 7:
                    Bab7();
                    break;
                case 8:
                    Bab8();
                    break;
                case 9:
                    Bab9();
                    break;
                case 10:
                    Bab10();
                    break;
                case 11:
                    Bab11();
                    break;
                case 12:
                    Bab12();
                    break;
                case 13:
                    Bab13();
                    break;
                case 14:
                    Bab14();
                    break;
                case 15:
                    Console.WriteLine("Program selesai.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }

            if (pilihan != 15)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER untuk kembali ke menu utama...");
                Console.ReadLine();
            }

        } while (pilihan != 15);
    }

    static void Bab1()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 1 =====");
            Console.WriteLine("1. Contoh Program Pertama");
            Console.WriteLine("2. Hardware dan Software");
            Console.WriteLine("3. Lima Bahasa Pemrograman");
            Console.WriteLine("4. Program Hello World");
            Console.WriteLine("5. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("===== CONTOH PROGRAM PERTAMA =====");
                    Console.WriteLine("Hello World");
                    break;

                case 2:
                    Console.WriteLine("===== HARDWARE DAN SOFTWARE =====");
                    Console.WriteLine("Hardware adalah perangkat keras yang dapat disentuh.");
                    Console.WriteLine("Contoh: Keyboard, Mouse, Monitor, CPU.");
                    Console.WriteLine();
                    Console.WriteLine("Software adalah perangkat lunak berupa program.");
                    Console.WriteLine("Contoh: Windows, Microsoft Word, Google Chrome.");
                    break;

                case 3:
                    Console.WriteLine("===== LIMA BAHASA PEMROGRAMAN =====");
                    Console.WriteLine("1. C#");
                    Console.WriteLine("2. Java");
                    Console.WriteLine("3. Python");
                    Console.WriteLine("4. C++");
                    Console.WriteLine("5. JavaScript");
                    break;

                case 4:
                    Console.WriteLine("===== HELLO WORLD =====");
                    Console.WriteLine("Hello World");
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }

            if (pilihan != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER untuk kembali...");
                Console.ReadLine();
            }

        } while (pilihan != 5);
    }

    static void Bab2()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 2 =====");
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (pilihan == 1)
            {
                int p;

                Console.WriteLine("===== STUDI KASUS =====");
                Console.WriteLine("1. Login Sederhana");
                Console.WriteLine("2. Menghitung Rata-rata Tiga Nilai");
                Console.WriteLine("3. Menentukan Bilangan Ganjil atau Genap");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (p)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        RataRata();
                        break;
                    case 3:
                        GanjilGenap();
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }
            else if (pilihan == 2)
            {
                int p;

                Console.WriteLine("===== LATIHAN =====");
                Console.WriteLine("1. Membuat Teh");
                Console.WriteLine("2. Menarik Uang di ATM");
                Console.WriteLine("3. Menghitung Luas Segitiga");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (p)
                {
                    case 1:
                        MembuatTeh();
                        break;
                    case 2:
                        TarikATM();
                        break;
                    case 3:
                        LuasSegitiga();
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }

        } while (pilihan != 3);
    }

    static void Login()
    {
        Console.Write("Username:");
        string username = Console.ReadLine();

        Console.Write("Password:");
        string password = Console.ReadLine();

        if (username == "Geary" && password == "123")
            Console.WriteLine("Login berhasil.");
        else
            Console.WriteLine("Login gagal.");
    }

    static void RataRata()
    {
        Console.Write("Nilai 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nilai 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nilai 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Rata-rata = " + ((a + b + c) / 3));
    }

    static void GanjilGenap()
    {
        Console.Write("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        if (angka % 2 == 0)
            Console.WriteLine("Bilangan Genap");
        else
            Console.WriteLine("Bilangan Ganjil");
    }

    static void MembuatTeh()
    {
        Console.WriteLine("1. Siapkan gelas.");
        Console.WriteLine("2. Masukkan teh.");
        Console.WriteLine("3. Masukkan gula.");
        Console.WriteLine("4. Tuangkan air panas.");
        Console.WriteLine("5. Aduk hingga rata.");
        Console.WriteLine("Teh siap diminum.");
    }

    static void TarikATM()
    {
        Console.Write("Saldo: ");
        double saldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Jumlah penarikan: ");
        double tarik = Convert.ToDouble(Console.ReadLine());

        if (tarik <= saldo)
        {
            saldo -= tarik;
            Console.WriteLine("Penarikan berhasil.");
            Console.WriteLine("Saldo tersisa: " + saldo);
        }
        else
        {
            Console.WriteLine("Saldo tidak cukup.");
        }
    }

    static void LuasSegitiga()
    {
        Console.Write("Alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Tinggi: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Luas = " + (0.5 * alas * tinggi));
    }

    static void Bab3()
    {
        Console.WriteLine("===== BAB 3 =====");
        Console.WriteLine("Belum ada materi atau kode BAB 3.");
    }

    static void Bab4()
    {
        Console.WriteLine("===== BAB 4 =====");
        Console.WriteLine("Belum ada materi atau kode BAB 4.");
    }

    static void Bab5()
    {
        Console.WriteLine("===== BAB 5 =====");
        Console.WriteLine("Muhammad Soepolo         ");
    }

    static void Bab6()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 6 =====");
            Console.WriteLine("1. Menampilkan Nama Sekolah");
            Console.WriteLine("2. Meminta Nama dan Menampilkan Sapaan");
            Console.WriteLine("3. Menampilkan Tiga Baris Informasi");
            Console.WriteLine("4. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("SMKN 2 Buduran");
                    break;

                case 2:
                    Console.Write("Masukkan nama: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Halo, " + nama + "!");
                    break;

                case 3:
                    Console.WriteLine("Nama: Geary");
                    Console.WriteLine("Kelas: XI RPL");
                    Console.WriteLine("Sekolah: SMKN 2 Buduran");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }

            if (pilihan != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER untuk kembali...");
                Console.ReadLine();
            }

        } while (pilihan != 4);
    }

    static void Bab7()
    {
        Console.WriteLine("===== BAB 7 =====");
        Console.WriteLine("Belum ada materi atau kode BAB 7.");
    }

    static void Bab8()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 8 =====");
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Mini Project");
            Console.WriteLine("4. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("===== STUDI KASUS =====");
                    Console.WriteLine("1. Hitung Total Belanja Tiga Barang");
                    Console.WriteLine("2. Menentukan Siswa Lulus");
                    Console.WriteLine("3. Menghitung Sisa Pembagian");
                    Console.WriteLine("4. Kembali");
                    Console.Write("Pilih: ");

                    int p1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (p1 == 1)
                    {
                        Console.Write("Harga barang 1: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Harga barang 2: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Harga barang 3: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Total = " + (a + b + c));
                    }
                    else if (p1 == 2)
                    {
                        Console.Write("Masukkan nilai: ");
                        double nilai = Convert.ToDouble(Console.ReadLine());

                        if (nilai >= 75)
                            Console.WriteLine("Siswa Lulus.");
                        else
                            Console.WriteLine("Siswa Tidak Lulus.");
                    }
                    else if (p1 == 3)
                    {
                        Console.Write("Angka pertama: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Angka kedua: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Sisa pembagian = " + (a % b));
                    }

                    if (p1 != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tekan ENTER...");
                        Console.ReadLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("===== LATIHAN =====");
                    Console.WriteLine("1. Luas Persegi Panjang");
                    Console.WriteLine("2. Rata-rata Tiga Nilai");
                    Console.WriteLine("3. Bilangan Genap atau Ganjil");
                    Console.WriteLine("4. Kembali");
                    Console.Write("Pilih: ");

                    int p2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (p2 == 1)
                    {
                        Console.Write("Panjang: ");
                        double panjang = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Lebar: ");
                        double lebar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Luas = " + (panjang * lebar));
                    }
                    else if (p2 == 2)
                    {
                        Console.Write("Nilai 1: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nilai 2: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nilai 3: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Rata-rata = " + ((a + b + c) / 3));
                    }
                    else if (p2 == 3)
                    {
                        Console.Write("Masukkan angka: ");
                        int angka = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(angka % 2 == 0 ? "Genap" : "Ganjil");
                    }

                    if (p2 != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tekan ENTER...");
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("===== MINI PROJECT =====");

                    Console.Write("Nama pembeli: ");
                    string nama = Console.ReadLine();

                    double total = 0;

                    for (int i = 1; i <= 3; i++)
                    {
                        Console.Write("Harga barang " + i + ": ");
                        double harga = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Jumlah barang " + i + ": ");
                        int jumlah = Convert.ToInt32(Console.ReadLine());

                        total += harga * jumlah;
                    }

                    Console.WriteLine();
                    Console.WriteLine("===== STRUK =====");
                    Console.WriteLine("Nama: " + nama);
                    Console.WriteLine("Total: Rp" + total);
                    Console.WriteLine("Terima kasih.");
                    break;
            }

        } while (pilihan != 4);
    }

    static void Bab9()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 9 =====");
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (pilihan == 1)
            {
                Console.WriteLine("===== STUDI KASUS =====");
                Console.WriteLine("1. Input Biodata Siswa");
                Console.WriteLine("2. Luas Persegi Panjang");
                Console.WriteLine("3. Rata-rata Tiga Nilai");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");

                int p = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (p)
                {
                    case 1:
                        Console.Write("Nama: ");
                        string nama = Console.ReadLine();

                        Console.Write("Kelas: ");
                        string kelas = Console.ReadLine();

                        Console.Write("Alamat: ");
                        string alamat = Console.ReadLine();

                        Console.Write("Umur: ");
                        int umur = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Nama: " + nama);
                        Console.WriteLine("Kelas: " + kelas);
                        Console.WriteLine("Alamat: " + alamat);
                        Console.WriteLine("Umur: " + umur);
                        break;

                    case 2:
                        Console.Write("Panjang: ");
                        double panjang = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Lebar: ");
                        double lebar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Luas = " + (panjang * lebar));
                        break;

                    case 3:
                        Console.Write("Nilai 1: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nilai 2: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nilai 3: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Rata-rata = " + ((a + b + c) / 3));
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("===== LATIHAN =====");
                Console.WriteLine("1. Perbedaan Write dan WriteLine");
                Console.WriteLine("2. Nama dan Sapaan");
                Console.WriteLine("3. Menghitung Umur");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");

                int p = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (p)
                {
                    case 1:
                        Console.Write("Hello ");
                        Console.WriteLine("World");
                        Console.WriteLine("Write digunakan untuk menampilkan tanpa pindah baris.");
                        Console.WriteLine("WriteLine digunakan untuk menampilkan dan pindah baris.");
                        break;

                    case 2:
                        Console.Write("Masukkan nama: ");
                        string nama = Console.ReadLine();
                        Console.WriteLine("Halo, " + nama + "!");
                        break;

                    case 3:
                        Console.Write("Masukkan tahun lahir: ");
                        int tahun = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Umur sekitar " + (2026 - tahun) + " tahun.");
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }

        } while (pilihan != 3);
    }

    static void Bab10()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 10 =====");
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Mini Project");
            Console.WriteLine("4. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (pilihan == 1)
            {
                Console.WriteLine("===== STUDI KASUS =====");
                Console.WriteLine("1. Ganjil atau Genap");
                Console.WriteLine("2. Diskon Belanja");
                Console.WriteLine("3. Kategori Nilai Siswa");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");

                int p = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (p)
                {
                    case 1:
                        Console.Write("Masukkan angka: ");
                        int angka = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(angka % 2 == 0 ? "Genap" : "Ganjil");
                        break;

                    case 2:
                        Console.Write("Total belanja: ");
                        double total = Convert.ToDouble(Console.ReadLine());

                        double diskon = 0;

                        if (total >= 100000)
                            diskon = 20;
                        else if (total >= 50000)
                            diskon = 10;

                        Console.WriteLine("Diskon = " + diskon + "%");
                        Console.WriteLine("Total bayar = " + (total - (total * diskon / 100)));
                        break;

                    case 3:
                        Console.Write("Nilai: ");
                        int nilai = Convert.ToInt32(Console.ReadLine());

                        if (nilai >= 90)
                            Console.WriteLine("Kategori A");
                        else if (nilai >= 80)
                            Console.WriteLine("Kategori B");
                        else if (nilai >= 70)
                            Console.WriteLine("Kategori C");
                        else
                            Console.WriteLine("Kategori D");
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("===== LATIHAN =====");
                Console.WriteLine("1. Login Sederhana");
                Console.WriteLine("2. Menentukan Hari");
                Console.WriteLine("3. Menentukan Nilai A/B/C/D");
                Console.WriteLine("4. Kembali");
                Console.Write("Pilih: ");

                int p = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (p)
                {
                    case 1:
                        Login();
                        break;

                    case 2:
                        Console.Write("Masukkan angka 1-7: ");
                        int hari = Convert.ToInt32(Console.ReadLine());

                        string namaHari = hari switch
                        {
                            1 => "Senin",
                            2 => "Selasa",
                            3 => "Rabu",
                            4 => "Kamis",
                            5 => "Jumat",
                            6 => "Sabtu",
                            7 => "Minggu",
                            _ => "Tidak valid"
                        };

                        Console.WriteLine(namaHari);
                        break;

                    case 3:
                        Console.Write("Nilai: ");
                        int nilai = Convert.ToInt32(Console.ReadLine());

                        if (nilai >= 90)
                            Console.WriteLine("A");
                        else if (nilai >= 80)
                            Console.WriteLine("B");
                        else if (nilai >= 70)
                            Console.WriteLine("C");
                        else
                            Console.WriteLine("D");
                        break;
                }

                if (p != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER...");
                    Console.ReadLine();
                }
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("===== MINI PROJECT =====");
                Console.Write("Masukkan umur: ");
                int umur = Convert.ToInt32(Console.ReadLine());

                if (umur >= 17)
                    Console.WriteLine("Sudah bisa membuat KTP.");
                else
                    Console.WriteLine("Belum bisa membuat KTP.");
            }

        } while (pilihan != 4);
    }

    static void Bab11()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 11 =====");
            Console.WriteLine("1. Menampilkan Angka 1-100");
            Console.WriteLine("2. Menjumlahkan Bilangan 1-50");
            Console.WriteLine("3. Pola Segitiga Bintang");
            Console.WriteLine("4. Tabel Perkalian");
            Console.WriteLine("5. Menghitung Faktorial");
            Console.WriteLine("6. Bilangan Genap 1-100");
            Console.WriteLine("7. Pola Persegi");
            Console.WriteLine("8. Mini Project");
            Console.WriteLine("9. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    for (int i = 1; i <= 100; i++)
                        Console.WriteLine(i);
                    break;

                case 2:
                    int total = 0;

                    for (int i = 1; i <= 50; i++)
                        total += i;

                    Console.WriteLine("Jumlah = " + total);
                    break;

                case 3:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.Write("Masukkan angka: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine(angka + " x " + i + " = " + (angka * i));
                    break;

                case 5:
                    Console.Write("Masukkan angka: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    long faktorial = 1;

                    for (int i = 1; i <= n; i++)
                        faktorial *= i;

                    Console.WriteLine("Faktorial = " + faktorial);
                    break;

                case 6:
                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    }
                    break;

                case 7:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 8:
                    Console.Write("Jumlah siswa: ");
                    int jumlah = Convert.ToInt32(Console.ReadLine());

                    string[] nama = new string[jumlah];

                    for (int i = 0; i < jumlah; i++)
                    {
                        Console.Write("Nama siswa ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("===== DAFTAR SISWA =====");

                    for (int i = 0; i < jumlah; i++)
                        Console.WriteLine((i + 1) + ". " + nama[i]);
                    break;
            }

            if (pilihan != 9)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER...");
                Console.ReadLine();
            }

        } while (pilihan != 9);
    }

    static void Bab12()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 12 =====");
            Console.WriteLine("1. Menyimpan Nilai 10 Siswa");
            Console.WriteLine("2. Nilai Tertinggi dan Rata-rata");
            Console.WriteLine("3. Daftar Nama dengan List");
            Console.WriteLine("4. Mencari Nilai Terbesar");
            Console.WriteLine("5. Menghitung Bilangan Genap");
            Console.WriteLine("6. Aplikasi Daftar Nama");
            Console.WriteLine("7. Mini Project");
            Console.WriteLine("8. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    int[] nilai = new int[10];

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Nilai siswa ke-" + (i + 1) + ": ");
                        nilai[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Data nilai berhasil disimpan.");
                    break;

                case 2:
                    int[] data = { 75, 80, 90, 85, 70 };
                    int terbesar = data[0];
                    int jumlah = 0;

                    foreach (int n in data)
                    {
                        if (n > terbesar)
                            terbesar = n;

                        jumlah += n;
                    }

                    Console.WriteLine("Nilai tertinggi = " + terbesar);
                    Console.WriteLine("Rata-rata = " + (jumlah / (double)data.Length));
                    break;

                case 3:
                    List<string> daftarNama = new List<string>();

                    Console.Write("Jumlah nama: ");
                    int banyak = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < banyak; i++)
                    {
                        Console.Write("Nama ke-" + (i + 1) + ": ");
                        daftarNama.Add(Console.ReadLine());
                    }

                    Console.WriteLine();
                    foreach (string nama in daftarNama)
                        Console.WriteLine(nama);
                    break;

                case 4:
                    Console.Write("Masukkan jumlah data: ");
                    int jumlahData = Convert.ToInt32(Console.ReadLine());

                    int[] angka = new int[jumlahData];

                    for (int i = 0; i < jumlahData; i++)
                    {
                        Console.Write("Masukkan nilai ke-" + (i + 1) + ": ");
                        angka[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int nilaiTerbesar = angka[0];

                    foreach (int n in angka)
                    {
                        if (n > nilaiTerbesar)
                            nilaiTerbesar = n;
                    }

                    Console.WriteLine("Nilai terbesar = " + nilaiTerbesar);
                    break;

                case 5:
                    int[] angkaGenap = { 10, 15, 20, 25, 30, 35, 40 };
                    int hitung = 0;

                    foreach (int n in angkaGenap)
                    {
                        if (n % 2 == 0)
                            hitung++;
                    }

                    Console.WriteLine("Jumlah bilangan genap = " + hitung);
                    break;

                case 6:
                    List<string> namaList = new List<string>();
                    int p;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("===== DAFTAR NAMA =====");
                        Console.WriteLine("1. Tambah");
                        Console.WriteLine("2. Tampilkan");
                        Console.WriteLine("3. Hapus");
                        Console.WriteLine("4. Kembali");
                        Console.Write("Pilih: ");
                        p = Convert.ToInt32(Console.ReadLine());

                        if (p == 1)
                        {
                            Console.Write("Masukkan nama: ");
                            namaList.Add(Console.ReadLine());
                        }
                        else if (p == 2)
                        {
                            foreach (string nama in namaList)
                                Console.WriteLine(nama);

                            Console.ReadLine();
                        }
                        else if (p == 3)
                        {
                            Console.Write("Nama yang dihapus: ");
                            string hapus = Console.ReadLine();
                            namaList.Remove(hapus);
                        }

                    } while (p != 4);
                    break;

                case 7:
                    int[] nilaiProject = { 75, 80, 90, 85, 70 };
                    int totalProject = 0;

                    foreach (int n in nilaiProject)
                        totalProject += n;

                    Console.WriteLine("Total = " + totalProject);
                    Console.WriteLine("Rata-rata = " + (totalProject / (double)nilaiProject.Length));
                    break;
            }

            if (pilihan != 8)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER...");
                Console.ReadLine();
            }

        } while (pilihan != 8);
    }

    static void Bab13()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 13 =====");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Menentukan Genap/Ganjil");
            Console.WriteLine("4. Keliling Persegi");
            Console.WriteLine("5. Faktorial");
            Console.WriteLine("6. Pangkat Bilangan");
            Console.WriteLine("7. Mini Project");
            Console.WriteLine("8. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Console.Write("Panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + LuasPersegiPanjang(panjang, lebar));
                    break;

                case 2:
                    Console.Write("Jari-jari: ");
                    double jari = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + LuasLingkaran(jari));
                    break;

                case 3:
                    Console.Write("Masukkan angka: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(TentukanGenapGanjil(angka));
                    break;

                case 4:
                    Console.Write("Sisi: ");
                    double sisi = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Keliling = " + KelilingPersegi(sisi));
                    break;

                case 5:
                    Console.Write("Angka: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Faktorial = " + Faktorial(n));
                    break;

                case 6:
                    Console.Write("Bilangan: ");
                    double bilangan = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Pangkat: ");
                    int pangkat = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil = " + Pangkat(bilangan, pangkat));
                    break;

                case 7:
                    Console.WriteLine("Nilai: 80, 90, 85");

                    double hasil = HitungRata(80, 90, 85);

                    Console.WriteLine("Rata-rata = " + hasil);
                    break;
            }

            if (pilihan != 8)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER...");
                Console.ReadLine();
            }

        } while (pilihan != 8);
    }

    static double LuasPersegiPanjang(double panjang, double lebar)
    {
        return panjang * lebar;
    }

    static double LuasLingkaran(double jariJari)
    {
        return Math.PI * jariJari * jariJari;
    }

    static string TentukanGenapGanjil(int angka)
    {
        return angka % 2 == 0 ? "Bilangan Genap" : "Bilangan Ganjil";
    }

    static double KelilingPersegi(double sisi)
    {
        return 4 * sisi;
    }

    static long Faktorial(int angka)
    {
        long hasil = 1;

        for (int i = 1; i <= angka; i++)
            hasil *= i;

        return hasil;
    }

    static double Pangkat(double bilangan, int pangkat)
    {
        return Math.Pow(bilangan, pangkat);
    }

    static double HitungRata(int a, int b, int c)
    {
        return (a + b + c) / 3.0;
    }

    static void Bab14()
    {
        int pilihan;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BAB 14 =====");
            Console.WriteLine("1. Class Siswa");
            Console.WriteLine("2. Class PersegiPanjang");
            Console.WriteLine("3. Class Rekening");
            Console.WriteLine("4. Class Buku");
            Console.WriteLine("5. Class Mahasiswa");
            Console.WriteLine("6. Constructor Dua Parameter");
            Console.WriteLine("7. Mini Project Mobil");
            Console.WriteLine("8. Kembali");
            Console.Write("Pilih: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Siswa siswa = new Siswa();
                    siswa.Nama = "Geary";
                    siswa.Nilai = 90;
                    siswa.TampilData();
                    break;

                case 2:
                    PersegiPanjang pp = new PersegiPanjang();
                    pp.Panjang = 10;
                    pp.Lebar = 5;
                    Console.WriteLine("Luas = " + pp.HitungLuas());
                    break;

                case 3:
                    Rekening rekening = new Rekening();
                    rekening.Setor(100000);
                    rekening.LihatSaldo();
                    break;

                case 4:
                    Buku buku = new Buku();
                    buku.Judul = "Belajar C#";
                    buku.Penulis = "Geary";
                    buku.TampilData();
                    break;

                case 5:
                    Mahasiswa mahasiswa = new Mahasiswa();
                    mahasiswa.Nama = "Geary";
                    mahasiswa.NIM = "12345";
                    mahasiswa.TampilData();
                    break;

                case 6:
                    Mahasiswa mhs = new Mahasiswa("Mirza", "12345");
                    mhs.TampilData();
                    break;

                case 7:
                    Mobil mobil = new Mobil();
                    mobil.Merk = "Toyota";
                    mobil.Jalan();
                    break;
            }

            if (pilihan != 8)
            {
                Console.WriteLine();
                Console.WriteLine("Tekan ENTER...");
                Console.ReadLine();
            }

        } while (pilihan != 8);
    }
}

class Siswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }

    public void TampilData()
    {
        Console.WriteLine("Nama: " + Nama);
        Console.WriteLine("Nilai: " + Nilai);
    }
}

class PersegiPanjang
{
    public double Panjang { get; set; }
    public double Lebar { get; set; }

    public double HitungLuas()
    {
        return Panjang * Lebar;
    }
}

class Rekening
{
    private double saldo = 0;

    public void Setor(double jumlah)
    {
        saldo += jumlah;
    }

    public void LihatSaldo()
    {
        Console.WriteLine("Saldo = Rp" + saldo);
    }
}

class Buku
{
    public string Judul { get; set; }
    public string Penulis { get; set; }

    public void TampilData()
    {
        Console.WriteLine("Judul: " + Judul);
        Console.WriteLine("Penulis: " + Penulis);
    }
}

class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }

    public Mahasiswa()
    {
    }

    public Mahasiswa(string nama, string nim)
    {
        Nama = nama;
        NIM = nim;
    }

    public void TampilData()
    {
        Console.WriteLine("Nama: " + Nama);
        Console.WriteLine("NIM: " + NIM);
    }
}

class Mobil
{
    public string Merk { get; set; }

    public void Jalan()
    {
        Console.WriteLine($"{Merk} sedang berjalan.");
    }
}