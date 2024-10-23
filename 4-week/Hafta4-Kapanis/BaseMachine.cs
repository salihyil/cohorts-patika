namespace Hafta4_Kapanis
{
    public abstract class BaseMachine
    {
        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        //constructor
        protected BaseMachine(string name, string description, string operatingSystem, string serialNumber)
        {
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
            SerialNumber = serialNumber;
            ProductionDate = DateTime.Now;
        }

        //method
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Üretim Tarihi: {ProductionDate}\nSeri Numarası: {SerialNumber}\nAd: {Name}\nAçıklama: {Description}\nİşletim Sistemi: {OperatingSystem}");
        }

        //abstract method
        public abstract void GetProductName();
    }
}
