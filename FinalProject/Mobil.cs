using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Mobil : Kendaraan
    {
        public Mobil(string nama, int tahun) : base(nama, tahun)
        {
        }

        public override void Akselerasi(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan += 20; // Mobil biasanya lebih cepat dalam akselerasi
                    Console.WriteLine($"Kecepatan mobil {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Mobil {Nama} telah berakselerasi selama {waktu} detik.");
            }
            else
            {
                Console.WriteLine($"Mobil {Nama} tidak dapat berakselerasi karena dalam kondisi mati.");
            }
        }

        public override void Rem(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan -= 10; // Mobil biasanya lebih lambat dalam pengereman
                    if (Kecepatan < 0) Kecepatan = 0; // Pastikan kecepatan tidak negatif
                    Console.WriteLine($"Kecepatan mobil {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Mobil {Nama} telah direm selama {waktu} detik.");
            }
            else
            {
                Console.WriteLine($"Mobil {Nama} tidak dapat direm karena dalam kondisi mati.");
            }
        }
    }
}
