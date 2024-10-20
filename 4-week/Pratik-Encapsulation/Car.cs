namespace Pratik_Encapsulation
{
    public class Car
    {
        //Field
        private string _brand;
        private string _model;
        private string _color;
        private int _numberOfDoors;

        //Property
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public string Color { get => _color; set => _color = value; }
        public int NumberOfDoors
        {
            get => _numberOfDoors;
            set
            {
                if (value != 2 && value != 4)
                {
                    _numberOfDoors = -1;
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır.");
                }
                else
                {
                    _numberOfDoors = value;
                }
            }
        }

        //Constructor
        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        //method
        public void PrintCarInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Renk: {Color}, Kapı Sayısı: {NumberOfDoors}");
        }
    }
}
