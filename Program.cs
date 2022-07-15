using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine("Tambah Data Mahasiswa\n\n");

            Mahasiswa mhs = new Mahasiswa()
            Console.WriteLine("NIM: ");
            mhs.Nim = Console.ReadLine();
            Console.WriteLine("Nama: ");
            mhs.Nim = Console.ReadLine();
            Console.WriteLine("Jenis Kelamin [L/P]: ");
            mhs.Nim = Console.ReadLine();
            Console.WriteLine("IPK: ");
            mhs.Nim = Console.ReadLine();

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(mhs3);
            list.Add(mhs4);

            for (int i=0; i<list.Count; i++)
            {
                Mahasiswa mhs = list[i];
                Console.WriteLine("{0}, {1}, {2}, {3}", mhs.Nim, mhs.Nama, mhs.jenisKelamin, mhs.Ipk);
            }
            
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "001";
            mhs1.Nama = "Anis";
            mhs1.jenisKelamin = "Laki-laki";
            mhs1.Ipk = "3.73";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "002";
            mhs2.Nama = "Septi";
            mhs2.jenisKelamin = "Perempuan";
            mhs2.Ipk = "3.5";

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "003";
            mhs3.Nama = "Abdul";
            mhs3.jenisKelamin = "Laki-laki";
            mhs3.Ipk = "3.83";

            Mahasiswa mhs4 = new Mahasiswa();
            mhs4.Nim = "004";
            mhs4.Nama = "Risa";
            mhs4.jenisKelamin = "Perempuan";
            mhs4.Ipk = "3.25";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(mhs3);
            list.Add(mhs4);

            for (int i = 0; i < list.Count; i++)
            {
                Mahasiswa mhs = list[i];
                Console.WriteLine("{0}, {1}, {2}, {3}", mhs.Nim, mhs.Nama, mhs.jenisKelamin, mhs.Ipk);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
