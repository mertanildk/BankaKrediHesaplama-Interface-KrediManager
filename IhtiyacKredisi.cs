using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    internal class IhtiyacKredisi : IKrediler
    {
        public string KrediAdi => "Ihtiyac Kredisi";

        public double FaizOrani
        {
            get
            {
                return 1.5;
            }

        }
        private int _vade;
        public int Vade
        {
            get { return _vade; }
            set
            {
                _vade = value;

                if (value > 36)
                {
                    _vade = 36;

                }
                else if (value <= 0)
                {
                    _vade = 3;
                }
            }
        }

        private int _tutar;
        public int Tutar
        {
            get { return _tutar; }
            set
            {
                _tutar = value;

                if (value<=950)
                {
                    _tutar = 950;
                    
                    Console.WriteLine("En az 950 TL kredi çekebilirsiniz");
                }
                else if(value> 1000000)
                {
                    _tutar = 1000000;
                    Console.WriteLine("En fazla 1.000.000 TL kredi çekebilirsiniz");
                }
            }
        }

        public double FaizliTutar { get; set; }

    }
}
