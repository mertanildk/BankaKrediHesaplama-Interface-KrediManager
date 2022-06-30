using System;
namespace BankaKrediHesaplama
{
    class KrediManager
    {
        public void KrediCek(IKrediler krediAdi)
        {
            Console.Write("Çekmek istedinizi tutar: ");
            krediAdi.Tutar = int.Parse(Console.ReadLine());

             
            Console.Write("Vade sürenizi giriniz: ");
            krediAdi.Vade = int.Parse(Console.ReadLine());
            
            krediAdi.FaizliTutar = krediAdi.Tutar + ((krediAdi.Tutar * krediAdi.Vade * krediAdi.FaizOrani) / 100);
            Console.WriteLine();
            Console.Write("-- --Kredi sonucunuz hesaplandı----- \n\nGeri ödenecek tutar:  "+Math.Round(krediAdi.FaizliTutar, 2));
            
            Aciklama(krediAdi);

        }

        public void Aciklama(IKrediler krediAdi)
        {
            Console.WriteLine();
            Console.WriteLine("Aylık ödeme tutarınız: " + Math.Round((krediAdi.FaizliTutar / krediAdi.Vade)), 2);
            Console.WriteLine();
        }
    }
}

