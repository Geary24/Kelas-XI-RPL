// Array dan koleksi Dasar


// 1.Array
// Array digunakan untuk menyimpan banyak data dalam satu variabel
// Array biasanya digunakan ketika data memiliki data yang sama

// Array dapat menyimpan banyak data dengan tipe yang sama

//                      0        1         2
string[] namabuah = { "Apel", "Jeruk", "Mangga", }; // Array string untuk menyimpan nama buah

// penjelasan struktur Array
// string[] <- tanda {} menunjukan bahwa ini adalah array 

// mengambil data Array
//Console.WriteLine(namabuah[0]); // hasilnya menampilkan apel (isi pertama dari array) karena index array dimulai dari 0
//Console.WriteLine(namabuah[2]);

// Array juga seing di gunakan bersama dengan  perulangan foreach

foreach (string buah in namabuah) 
{
    Console.WriteLine(buah);
}


// dengan perulangan, kita dapat menghemat penulisan array tanpa harus menulis satu persatu 

// 2.koleksi dasar
// adalah koleksi data yang lebih fleksibel di banding array 

List<string> namaSiswa = new List<string>();

// menambahkan data ke List
namaSiswa.Add("budi"); // Add untuk menambahkan data ke List
namaSiswa.Add("adi");
namaSiswa.Add("romlah");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}

// bedanya dengan Array ukuran dari List lebih fleksibel dibandingkan dengan Array yang memilki ukuran yang sama
// dan cocok untuk data yang berubah ubah(dinamis)
