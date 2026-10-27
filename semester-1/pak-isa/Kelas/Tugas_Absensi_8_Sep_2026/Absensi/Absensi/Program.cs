using System;
using System.Collections.Generic;

namespace AbsensiKonsol
{
    // Kelas untuk merepresentasikan data objek siswa (Atribut)
    class Siswa
    {
        public string Nisn { get; set; }
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string AsalSekolah { get; set; }
        public double Nilai { get; set; }
        public string Status { get; set; }
    }

    class Program
    {
        // List untuk menyimpan kumpulan data siswa secara dinamis di dalam memori
        static List<Siswa> daftarAbsensi = new List<Siswa>();

        // Fungsi utama (Main) tempat program mulai dieksekusi
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ABSENSI SISWA ===");
                Console.WriteLine("1. Catat Kehadiran Baru");
                Console.WriteLine("2. Lihat Rekap Absensi");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                string pilihan = Console.ReadLine();

                // Percabangan untuk mengarahkan alur menu berdasarkan input pengguna
                switch (pilihan)
                {
                    case "1":
                        CatatKehadiran();
                        break;
                    case "2":
                        LihatRekap();
                        break;
                    case "3":
                        Console.WriteLine("\nTerima kasih telah menggunakan aplikasi ini!");
                        return;
                    default:
                        Console.WriteLine("\nPilihan tidak valid. Tekan Enter untuk mengulang...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Fungsi untuk mencatat data kehadiran siswa baru
        static void CatatKehadiran()
        {
            Console.Clear();
            Console.WriteLine("--- Form Pencatatan Absensi ---");

            Console.Write("Masukkan NISN        : ");
            string nisn = Console.ReadLine();

            Console.Write("Masukkan Nama Lengkap: ");
            string nama = Console.ReadLine();

            // Validasi input umur agar harus berupa angka (mencegah error aplikasi)
            int umur = 0;
            while (true)
            {
                Console.Write("Masukkan Umur        : ");
                if (int.TryParse(Console.ReadLine(), out umur)) break;
                Console.WriteLine("Umur harus berupa angka. Coba lagi.");
            }

            Console.Write("Masukkan Asal Sekolah: ");
            string asalSekolah = Console.ReadLine();

            // Validasi input nilai agar harus berupa angka
            double nilai = 0;
            while (true)
            {
                Console.Write("Masukkan Nilai       : ");
                if (double.TryParse(Console.ReadLine(), out nilai)) break;
                Console.WriteLine("Nilai harus berupa angka. Coba lagi.");
            }

            Console.WriteLine("\nPilih Status Kehadiran:");
            Console.WriteLine("1. Hadir");
            Console.WriteLine("2. Izin");
            Console.WriteLine("3. Sakit");
            Console.WriteLine("4. Alpha");
            Console.Write("Masukkan pilihan (1-4): ");
            string pilihanStatus = Console.ReadLine();

            // Mengubah pilihan angka menjadi teks status kehadiran
            string status = pilihanStatus switch
            {
                "2" => "Izin",
                "3" => "Sakit",
                "4" => "Alpha",
                _ => "Hadir"
            };

            // Membuat objek siswa baru berdasarkan data yang diinput
            Siswa siswaBaru = new Siswa
            {
                Nisn = nisn,
                Nama = nama,
                Umur = umur,
                AsalSekolah = asalSekolah,
                Nilai = nilai,
                Status = status
            };

            // Memasukkan data objek ke dalam list daftarAbsensi
            daftarAbsensi.Add(siswaBaru);

            Console.WriteLine($"\nBerhasil! Data {nama} dengan status '{status}' berhasil disimpan.");
            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }

        // Fungsi untuk melihat rekapitulasi data siswa yang sudah diabsen
        static void LihatRekap()
        {
            Console.Clear();
            Console.WriteLine("--- Rekapitulasi Data Absensi ---");

            if (daftarAbsensi.Count == 0)
            {
                Console.WriteLine("Belum ada data absensi yang tercatat.");
            }
            else
            {
                int nomor = 1;
                // Perulangan untuk menampilkan setiap data siswa di dalam list satu per satu
                foreach (var s in daftarAbsensi)
                {
                    Console.WriteLine($"{nomor}. NISN         : {s.Nisn}");
                    Console.WriteLine($"   Nama         : {s.Nama}");
                    Console.WriteLine($"   Umur         : {s.Umur} tahun");
                    Console.WriteLine($"   Asal Sekolah : {s.AsalSekolah}");
                    Console.WriteLine($"   Nilai        : {s.Nilai}");
                    Console.WriteLine($"   Status       : {s.Status}");
                    Console.WriteLine(new string('-', 35));
                    nomor++;
                }
            }

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
    }
}