using System;

namespace Pratik_Kim_Milyoner_Olmak_İster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;

            // Question 1
            Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
            Console.WriteLine("a) Lama b) Deve");
            Console.Write("Cevap: ");
            string answer1 = Console.ReadLine().ToLower();
            if (answer1 == "a")

            {
                correctAnswers++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }
            Console.WriteLine();

            // Question 2
            Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
            Console.WriteLine("a) Venüs b) Mars");
            Console.Write("Cevap: ");
            string answer2 = Console.ReadLine().ToLower();
            if (answer2 == "a")
            {
                correctAnswers++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }
            Console.WriteLine();

            // Question 3 (asked if first answer is correct)
            if (correctAnswers == 1)
            {
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
                Console.WriteLine("a) 7 b) 12");
                Console.Write("Cevap: ");
                string answer3 = Console.ReadLine().ToLower();
                if (answer3 == "b")
                {
                    correctAnswers++;
                    Console.WriteLine("Doğru cevap!");
                }
                else
                {
                    Console.WriteLine("Yanlış cevap!");
                }
            }
            Console.WriteLine();

            // Final result
            if (correctAnswers >= 2)
            {
                Console.WriteLine("Tebrikler, 1 Milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
            }

            Console.ReadKey();
        }
    }
}
