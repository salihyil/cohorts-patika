namespace Pratik_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.
            Bebek sınıfının propertyleri -> Doğum Tarihi , Ad , Soyad 
            Bebek sınıfı için 2 adet constructor tanımlayınız.
            - 1.si Default Constructor tarzında parametre almayan bir metot.
            - 2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
            - 2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.
            Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız. */

            Bebek bebek1 = new Bebek();
            bebek1.Name = "Ayşe";
            bebek1.Surname = "Yılmaz";
            Console.WriteLine($"{bebek1.Name} {bebek1.Surname} {bebek1.BirthDate} doğdu.");

            Console.WriteLine("\n--------------------------------------------------\n");

            Bebek bebek2 = new Bebek("Murat", "Kaya");
            Console.WriteLine($"{bebek2.Name} {bebek2.Surname} {bebek2.BirthDate} doğdu.");

            Console.ReadKey();
        }
    }
}
