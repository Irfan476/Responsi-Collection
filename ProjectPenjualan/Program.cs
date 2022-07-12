using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

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
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
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
            Console.WriteLine("Pilih Menu Aplikasi\n\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan pjl = new Penjualan();

            Console.Write("Nota: ");
            pjl.Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            pjl.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            pjl.Nama = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            pjl.Cara = Console.ReadLine();
                if(pjl.Cara == "T")
                {
                    pjl.Cara = "Tunai";
                }
                else if(pjl.Cara == "K")
                {
                    pjl.Cara = "Kredit";
                }
            Console.Write("Total Nota: ");
            pjl.Jumlah = Console.ReadLine();

            daftarPenjualan.Add(pjl);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            foreach(Penjualan data in daftarPenjualan)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", data.Nota, data.Tanggal, data.Nama, data.Cara, data.Jumlah);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
