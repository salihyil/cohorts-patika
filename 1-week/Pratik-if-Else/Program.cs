using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            int numberToCompare = 10;

            while (!isValidInput)
            {
                Console.Write("Lütfen bir tamsayı giriniz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    isValidInput = true;

                    // 10 ile karşılaştırma
                    if (number == numberToCompare)
                    {
                        Console.WriteLine("Girilen sayı 10'a eşittir.");
                    }
                    else if (number < numberToCompare)
                    {
                        Console.WriteLine("Girilen sayı 10'dan küçüktür.");
                    }
                    else
                    {
                        Console.WriteLine("Girilen sayı 10'dan büyüktür.");
                    }

                    // Çift mi tek mi kontrolü
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Girilen sayı çifttir.");
                    }
                    else
                    {
                        Console.WriteLine("Girilen sayı tektir.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir tamsayı girmediniz. Lütfen tekrar deneyin.");
                }
            }

            Console.ReadLine(); // Konsol penceresinin kapanmaması için
        }
    }
}
