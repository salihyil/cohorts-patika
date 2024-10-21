namespace Pratik_Inheritance
{
    public abstract class Person
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname cannot be empty or whitespace.");
                _surname = value;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }
    }

    public class Student : Person
    {
        public int StudentNo { get; set; }

        public Student(string name, string surname, int studentNo)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Student No: {StudentNo}");
        }
    }

    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public Teacher(string name, string surname, decimal salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Salary: {Salary}");
        }
    }
}
