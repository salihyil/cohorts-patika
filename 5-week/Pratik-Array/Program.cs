namespace Pratik_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.
             1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
             2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
             3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
             4 - Bu diziyi büyükten küçüğe ekrana yazdırınız. */

            int[] numbers = new int[10];

            Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Diziyi foreach ile yazdırma
            Console.WriteLine("\nGirdiğiniz sayılar:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // 3. Adım: 11. elemanı ekleme
            Array.Resize(ref numbers, 11);
            Console.Write("\n\nLütfen 11. sayıyı giriniz: ");
            numbers[numbers.Length - 1] = Convert.ToInt32(Console.ReadLine());

            // 4. Adım: Diziyi büyükten küçüğe sıralama ve yazdırma
            Console.WriteLine("\nSayılar büyükten küçüğe sıralanmış hali:");
            // 0. yöntem: LINQ ile sıralama
            int[] sortedNumbers = numbers.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ", sortedNumbers));

            // 1. Yöntem: Array.Sort ve Array.Reverse ile sıralama
            /* Array.Sort(numbers);
            Array.Reverse(numbers);
            */

            // 2. Yöntem: Bubble sort ile büyükten küçüğe sıralama
            /* for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        // Swap işlemi
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            } */

            // 3. Yöntem: Selection sort ile büyükten küçüğe sıralama   
            /* for (int i = 0; i < numbers.Length - 1; i++)
            {
                int enBuyukIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[enBuyukIndex])
                    {
                        enBuyukIndex = j;
                    }
                }
                // Swap işlemi
                if (enBuyukIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[enBuyukIndex];
                    numbers[enBuyukIndex] = temp;
                }
            } */

            // 4. Yöntem: Insertion sort ile büyükten küçüğe sıralama
            /*  for (int i = 1; i < numbers.Length; i++)
             {
                 int deger = numbers[i];
                 int j = i - 1;

                 while (j >= 0 && numbers[j] < deger)
                 {
                     numbers[j + 1] = numbers[j];
                     j--;
                 }
                 numbers[j + 1] = deger;
             } */

            // Sıralanmış numbers diziyi yazdırma
            /*foreach (int number in numbers)
            {
                Console.Write(number + " ");
            } */

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}
