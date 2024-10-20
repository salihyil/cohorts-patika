namespace Pratik_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pratik - Encapsulation
            -Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.
            Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı
            Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.
            Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.
             */
            Car car1 = new Car("Mercedes", "C180", "Red", 2);
            car1.PrintCarInfo();

            Console.WriteLine("--------------------------------");

            Car car2 = new Car("Audi", "A3", "Black", 5);
            car2.PrintCarInfo();

            Console.WriteLine("--------------------------------");

            Car car3 = new Car("BMW", "320", "White", 3);
            car3.PrintCarInfo();

            Console.ReadKey();
        }
    }
}
