namespace Pratik_Constructor
{
    internal class Bebek
    {
        // Fields
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private DateTime _birthDate;

        // Properties
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }

        // Constructors
        public Bebek()
        {
            BirthDate = DateTime.Now;
            Console.WriteLine($"Ingaaaa");
        }

        public Bebek(string name, string surname)
        {
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Now;

            Console.WriteLine($"Ingaaaa");
        }
    }
}
