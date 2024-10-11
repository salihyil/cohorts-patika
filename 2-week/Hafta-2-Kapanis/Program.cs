using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bu pratikte sizden aşağıdaki soruların cevaplarını tek bir kod sayfası olarak yüklemeniz isteniyor. Çözümleri ayrı ayrı yapıp test edip yorum satırı olarak bir sayfaya kopyalayıp yapıştırabilirsiniz. Bu uygulamanın çözümleri Live-Class'ta yapılacak. Örnekler Hafta 1 ve Hafta 2 'nin konularını bir arada içeriyor.
            1 - Aşağıdaki çıktıyı yazan bir program.
            Merhaba
            Nasılsın ?
            İyiyim
            Sen nasılsın ?
            2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiren uygulamayı yazınız.
            8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
            15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak. */

            /* #region 1. soru
            Console.WriteLine("Merhaba");
            Console.WriteLine("Nasılsın ?");
            Console.WriteLine("İyiyim");
            Console.WriteLine("Sen nasılsın ?");

            //2.yol 
            //Console.WriteLine(@"
            //    Merhaba
            //    Nasılsın ? 
            //    İyiyim
            //    Sen nasılsın? ");

            #endregion */


            /* #region 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            string name = "Salih";
            int age = 20;   
            Console.WriteLine("Adım: " + name + " Yaşım: " + age);
            #endregion */

            /* #region 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Random random = new Random();
            int randomNumber = random.Next();
            Console.WriteLine($"Rastgele sayı: {randomNumber}");
            #endregion   */

            /* #region 4- Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Random random = new Random();
            int randomNumber = random.Next();
            int remainder = randomNumber % 3;
            Console.WriteLine($"Random üretilen {randomNumber} sayısının 3'e bölümünden kalanı: {remainder} ");
            #endregion */

            /* #region 5- Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            Console.Write("Yaşını gir: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
            #endregion */

            /* #region 6- Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
            #endregion */

            /* #region 7- Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            Console.Write("Metinsel birinci değeri gir: ");
            string text1 = Console.ReadLine();
            Console.Write("Metinsel ikinci değeri gir: ");
            string text2 = Console.ReadLine();
            string temp = text1;
            text1 = text2;
            text2 = temp;
            ChangeTextPosition(text1, text2);
            #endregion */

            /* #region 8- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            BenDegerDondurmem();
            #endregion */

            /* #region 9- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            Console.Write("1. sayıyı gir: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gir: ");
            int number2 = int.Parse(Console.ReadLine());
            int result = Sum(number1, number2);
            Console.WriteLine($"{number1} ile {number2} toplamı: {result}");
            #endregion */

            /* #region 10- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            Console.Write("Değer gir: ");
            bool result = long.TryParse(Console.ReadLine(), out long number);
            string type = PrintType(result ,number);
            Console.WriteLine(type);
            #endregion */

            /* #region 11- 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            Console.Write("1. kişinin yaşı girin: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. kişinin yaşı girin: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. kişinin yaşı girin: ");
            int age3 = Convert.ToInt32(Console.ReadLine());

            int oldest = GetOldestAge(age1, age2, age3);
            Console.WriteLine($"{age1}-{age2}-{age3} bu yaşlar arasından en yaşlısı: {oldest}");

            // 2.yol
            int oldest = FindOldestAge(age1, age2, age3);
            Console.WriteLine($"{age1}-{age2}-{age3} bu yaşlar arasından en yaşlısı: {oldest}");
            #endregion */

            /* #region 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            int maxNumber = GetMaxNumber();
            Console.WriteLine($"En büyük sayı: {maxNumber}");

            // 2.yol
            int maxNumber = EnBuyugu();
            Console.WriteLine($"En büyük sayı: {maxNumber}");
            #endregion */

            /* #region 13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            Console.Write("İlk ismi girin: ");
            string name1 = Console.ReadLine();
            Console.Write("İkinci ismi girin: ");
            string name2 = Console.ReadLine();

            SwapNames(ref name1, ref name2);
            Console.WriteLine($"Değiştirildikten sonra: {name1}, {name2}");
            #endregion */

            /* #region 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
            Console.Write("Sayi giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = IsNumberEvenOrOdd(number);
            if (result)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            #endregion */

            /* #region 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            // x = v * t
            Console.Write("Hızını gir: (km/h) ");
            double velocity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zamanı gir: (h) ");
            double time = Convert.ToDouble(Console.ReadLine());

            double displacement = CalculateDisplacement(velocity, time);
            Console.Write($"Gidilen yol (km) : {displacement}");
            #endregion */

            /* #region 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            Console.Write("Yarıçapı gir: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = CalculateCircleArea(radius);
            Console.Write($"Dairenin alanı: {area}");
            #endregion */

            /* #region 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            string text = "Zaman bir GeRi SayIm";
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            #endregion */

            //#region 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            //string text = "    Selamlar   ";
            //Trim(ref text);
            //Console.WriteLine(text);
            //#endregion
            Console.WriteLine("En büyük sayı: " + EnBuyugu());

            Console.ReadKey();
        }

        static void ChangeTextPosition(string text1, string text2)
        {
            Console.Write($"{text2}, {text1}");
        }
        static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
        }
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        static string PrintType(bool result, long number)
        {
            if (result)
            {
                return $"Girdiğin {number} değeri sayıdır";
            }
            else
            {
                return "Girdiğin değer sayı değildir";
            }
        }
        static int GetOldestAge(int age1, int age2, int age3)
        {
            if (age1 > age2 && age1 > age3)
                return age1;
            else if (age2 > age3)
                return age2;
            else
                return age3;
        }
        static int EnYasliyiBul(int age1, int age2, int age3)
        {
            return Math.Max(age1, Math.Max(age2, age3));
        }
        static int FindOldestAge(int age1, int age2, int age3)
        {
            int oldest = age1;
            if (age2 > oldest) oldest = age2;
            if (age3 > oldest) oldest = age3;
            return oldest;
        }
        static int GetMaxNumber()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Bir sayı girin (Çıkmak için 'q' yazın): ");
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);

                if (input.ToLower() == "q")
                    break;
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin veya çıkmak için 'q' yazın.");
                }


                if (isNumber)
                {
                    numbers.Add(number);
                }


                if (numbers.Count == 0)
                {
                    Console.WriteLine("Hiç sayı girilmedi.");
                    return 0;
                }
            }
            int max = numbers.Max();
            return max;
        }

        static int EnBuyugu()
        {
            int enBuyuk = int.MinValue;
            int sayac = 1;
            bool sonuc;

            while (true)
            {
                Console.Write($"{sayac++}. sayı girin (Çıkmak için 'q' yazın): ");
                string cevap = Console.ReadLine();
                sonuc = int.TryParse(cevap, out int sayi);

                if (cevap.ToLower() == "q")
                    break;

                if (sonuc)
                {
                    enBuyuk = Math.Max(enBuyuk, sayi);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin veya çıkmak için 'q' yazın.");
                    sayac = 1;
                }
            }
            return enBuyuk;

        }

        static void SwapNames(ref string name1, ref string name2)
        {
            string temp = name1;
            name1 = name2;
            name2 = temp;
        }
        static bool IsNumberEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static double CalculateDisplacement(double velocity, double time)
        {
            return velocity * time;
        }
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Trim(ref string text)
        {
            text = text.Trim();
        }
    }
}
