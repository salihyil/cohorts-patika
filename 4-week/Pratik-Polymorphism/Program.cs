namespace Pratik_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.
            Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.
            Kare/Square
            Dikdortgen/Rectangle
            DikUcgen/RightTriangle
            Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil/BaseGeometricShape classından türetebiliriz.
            BaseGeometrikSekil için Propertyler -> Genişlik/Width ve Yükseklik/Height
            AlanHesapla()/Area() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.
            Burada dikkat etmemiz gereken durum: Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplanan alanın Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak hesaplanması.
            Polymorphism prensibini kullanarak ilgili uygulamayı kodlayınız. Her classtan bir örnek nesne oluşturarak Alan ölçülerini konsol ekranına yazdırınız.
            */

            BaseGeometricShape square = new Square(5);
            BaseGeometricShape rectangle = new Rectangle(5, 10);
            BaseGeometricShape rightTriangle = new RightTriangle(5.5, 10.5);

            Console.WriteLine($"Kare Alanı: {square.Area()}");
            Console.WriteLine($"Dikdörtgen Alanı: {rectangle.Area()}");
            Console.WriteLine($"Dik Üçgen Alanı: {rightTriangle.Area()}");

            Console.ReadKey();
        }
    }
}
