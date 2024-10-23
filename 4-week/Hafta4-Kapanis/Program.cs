using System.Globalization;

namespace Hafta4_Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PHONE_OPTION = 1;
            const int COMPUTER_OPTION = 2;

            do
            {
                Console.Clear();
                Console.WriteLine("Telefon üretmek için 1'e basınız.\nBilgisayar üretmek için 2'ye basınız.");
                int choice = GetValidChoice(PHONE_OPTION, COMPUTER_OPTION);

                if (choice == PHONE_OPTION)
                {
                    CreatePhone();
                }
                else if (choice == COMPUTER_OPTION)
                {
                    CreateComputer();
                }

            } while (WantToCreateAnotherProduct());

            Console.WriteLine("İyi Günler.");
            Console.ReadKey();
        }

        static int GetValidChoice(int option1, int option2)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != option1 && choice != option2))
            {
                Console.WriteLine($"Geçersiz seçim. Lütfen {option1} veya {option2} giriniz.");
            }
            return choice;
        }

        static void CreatePhone()
        {
            Console.WriteLine("Telefonun adını giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Telefonun açıklamasını giriniz: ");
            string description = Console.ReadLine();

            Console.WriteLine("Telefonun işletim sisteminin adını giriniz: ");
            string operatingSystem = Console.ReadLine();

            Console.WriteLine("Telefonun seri numarasını giriniz: ");
            string serialNumber = Console.ReadLine();

            Console.WriteLine("Telefonun Tr lisanslı olup olmadığını giriniz: (true/false)");
            bool hasTrLicense = Convert.ToBoolean(Console.ReadLine());

            Phone phone = new Phone(name, description, operatingSystem, serialNumber, hasTrLicense);
            phone.PrintInfo();
            phone.GetProductName();
            Console.WriteLine("Telefon üretildi.");
        }

        static void CreateComputer()
        {
            Console.WriteLine("Bilgisayarın adını giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Bilgisayarın açıklamasını giriniz: ");
            string description = Console.ReadLine();

            Console.WriteLine("Bilgisayarın işletim sisteminin adını giriniz: ");
            string operatingSystem = Console.ReadLine();

            Console.WriteLine("Bilgisayarın seri numarasını giriniz: ");
            string serialNumber = Console.ReadLine();

            Console.WriteLine("Bilgisayarın USB port sayısını giriniz: ");
            int numberOfUsbPorts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bilgisayarın Bluetooth ile çalışıp çalışmadığını giriniz: (true/false)");
            bool hasBluetooth = Convert.ToBoolean(Console.ReadLine());

            Computer computer = new Computer(name, description, operatingSystem, serialNumber, numberOfUsbPorts, hasBluetooth);
            computer.PrintInfo();
            computer.GetProductName();
            Console.WriteLine("Bilgisayar üretildi.");
        }

        static bool WantToCreateAnotherProduct()
        {
            Console.WriteLine("Başka bir ürün üretmek isteyip istemediğinizi giriniz: (evet/hayır)");
            string answer;
            do
            {
                answer = Console.ReadLine().ToLower(new CultureInfo("tr-TR"));
                if (answer != "evet" && answer != "hayır")
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen evet veya hayır giriniz.");
                }
            } while (answer != "evet" && answer != "hayır");

            // hayır ise false, evet ise true döner.
            return answer == "evet";
        }
    }
}
