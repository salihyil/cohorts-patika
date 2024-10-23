namespace Hafta4_Kapanis
{
    public class Phone : BaseMachine
    {
        //property
        public bool HasTrLicense { get; set; }

        //constructor
        public Phone(string name, string description, string operatingSystem, string serialNumber, bool hasTrLicense) : base(name, description, operatingSystem, serialNumber)
        {
            HasTrLicense = hasTrLicense;
        }

        //method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\nTr Lisanslı mı: {HasTrLicense}");
        }

        //abstract method
        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Name}");
        }
    }
}
