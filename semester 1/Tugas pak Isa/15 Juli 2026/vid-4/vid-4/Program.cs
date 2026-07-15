// Materi Percabangan

// Pada kesempatan kali ini kita akan mempelajari percabangan: If, Else, Else If, dan Switch


// Percabangan digunakan untuk mengambil keputusan pada program
// Program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF
int umur = 15;

if (umur >= 17) // If digunakan untuk mengecek kondisi,
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
}
else // Else digunakan untuk mengeksekusi perintah jika kondisi false
{
    Console.WriteLine("Belum boleh membuat KTP"); // ini output jika hasilnya false
}


// ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}


// Switch

// Digunakan untuk memilih kondisi berdasarkan nilai tertentu

string hari = "Rabu";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari Pertama");
        break;

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default:
        Console.WriteLine("Hari Lain");
        break;
}