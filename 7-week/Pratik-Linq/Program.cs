namespace Pratik_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [22, 11, 5, 6, 7, -11, -5, -20, 15, 16, 20, 654987, 9874562, 244, 466, 755, 0];

            //çift sayılar
            List<int> ciftSayilar = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Çift sayılar: " + string.Join(", ", ciftSayilar));

            //tek sayılar
            List<int> tekSayilar = numbers.Where(x => x % 2 == 1).ToList();
            Console.WriteLine("Tek sayılar: " + string.Join(", ", tekSayilar));

            //negatif sayılar
            List<int> negativeNumbers = numbers.Where(x => x < 0).ToList();
            Console.WriteLine("Negatif sayılar: " + string.Join(", ", negativeNumbers));

            //pozitif sayılar
            List<int> positiveNumbers = numbers.Where(x => x > 0).ToList();
            Console.WriteLine("Pozitif sayılar: " + string.Join(", ", positiveNumbers));

            //15'ten büyük ve 22'den küçük sayılar
            List<int> between15And22 = numbers.Where(x => x > 15 && x < 22).ToList();
            if (between15And22.Count > 0)
            {
                Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", between15And22));
            }
            else
            {
                Console.WriteLine("15'ten büyük ve 22'den küçük sayılar yoktur.");
            }

            //Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)
            List<int> numbers1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            List<int> squares = numbers1.Select(x => x * x).ToList();
            Console.WriteLine("Listedeki her bir sayının karesi: " + string.Join(", ", squares));


            Console.ReadKey();
        }
    }
}
