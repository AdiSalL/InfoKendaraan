using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Kendaraan : IKendaraan 
    {
       public string Nama { get; set; }
        public  bool Hidup { get; set; }
        public  int Tahun { get; set; }
        public int Kecepatan { get; set; }

        public Kendaraan(string nama, int tahun)
        {
            Nama = nama;
            Tahun = tahun;
            Hidup = false; 
            Kecepatan = 0; 
        }

        public virtual void Akselerasi(int waktu)
        {
            if(Hidup)
            {
                for(int i = 0; i < waktu; i++)
                {
                    Kecepatan += 10;
                    Console.WriteLine($"Kecepatan kendaraan {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Kendaraan {Nama} telah berakselerasi selama {waktu} menit.");
            }else {
                Console.WriteLine($"Kendaraan {Nama} tidak dapat berakselerasi karena dalam kondisi mati."); 
            }

        }

        public virtual void Rem( int waktu)
        {
            if (Hidup)
            {
                for (int i = 0; i < waktu; i++)
                {
                    Kecepatan -= 5;
                    if (Kecepatan < 0) Kecepatan = 0;
                    Console.WriteLine($"Kecepatan kendaraan {Nama} sekarang adalah {Kecepatan} km/jam.");
                }
                Console.WriteLine($"Kendaraan {Nama} telah berakselerasi selama {waktu} menit.");
            }
            else
            {
                Console.WriteLine($"Kendaraan {Nama} tidak dapat berakselerasi karena dalam kondisi mati.");
            }
        }

        public void Hidupkan()
        {
            Hidup = true;
            Console.WriteLine($"Kendaraan {Nama} telah dihidupkan brum...brum.");
        }

        public void Matikan()
        {
            Hidup = false;
            Console.WriteLine($"Kendaraan {Nama} mati.");
        }

        void IKendaraan.CekInformasi()
        {
            Console.WriteLine($"Nama Kendaraan: {Nama}");
            Console.WriteLine($"Tahun Pembuatan: {Tahun}");
            Console.WriteLine($"Kondisi Hidup: {(Hidup ? "Hidup" : "Mati")}");
            Console.WriteLine($"Kecepatan Saat Ini: {Kecepatan} km/jam");
        }

   

    }
}
