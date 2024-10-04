using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Yol_Arkadasi_Tatil_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            int packageStartPriceForBodrum;
            int packageStartPriceForMarmaris;
            int packageStartPriceForCesme;

            // Geçerli lokasyonların listesini oluştur
            List<string> validLocations = new List<string> { "bodrum", "marmaris", "cesme" };
            string locations = string.Join(", ", validLocations);

            Console.Write($"Gitmek istediğiniz lokasyonun ismini giriniz ({locations}): ");
            string location = Console.ReadLine().ToLower();

            while (!validLocations.Contains(location))
            {
                Console.Write($"\nLütfen geçerli bir lokasyon ismi giriniz ({locations}): ");
                location = Console.ReadLine().ToLower();
            }

            Console.Write("\nKaç kişi için tatil planlamak istiyorsunuz: ");
            bool isPeopleCountValid = int.TryParse(Console.ReadLine(), out int peopleCount);

            // Kişi sayısının 0'dan küçük olamayacağını kontrol ediyoruz.   
            while (!isPeopleCountValid || peopleCount <= 0)
            {
                Console.Write("\nLütfen geçerli bir kişi sayısı giriniz: ");
                isPeopleCountValid = int.TryParse(Console.ReadLine(), out peopleCount);
            }

            string capitalizedLocation = char.ToUpper(location[0]) + location.Substring(1);

            //Ardından gitmek istenilen lokasyon ve o lokasyonda tatili sırasında yapabilecekleri ile ilgili bir özet bilgiyi ekrana yazdırmalıyız.
            Console.WriteLine($"\nGitmek istediğiniz lokasyon : {capitalizedLocation}");

            if (validLocations.Contains(location))
            {
                Console.WriteLine($"{capitalizedLocation} lokasyonunda doğa yürüyüşleri yapabilir, tarihi ve kültürel mekanları keşfedebilir, plajda dinlenebilir ve yerel lezzetlerin tadını çıkarabilirsiniz.");
            }

            Console.WriteLine("\nTatile ne şekilde gitmek istersiniz? (1 yada 2'ye basınız)");
            Console.WriteLine("1- Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
            Console.WriteLine("2- Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

            bool isTransportChoiceValid = int.TryParse(Console.ReadLine(), out int transportChoice);

            while (!isTransportChoiceValid || (transportChoice != 1 && transportChoice != 2))
            {
                Console.WriteLine("Lütfen geçerli bir seçim yapınız (1 yada 2'ye basınız)");
                isTransportChoiceValid = int.TryParse(Console.ReadLine(), out transportChoice);
            }
            Console.WriteLine();

            //Ardından gidilecek lokasyon, kişi sayısı ve ulaşım aracı seçenekleriyle bir toplam fiyat hesaplayıp bunu kullanıcıya sunalım.
            if (location == "bodrum")
            {
                packageStartPriceForBodrum = 4000;
                switch (transportChoice)
                {
                    case 1:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForBodrum + (peopleCount * 1500)} TL");
                        break;
                    case 2:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForBodrum + (peopleCount * 4000)} TL");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız.");
                        break;
                }

            }
            else if (location == "marmaris")
            {
                packageStartPriceForMarmaris = 3000;
                switch (transportChoice)
                {
                    case 1:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForMarmaris + (peopleCount * 1500)} TL");
                        break;
                    case 2:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForMarmaris + (peopleCount * 4000)} TL");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız.");
                        break;
                }
            }
            else if (location == "cesme")
            {
                packageStartPriceForCesme = 5000;
                switch (transportChoice)
                {
                    case 1:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForCesme + (peopleCount * 1500)} TL");
                        break;
                    case 2:
                        Console.WriteLine($"Toplam fiyat: {packageStartPriceForCesme + (peopleCount * 4000)} TL");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız.");
                        break;
                }
            }

            //Kullanıcıya başka bir tatil planlamak isteyip istemediğini soralım, istiyorsa uygulama ilk aşamadan çalışmaya başlayabilir, kullanıcı istemiyorsa iyi günler dileyerek uygulamayı sonlandırabiliriz. 
            Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string continueChoice = Console.ReadLine().ToLower();

            while (continueChoice != "evet" && continueChoice != "hayır")
            {
                Console.WriteLine("Lütfen geçerli bir seçim yapınız (Evet/Hayır)");
                continueChoice = Console.ReadLine().ToLower();
            }

            if (continueChoice == "evet")
            {
                Console.Clear();
                goto Start;
            }
            else
            {
                Console.WriteLine("İyi günler dileriz...");
            }

            Console.WriteLine("\nÇıkış için bir tuşa basınız...");
            Console.ReadKey();

        }
    }
}
