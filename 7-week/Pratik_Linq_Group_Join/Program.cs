namespace Pratik_Linq_Group_Join
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student> {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Veli", ClassId = 1 },
                new Student { StudentId = 3, StudentName = "Ahmet", ClassId = 2 },
                new Student { StudentId = 4, StudentName = "Mehmet", ClassId = 2 },
                new Student { StudentId = 5, StudentName = "Fatih", ClassId = 3 },
            };

            List<Class> classes = new List<Class> {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" },
            };

            var grouped = classes.GroupJoin(
                students,
                @class => @class.ClassId,
                student => student.ClassId,
                (@class, studentsGroup) => new
                {
                    className = @class.ClassName,
                    studentNames = studentsGroup.Select(student => student.StudentName)

                });

            foreach (var item in grouped)
            {
                Console.WriteLine($"Ders: {item.className}");
                foreach (var name in item.studentNames)
                {
                    Console.WriteLine($"  - Ogrenci: {name}");
                }

            }
            Console.ReadKey();
        }
    }
}
