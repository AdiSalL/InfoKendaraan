using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface IKendaraan
    {
        string Nama { get; set; }
        bool Hidup { get; set; }
        int Tahun { get; set; }
        int Kecepatan { get; set; }
            
        void Hidupkan();
        
        void Matikan();
        void Akselerasi( int waktu);
        void Rem( int waktu);
        void CekInformasi();
    }

   
}
