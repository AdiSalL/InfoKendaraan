using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Bemo : Kendaraan
    {
        public Bemo(string nama, int tahun) : base(nama, tahun)
        {
        }

        public override void Akselerasi(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan += 12;
                    Console.WriteLine($"Kecepatan bemo {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Bemo {Nama} telah berakselerasi selama {waktu} detik.");
            }
            else
            {
                Console.WriteLine($"Bemo {Nama} tidak dapat berakselerasi karena dalam kondisi mati.");
            }
        }

        public override void Rem(int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan -= 6; 
                    if (Kecepatan < 0) Kecepatan = 0; // Pastikan kecepatan tidak negatif
                    Console.WriteLine($"Kecepatan bemo {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Bemo {Nama} telah direm selama {waktu} detik.");
            }
            else
            {
                Console.WriteLine($"Bemo {Nama} tidak dapat direm karena dalam kondisi mati.");
            }
        }
    }
}
