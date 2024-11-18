namespace Pratik_AspNet_Core_Empty.Models
{
    public class TestViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public TestViewModel(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}