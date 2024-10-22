namespace Pratik_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pratik - Abstraction
            Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.
            Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır
            Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).
            Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.
            Örneğin
            Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında
            " Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.
            */

            Employee personel = new SoftwareDeveloper("Hasan", "Çıldırmış", "Yazılım Geliştirme");
            personel.ShowInfo();
            personel.Task();

            Console.WriteLine("--------------------------------");

            Employee personel2 = new ProjectManager("Ahmet", "Yılmaz", "Proje Yönetimi");
            personel2.ShowInfo();
            personel2.Task();

            Console.WriteLine("--------------------------------");

            Employee personel3 = new SalesRepresentative("Ayşe", "Kara", "Satış");
            personel3.ShowInfo();
            personel3.Task();

            Console.ReadKey();
        }
    }
}
