//Deklarasi Pustaka
using System;
using System.IO.Compression;

namespace CSharpFundamental
{
    //Class atau Blue Print
    class Program
    {
        //Method atau Fungsi
        static void Main (string[] args)
        {
            //WriteLine : Menampilkan tulisan di C# | Kode : Tanpa Variable
            Console.WriteLine ("Hello World");

            //Kode : Variable
            string dncc;

            //Kode : Deklarasi Variable
            dncc = "Game";

            Console.WriteLine (dncc);

            //Kode : Kata Kunci Var
            //Kita bisa menggunakan Kata Kunci Var sebagai pengganti TipeData.
            var divisiGame = "DNCC";

            Console.WriteLine (divisiGame);

            //Kode : Const
            //Digunakan untuk menjadikan variable dan nilainya menjadi immutable (tidak bisa diubah sama sekali).
            const float phi = 3.14f;

            Console.WriteLine (phi);

            //Komentar : Program yang akan diabaikan ketika kode program dijalankan.

            // <--- Komentar Single Line

            /*
            Komentar Multi Line
            */

            // Kode : Tipe Data Number atau Angka
            int angkaInteger = 29; //Integer merupakan tipe data bilangan bulat.
            double angkaDouble = 3.14; //Double merupakan tipe data bilangan desimal.
            float angkaFloat = 88.6f; //Float merupakan tipe data bilangan desimal.

            Console.WriteLine (angkaInteger);
            Console.WriteLine (angkaDouble);
            Console.WriteLine (angkaFloat);

            //Kode : String
            //String merupakan tipe data text.
            string namaAwal, namaAkhir;
            namaAwal = "Afzal";
            namaAkhir = "Ivano";

            Console.WriteLine (namaAwal);
            Console.WriteLine (namaAkhir);

            namaAwal += namaAkhir;

            Console.WriteLine (namaAwal);

            //Kode : Karakter Backslash (\)
            //Backslash dapat digunakan pada tipe data string.

            string hari = "Senin \tSelasa \tRabu \tKamis"; //(\t) untuk membuat kolom.
            string bulan = "Januari \rFebruari \rMaret \rApril"; //(\r) untuk membuat baris.
            string film = "\"The Batman\""; // (\") untuk membuat tanda kutip dua.

            Console.WriteLine (hari);
            Console.WriteLine (bulan);
            Console.WriteLine (film);

            //Kode : Manipulasi String

            string txt = "Ini ada text Bro and Sis.";

            Console.WriteLine (txt.ToLower()); //Menjadikan huruf lowercase.
            Console.WriteLine (txt.ToUpper()); //Menjadikan huruf uppercase.
            Console.WriteLine ("Panjang string tersebut adalah " + txt.Length + " huruf."); //Menghitung jumlah huruf.
            Console.WriteLine (txt + " Yang digabungkan."); //Menggabungkan string.

            //Kode : String Interpolation
            //String mendukung expression, di mana di dalam expression kita bisa mengambil data dari variable lain.
            //Untuk mengidentifikasi string yang diinterpolasi, cukup tambahkan simbol '$'.

            string nama = "Zalvano";
            var date = DateTime.Now;

            Console.WriteLine ($"Halo, {nama}! Hari ini adalah {date.DayOfWeek}, {date} WIB.");
            //date.DayOfWeek : Menampilkan hari. | DateTime.Now : Menampilkan tanggal/bulan/tahun dan pukul berapa.

            //Kode : Boolean
            //Digunakan untuk merepresentasikan dua nilai yang mungkin : true (benar) or false (salah).

            bool benar = true;
            bool salah = false;

            if (benar == true) {
                Console.WriteLine ("True");
            }

            else if (salah == false) {
                Console.WriteLine ("False");
            }

            //Kode : Konversi Tipe Data Float - Integer
            float pertama = 3.14f;
            int kedua = (int)pertama;

            Console.WriteLine(kedua);

            //Kode : Konversi Tipe Data Number - String
            int angkaSatu = 12;

            Console.WriteLine ($"{angkaSatu.ToString()}");

            //Kode : Konversi Tipe Data String -Integer
            string siji = "2";
            string loro = "9";
            int sum = int.Parse(siji) + int.Parse(loro);

            Console.WriteLine(sum);

            //Kode : Operator Aritmatika
            //Digunakan untuk menghitung.
            var hasil1 = 10 + 20;
            var hasil2 = 20 - 10;
            var hasil3 = 10 * 20;
            var hasil4 = 20 / 10;
            var hasil5 = 20 % 10;

            Console.WriteLine(hasil1);
            Console.WriteLine(hasil2);
            Console.WriteLine(hasil3);
            Console.WriteLine(hasil4);
            Console.WriteLine(hasil5);

            //Kode : Increment & Decrement
            //Digunakan untuk penambahan atau pengurangan setelah atau sesudah operasi.
            int a = 5;

            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);

            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            Console.WriteLine(a);
            Console.WriteLine(a--);
            Console.WriteLine(a);

