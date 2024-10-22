namespace Pratik_Abstraction
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public abstract void Task();

        public void ShowInfo()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Departman: {Department}");
        }
    }

    public class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public override void Task()
        {
            Console.WriteLine("Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    public class ProjectManager : Employee
    {
        public ProjectManager(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public override void Task()
        {
            Console.WriteLine("Proje Yöneticisi olarak çalışıyorum.");
        }
    }

    public class SalesRepresentative : Employee
    {
        public SalesRepresentative(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public override void Task()
        {
            Console.WriteLine("Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}
