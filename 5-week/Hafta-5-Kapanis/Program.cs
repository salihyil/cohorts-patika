namespace Hafta_5_Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> arabalar = new List<Car>();
            string answer;
            
            do
            {
                Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
                answer = Console.ReadLine()?.ToLower();

                if (answer != "e" && answer != "h")
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen 'E' veya 'H' harflerinden birini giriniz.");
                }

            } while (answer != "e" && answer != "h");

            if (answer == "h")
            {
                Console.WriteLine("Program sonlandırılıyor...");
            }
            else
            {
                CreateCar:
                try
                {
                    Car car = new Car();
                    
                    Console.Write("Seri Numarası: ");
                    car.SerialNumber = Console.ReadLine();
                    
                    Console.Write("Marka: ");
                    car.Brand = Console.ReadLine();
                    
                    Console.Write("Model: ");
                    car.Model = Console.ReadLine();
                    
                    Console.Write("Renk: ");
                    car.Color = Console.ReadLine();
                    
                    Console.Write("Kapı Sayısı: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int doors))
                    {
                        Console.WriteLine("Geçersiz kapı sayısı! Lütfen sayısal bir değer giriniz.");
                        goto CreateCar;
                    }
                    car.NumberOfDoors = doors;
                    
                    arabalar.Add(car);

                    // Kullanıcıya başka araba oluşturmak isteyip istemediğini soruyoruz
                    Console.Write("Başka bir araba oluşturmak ister misiniz? (E/H): ");
                    string anotherCar = Console.ReadLine()?.ToLower();

                    if (anotherCar == "e")
                    {
                        goto CreateCar; // Yeni araba üretim sürecine geri dön
                    }
                    else if (anotherCar == "h")
                    {
                        Console.WriteLine("Program sonlandırılıyor...");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz cevap! Program sonlandırılıyor...");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata oluştu: {ex.Message}");
                    goto CreateCar;
                }
            }

            // Arabalar listesindeki tüm seri numaralarını ve markalarını yazdır
            Console.WriteLine("Oluşturulan Arabalar:");
            foreach (var araba in arabalar)
            {
                Console.WriteLine($"Seri Numarası: {araba.SerialNumber}, Marka: {araba.Brand}");
            }

            Console.ReadKey();
        }
    }
}
