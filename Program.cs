using System;

namespace BankaKrediHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hataSayisi = 0;
            while (hataSayisi!=3)
            {
                Menu();

                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                Console.WriteLine();

                KrediManager krediManager = new KrediManager();

                switch (secim)
                {
                    case "1":
                        krediManager.KrediCek(new IhtiyacKredisi());
                        break;
                    case "2":
                        krediManager.KrediCek(new TasitKredisi());
                        break;
                    case "3":
                        krediManager.KrediCek(new KonutKredisi());
                        break;
                    case "4":
                        krediManager.KrediCek(new EgitimKredisi());
                        break;
                        case "5":
                        Console.WriteLine("Çıkış Yapıldı İyi Günler.");
                        Environment.Exit(0);
                        break;
                    default:
                        hataSayisi++;
                        if (hataSayisi==3)
                        {
                            Console.WriteLine("size kredi mredi yok.".ToUpper());
                            Environment.Exit(0);
                        }
                        Console.WriteLine("Lütfen listedeki seçeneklerden birini tuşlayınız...");
                        Console.WriteLine();
                        continue;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("1-İhtiyaç Kredisi: ");
            Console.WriteLine("2-Taşıt Kredisi");
            Console.WriteLine("3-Konut Kredisi");
            Console.WriteLine("4-Eğitim Kredisi: ");
            Console.WriteLine("5-Çıkmak için 5'e basınız.");

            Console.WriteLine();
        }

    }
}
