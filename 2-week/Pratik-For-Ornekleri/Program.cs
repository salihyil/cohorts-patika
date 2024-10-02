using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_For_Ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları for kullanarak yapınız.
            1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız
            2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. 
            */

            #region 1.aşama
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}- Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            #endregion
            Console.WriteLine("\n-------------------------------------------------------------\n");

            #region 2. aşama
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i == 20 ? $"{i}" : $"{i}, ");
            }
            #endregion
            Console.WriteLine("\n\n-------------------------------------------------------------\n");

            #region 3.aşama
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i == 20 ? $"{i}" : $"{i}, ");
                }
            }
            #endregion
            Console.WriteLine("\n\n-------------------------------------------------------------\n");

            #region 4.aşama
            int total = 0;
            for (int i = 50; i <= 150; i++)
            {
                total += i;
            }
            Console.Write("50 ile 150 arasındaki sayıların toplamı : " + total);
            #endregion
            Console.WriteLine("\n\n-------------------------------------------------------------\n");

            #region 5. aşama
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı: " + oddSum);
            Console.WriteLine("Çift sayıların toplamı: " + evenSum);
            #endregion

            Console.ReadKey();

        }
    }
}
