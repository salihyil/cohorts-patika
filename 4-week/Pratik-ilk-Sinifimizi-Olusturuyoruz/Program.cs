using System;

namespace Pratik_ilk_Sinifimizi_Olusturuyoruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            student.Name = "Salih";
            student.Surname = "Yılmaz";
            student.DateOfBirth = 1995;

            Console.WriteLine("Öğrencinin adı: " + student.Name);
            Console.WriteLine("Öğrencinin soyadı: " + student.Surname);
            Console.WriteLine("Öğrencinin doğum tarihi: " + student.DateOfBirth);

            Console.WriteLine("----------------------------------");

            Person teacher = new Person();
            teacher.Name = "Yiğit";
            teacher.Surname = "Hacıefendioğlu";
            teacher.DateOfBirth = 1989;

            Console.WriteLine("Öğretmenin adı: " + teacher.Name);
            Console.WriteLine("Öğretmenin soyadı: " + teacher.Surname);
            Console.WriteLine("Öğretmenin doğum tarihi: " + teacher.DateOfBirth);
        }
    }
}
