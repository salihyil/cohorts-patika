﻿namespace Pratik_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bu örnekte sizlerden bir Base Sınıf oluşturmanız isteniyor. İsmi -> BaseKisi
            BaseKisi için propertyler -> Ad, Soyad
            BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.
            Ardından BaseKisi'den miras alacak Ogrenci ve Ogretmen sınıfları oluşturmanız gerekiyor.
            Ogrenci için ilave propertyler -> Öğrenci Numarası
            Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot
            Ogretmen için ilave propertyler -> Maaş Bilgisi
            Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
            Dikkat ->  Bir metot içerisinde başka bir metodu çağırabileceğinizi unutmayınız.
            Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atayınız. Ardından değerleri konsol ekranına yazdırınız. */

            Student student = new Student("Hüseyin", "Kılıç", 123456);
            student.PrintInfo();

            Console.WriteLine("--------------------------------");

            Teacher teacher = new Teacher("Jane", "Doe", 5000);
            teacher.PrintInfo();


            Console.ReadKey();
        }
    }
}
