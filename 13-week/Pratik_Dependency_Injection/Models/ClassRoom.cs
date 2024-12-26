using Pratik_Dependency_Injection.Interfaces;

namespace Pratik_Dependency_Injection.Models
{
    public class ClassRoom
    {
        //Dependency Injection, bir sınıfın ihtiyaç duyduğu bağımlılıkların dışarıdan verilmesi anlamına gelir. Bu, sınıflar arasındaki bağımlılıkları azaltarak daha esnek bir yapı sağlar.
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
