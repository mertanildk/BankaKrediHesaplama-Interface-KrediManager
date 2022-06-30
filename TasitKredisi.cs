using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    internal class TasitKredisi : IKrediler
    {
        private int _vade, _tutar;
        public string KrediAdi => "Tasit Kredisi";

        public int Tutar
        {
            get { return _tutar; }

            set
            {
                _tutar = value;

                if (value < 5000)
                {
                    _tutar = 5000;
                    Console.WriteLine("Minimum 5000 TL");
                }
                else if (value > 2000000)
                {
                    _tutar = 2000000;
                    Console.WriteLine("Maximum 2.000.000 TL");
                }
            }
        }

        public double FaizOrani => 2.1;
        public int Vade
        {
            get { return _vade; }
            set
            {
                _vade = value;

                if (value>48)
                {
                    _vade = 48;
                    Console.WriteLine("En fazla 48 ay vadeli kredi çekebilirsiniz");

                }
                else if (value<3)
                {
                    _vade = 3;
                    Console.WriteLine("Minimum 3 vadeli kredi çekebilirsiniz");
                }
               
            }
        }
        public double FaizliTutar { get; set; }


    }
}
