// method fungsi sederhana

// 1.method fungsi
// 2.parameter
// 3.return value

// 1.method
// adalah kumpulan code yang digunakan untuk menjalan kan tugas tertentu
// dapat membantu progaram dengan lebih rapih dan efesien dan terstruktur dapat digunakan kembali (Rouse)

// void karena method tidak mengembalikan nilai (tanpa return value)

static void salam() // method bernama salam
{
    Console.WriteLine("Hello word"); // method memiliki tugas untuk menampilkan hello word
}

// mengambil method tanpa return dam parameter

salam();

// 2.Method dengan parameter
// Parameter digunakan untuk mengirim data ke method

static void Sapa(string nama) // method bernama sapa dengan parameter nama
{
    Console.WriteLine("Halo " + nama); // method memiliki tugas untuk menampilkan "HAI {nama}"
}

Sapa("Budi");

// 3.Method dengan return value
static int Tambah(int a, int b) // method bernama Tambah dengan parameter a dan b
{
    return a + b; // method mengembalikan nilai hasil penjumlahan a dan b
}

// memanggil method dengan return value
Console.WriteLine(Tambah(5, 7));
