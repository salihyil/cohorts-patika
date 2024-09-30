using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Degiskenler_ile_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");
            long idNumber;


            while (true)
            {
                Console.Write("T.C. Kimlik Numarasi (11 haneli sayi): ");
                string input = Console.ReadLine();

                if (long.TryParse(input, out idNumber) && input.Length == 11)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hata: TC kimlik numarasi 11 haneli bir sayi olmalidir. Lutfen tekrar deneyin.");
                }
            }

            Console.Write("Adi: ");
            string name = Console.ReadLine();
            Console.Write("Soyadi: ");
            string lastName = Console.ReadLine();
            Console.Write("Telefon Numarasi: ");
            string phoneNumber = Console.ReadLine(); // Telefon numarası için string kullanıldı, çünkü telefon numaraları sayısal işlemler gerektirmediği için metin olarak saklanmalıdır.
            
            Console.Write("Yas: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("İlk aldigi urunun fiyati: ");
            decimal firstProductPrice = decimal.Parse(Console.ReadLine()); // Ürün fiyatları için decimal kullanıldı, çünkü fiyatlar ondalıklı sayılar olabilir.
            Console.Write("İkinci aldigi urunun fiyati: ");
            decimal secondProductPrice = decimal.Parse(Console.ReadLine()); // Ürün fiyatları için decimal kullanıldı, çünkü fiyatlar ondalıklı sayılar olabilir.

            int discountPercentage = 10;
            decimal totalPrice = firstProductPrice + secondProductPrice;
            decimal patikaPoint = (firstProductPrice + secondProductPrice) * 10 / 100;

            Console.WriteLine("--------------------");
            Console.WriteLine($"{idNumber} Tc numarali {name} {lastName} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{phoneNumber} numarasina bildirim mesaji gonderilmistir.");
            Console.WriteLine($"{totalPrice} toplam harcama karsiligi kazanilan {discountPercentage}% patika puan miktarı -> {patikaPoint} TL'dir.");
            Console.ReadLine();

        }
    }
}
