using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_While_vs_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.
            Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
            ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )
            Örnek inputlar : 10 ve -5
            Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz. */

            #region while
            Console.Write("Lütfen bir limit değer giriniz: ");
            int limitValue = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (counter <= limitValue)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter++;
            }
            #endregion

            Console.WriteLine("\n----------------------------------\n");

            #region do-while
            Console.Write("Lütfen bir limit değer giriniz: ");
            int limitValue2 = Convert.ToInt32(Console.ReadLine());
            int counter2 = 0;
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter2++;
            } while (counter2 <= limitValue2);
            #endregion

            // while ve do-while döngülerinin farkı:
            // 'while' döngüsü, döngü gövdesini çalıştırmadan önce koşulu kontrol eder,
            // bu da başlangıçta koşul yanlışsa, döngü gövdesinin hiç çalışmayacağı anlamına gelir.
            // Öte yandan, 'do-while' döngüsü, döngü gövdesini bir kez çalıştırdıktan sonra koşulu kontrol eder,
            // bu da koşul doğru veya yanlış olsa bile döngü gövdesinin en az bir kez çalıştırılmasını garanti eder.

            Console.ReadKey();
        }
    }
}
