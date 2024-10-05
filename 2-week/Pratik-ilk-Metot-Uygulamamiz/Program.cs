using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_ilk_Metot_Uygulamamiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Pratik - İlk Metot Uygulamamız
            Aynı uygulama içerisinde 4 adet metot tanımlamanız ve çağırmanız isteniyor :
            1-Geriye Değer Döndürmeyen Bir void metot.
            Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
            
            2-Geriye Tamsayı Döndüren Bir metot
            Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

            3-Parametre Alan ve Geriye Değer Döndüren Bir Metot
            Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

            4-Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
            Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana basın.
             */

            #region 1.aşama
            PrintFavoriteLyrics();
            #endregion

            Console.WriteLine("\n****************************************************\n");

            #region 2.aşama
            int number = GetRandomNumberModTwo();
            Console.WriteLine($"Rastgele üretilen sayının 2'ye bölümünden kalan : {number}");
            #endregion

            Console.WriteLine("\n****************************************************\n");

            #region 3.aşama
            int value1 = 2;
            int value2 = 3;
            int number1 = MultiplyTwoNumbers(value1, value2);
            Console.WriteLine($" {value1} ve {value2} sayılarının çarpımı : {number1}");
            #endregion

            Console.WriteLine("\n****************************************************\n");

            #region 4.aşama
            string name = "Salih";
            string surname = "Yılmaz";
            PrintWelcomeMessage(name, surname);
            #endregion

            Console.ReadKey();
        }

        static void PrintFavoriteLyrics()
        {
            Console.WriteLine("Favori şarkı sözüm. ");
        }

        static int GetRandomNumberModTwo()
        {
            Random random = new Random();
            int randomNumber = random.Next();
            Console.WriteLine($"Rastgele üretilen sayı : {randomNumber}");
            return randomNumber % 2;
        }

        static int MultiplyTwoNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        static void PrintWelcomeMessage(string name, string surname)
        {
            Console.WriteLine($"Hoş Geldiniz {name} {surname} ");
        }

    }
}
