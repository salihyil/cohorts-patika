namespace Hafta4_Kapanis
{
    public class Computer : BaseMachine
    {
        //field
        private int _numberOfUsbPorts;

        //property
        public int NumberOfUsbPorts
        {
            get
            {
                return _numberOfUsbPorts;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfUsbPorts = value;
                }
                else
                {
                    Console.WriteLine("Usb giriş sayısı 2 veya 4 olmalıdır.");
                    _numberOfUsbPorts = -1;
                }
            }
        }
        public bool HasBluetooth { get; set; }

        //constructor
        public Computer(string name, string description, string operatingSystem, string serialNumber, int numberOfUsbPorts, bool hasBluetooth) : base(name, description, operatingSystem, serialNumber)
        {
            NumberOfUsbPorts = numberOfUsbPorts;
            HasBluetooth = hasBluetooth;
        }

        //method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\nUSB Giriş Sayısı: {NumberOfUsbPorts}\nBluetooth: {HasBluetooth}");
        }

        //abstract method
        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Name}");
        }

    }
}
