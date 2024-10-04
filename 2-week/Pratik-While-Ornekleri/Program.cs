using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_While_Ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string devider = "\n\n-------------------------------------------------------------\n";
            /* 
            Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.
            1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            */

            #region 1. aşama
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i}- Kendime inanıyorum, ben bu yazılım işini hallederim.");
                i++;
            }
            #endregion
            Console.WriteLine(devider);

            #region 2. aşama
            int number1 = 1;
            while (number1 <= 20)
            {
                Console.Write($"{number1}{(number1 != 20 ? ", " : "")}");
                number1++;
            }
            #endregion
            Console.WriteLine(devider);

            #region 3. aşama
            int number2 = 1;
            while (number2 <= 20)
            {
                if (number2 % 2 == 0)
                {
                    Console.Write($"{number2}{(number2 != 20 ? ", " : "")}");
                }
                number2++;
            }
            #endregion
            Console.WriteLine(devider);

            #region 4. aşama
            int number4 = 50;
            int sum = 0;
            while (number4 <= 150)
            {
                sum += number4;
                number4++;
            }
            #endregion
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}");
            Console.WriteLine(devider);

            #region 5. aşama
            int number5 = 1;
            int oddSum = 0;
            int evenSum = 0;
            while (number5 <= 120)
            {
                if (number5 % 2 == 0)
                {
                    evenSum += number5;
                }
                else
                {
                    oddSum += number5;
                }
                number5++;
            }
            #endregion
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");
            Console.WriteLine(devider);


            Console.ReadKey();
        }
    }
}
