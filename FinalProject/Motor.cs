using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Motor : Kendaraan
    {
        public Motor(string nama, int tahun) : base(nama, tahun)
        {
        }

        public override void Akselerasi(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan += 15; // Motor biasanya lebih cepat dalam akselerasi
                    Console.WriteLine($"Kecepatan motor {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Motor {Nama} telah berakselerasi selama {waktu} menit.");
            }
            else
            {
                Console.WriteLine($"Motor {Nama} tidak dapat berakselerasi karena dalam kondisi mati.");
            }
        }

        public override void Rem(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan -= 7; // Motor biasanya lebih lambat dalam pengereman
                    if (Kecepatan < 0) Kecepatan = 0; // Pastikan kecepatan tidak negatif
                    Console.WriteLine($"Kecepatan motor {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Motor {Nama} telah direm selama {waktu} menit.");
            }
            else
            {
                Console.WriteLine($"Motor {Nama} tidak dapat direm karena dalam kondisi mati.");
            }
        }
    }
}
