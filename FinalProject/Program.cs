using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lalu lintas hari ini....");
            Kendaraan[] kendaraan = new Kendaraan[4];
            kendaraan[0] = new Mobil("Mobil Merah", 2020);
            kendaraan[1] = new Motor("Motor Biru", 2019);
            kendaraan[2] = new Bemo("Bemo Kuning", 2018);
            kendaraan[3] = new Mobil("Mobil Hijau", 2021);
            foreach (var k in kendaraan)
            {
                k.Hidupkan();
                k.Akselerasi(3);
                k.Rem(2);
                Console.WriteLine($"Kendaraan {k.Nama} beroperasi pada tahun {k.Tahun} dengan kecepatan akhir {k.Kecepatan} km/jam.\n");
            }
            Console.WriteLine("Lalu lintas hari ini selesai.");
            Console.WriteLine("Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
