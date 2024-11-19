namespace Hafta_5_Kapanis
{
    public class Car
    {
        //fields
        private DateTime _productionDate;
        private string _serialNumber;
        private string _brand;
        private string _model;
        private string _color;
        private int _numberOfDoors;

        //properties
        public DateTime ProductionDate 
        { 
            get { return _productionDate; }
            private set { _productionDate = value; }
        }

        public string SerialNumber 
        { 
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        public string Brand 
        { 
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model 
        { 
            get { return _model; }
            set { _model = value; }
        }

        public string Color 
        { 
            get { return _color; }
            set { _color = value; }
        }

        public int NumberOfDoors 
        { 
            get { return _numberOfDoors; }
            set { _numberOfDoors = value; }
        }

        //constructors
        public Car()
        {
            ProductionDate = DateTime.Now; // Üretim tarihi otomatik olarak şu anki zaman olarak atanıyor
        }

        //methods
        public override string ToString()
        {
            return $"Serial Number: {SerialNumber}, Brand: {Brand}";
        }
    }
}
