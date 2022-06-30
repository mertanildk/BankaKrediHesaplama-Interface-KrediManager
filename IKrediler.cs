using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    interface IKrediler
    {
        public string KrediAdi { get; }
        public int Tutar { get; set; }
        public double FaizOrani { get; }  
        public int Vade { get; set; }
        public double FaizliTutar { get; set; }
       
    }
}
