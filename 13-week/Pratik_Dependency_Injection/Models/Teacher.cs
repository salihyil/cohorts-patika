using Pratik_Dependency_Injection.Interfaces;

namespace Pratik_Dependency_Injection.Models
{
    public class Teacher : ITeacher
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }

        public string GetInfo()
        {
            return $"Name = {FirstName} Surname = {LastName} Department = {Department}";
        }
    }
}
