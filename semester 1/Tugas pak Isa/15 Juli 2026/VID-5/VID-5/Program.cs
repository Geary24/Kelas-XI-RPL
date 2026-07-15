// Materi perulangan for, while, dan foreach

// FOR
// Digunakan ketika jumlah perulangan sudah diketahui

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan ke - " + i);
}


// 2. While Loop
// digunakan ketika jumlah perulangan belum diketahui secara pasti

int angka = 1;

while (angka <= 5)
{
    Console.WriteLine("Angka: " + angka);

    angka++; // Increment wajib agar perulangan tidak berjalan terus menerus
             // Jika increment tidak ditambahkan, program dapat mengalami infinite loop
}


// 3. Foreach Loop

string[] namaBuah = { "Apel", "Mangga", "Pisang" };

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}