            Console.WriteLine(a);
            Console.WriteLine(--a);
            Console.WriteLine(a);

            //Operator Perbandingan
            // == ---> Sama dengan
            // > ---> Lebih dari
            // < ---> Kurang dari
            // >= ---> Lebih dari sama dengan
            // <= ---> Kurang dari sama dengan

            //Operator Logika
            // && ---> Dan ===> Kedua nilai harus terpenuhi
            // || ---> Atau ===> Salah satu atau kedua nilai harus terpenuhi
            // ! ---> Negasi atau Kebalikan ===> Kebalikan dari nilai yang diinput

            //Kode : Membuat Array
            //Digunakan untuk menyimpan koleksi elemen dengan tipe data yang sama dalam urutan terindeks.

            string[] divisi = {"web", "mobile", "game", "mulmed", "jaringan"};

            Console.WriteLine(divisi[0]);
            Console.WriteLine(divisi[1]);
            Console.WriteLine(divisi[2]);
            Console.WriteLine(divisi[3]);
            Console.WriteLine(divisi[4]);

            string[] names = new string[5];
            names [0] = "web";
            names [0] = "mobile";
            names [0] = "game";
            names [0] = "mulmed";
            names [0] = "jaringan";

            //Kode : Array 2D
            int[,] number1 = new int[2,3];
            int[,] numbers1 = { {1, 2, 3}, {4, 5, 6} };

            Console.WriteLine(numbers1[0, 1]);
            Console.WriteLine(numbers1[1, 2]);

            //Kode : Array 3D
            int[,,] number2 = new int[2, 2, 3];
            int[,,] numbers2 = { { { 1, 2, 3}, {4, 5, 6} }, { { 7, 8, 9}, {10, 11, 12} } };

            Console.WriteLine(numbers2[0, 0, 0]);
            Console.WriteLine(numbers2[1, 1, 0]);

            //Kode : List
            //Digunakan untuk menyimpan kumpulan elemen atau objek dalam urutan tertentu.
            var names1 = new List<string> {"Game", "Mobile", "Web"};
            for (int i = 0; i < names1.Count; i++)
            {
                Console.WriteLine(names1[i] + " ");
            }

            // Kode : If Else
            //Digunakan untuk pengambilan keputusan berdasarkan kondisi tertentu.

            int b = 10;

            if (b < 20)
            {
                Console.WriteLine("Benar");
            }

            else
            {
                Console.WriteLine("Salah");
            }

            //Kode : Switch
            //Digunakan untuk membuat keputusan berdasarkan ekspresi yang berbeda.
            int nilai = 75;
            switch (nilai)
            {
                case > 80:
                    Console.WriteLine ("Baik");
                    break;
                case >= 75:
                    Console.WriteLine ("Cukup");
                    break;
                default:
                    Console.WriteLine ("Kurang");
                    break;
            }

            //Kode : Ternary Operator
            //Digunakan untuk mengevaluasi ekspresi berdasarkan kondisi tertentu.
            int angka1 = 10;
            string hasilAngka1 = (angka1 % 2 == 0) ? "Genap" : "Ganjil";

            Console.WriteLine (hasilAngka1);

            //Kode : Perulangan - For
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine ("Perulangan for ke " + z);
            }

            //Kode : Perulangan - While
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("Perulangan while ke " + x);
                x++;
            }

            //Kode : Perulangan - Do While
            int y = 0;
            do
            {
                Console.WriteLine("Perulangan do while ke " + y);
                y++;
            } while (y < 5);

            //Kode : Perulangan - Foreach
            int s = 0;
            int[] angkaS = new int[5] {1, 2, 3, 4, 5};
            foreach (int h in angkaS)
            {
                Console.WriteLine ("Isi array urut dari indeks ke " + s++ + " yaitu " + h);
            }

            //Kode : Break
            //Pernyataan yang biasa digunakan dalam loop (for, while, atau do while) atau dalam struktur switch untuk menghentikan eksekusi loop atau keluar dari struktur switch.
            for (int g = 0; g < 10; g++)
            {
                Console.WriteLine ("Perulangan ke " + g);

                if (g == 5)
                {
                    break;
                }
            }

            //Kode : Continue
            //Pernyataan yang digunakan dalam loop untuk melanjutkan ke iterasi berikutnya tanpa menjalankan kode di bawahnya dalam iterasi saat ini.
            for (int k = 0; k < 10; k++)
            {
                if (k % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(k);
            }

            Screen();
        }

        //Function adalah blok kode yang digunakan untuk menjalankan tugas tertentu.
        public static void Screen()
        {
            Tampil();
        }

        public static void Tampil()
        {
            Console.WriteLine("Game");
        }
    }
}