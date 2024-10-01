using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_if_Else_ve_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch-case
            byte applePrice = 2, pearPrice = 3, strawberryPrice = 2, bananaPrice = 3, othersPrice = 4;
            Console.WriteLine("Rüya Manavına Hoşgeldiniz!");
            Console.WriteLine($"Elma: {applePrice} TL \nArmut: {pearPrice} TL\nÇilek: {strawberryPrice} TL\nMuz: {bananaPrice} TL\nDiğer bütün meyveler: {othersPrice} TL");
            Console.WriteLine();
            Console.Write("Hangi meyveyi almak istersiniz? (Elma, Armut, Muz, Çilek, Diğer): ");

            string secim = Console.ReadLine().ToLower();
            switch (secim)
            {
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {applePrice} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {pearPrice} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {bananaPrice} TL");
                    break;
                case "çilek":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {strawberryPrice} TL");
                    break;
                default:
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {othersPrice} TL");
                    break;
            }
            #endregion

            /*  #region if-else
             string apple = "elma", pear = "armut", banana = "muz", strawberry = "çilek";

             if (secim == apple)
             {
                 Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {applePrice} TL");
             }
             else if (secim == pear)
             {
                 Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {pearPrice} TL");
             }
             else if (secim == banana)
             {
                 Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {bananaPrice} TL");
             }
             else if (secim == strawberry)
             {
                 Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {strawberryPrice} TL");
             }
             else
             {
                 Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {othersPrice} TL");
             }
             #endregion
             */

            /* Bu tür bir problemi çözmek için switch-case yapısı daha uygundur. Nedenleri:

            1. Okunabilirlik: Switch-case yapısı, bu tür eşitlik karşılaştırmalarında daha temiz ve okunabilir bir kod sağlar.
            2. Performans: Çok sayıda eşitlik karşılaştırması yapılırken, switch-case yapısı genellikle if-else yapısından daha hızlı çalışır.
            3. Bakım kolaylığı: Yeni meyve eklenmesi gerektiğinde, switch-case yapısına yeni bir case eklemek daha kolay ve hata yapma olasılığı daha düşüktür.
            4. Amaç uygunluğu: Switch-case yapısı, tam olarak bu tür "değer eşleştirme" senaryoları için tasarlanmıştır.

            Ancak, karşılaştırmalar daha karmaşık olsaydı (örneğin, aralık kontrolleri veya çoklu koşullar), 
            if-else yapısı daha uygun olabilirdi. Bu örnekte, basit string eşitliği kontrolleri yaptığımız için 
            switch-case yapısı ideal seçimdir.
            */
            
            Console.ReadKey();
        }
    }
}
