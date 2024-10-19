using System;

namespace Pratik_Patika_Kutuphane
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }

        // RegistrationDate özelliğinin set metodunu private yapmamın nedeni, bu değerin yalnızca sınıf içinde değiştirilebilmesini sağlamak ve dışarıdan doğrudan değiştirilmesini önlemektir. Bunun avantajları : Veri bütünlüğü, Encapsulation ve Güvenlik
        public DateTime RegistrationDate { get; private set; }

        // Default constructor
        public Book()
        {
            RegistrationDate = DateTime.Now;
        }

        // Parameterized constructor
        public Book(string title, string authorFirstName, string authorLastName, int pageCount, string publisher)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PageCount = pageCount;
            Publisher = publisher;
            RegistrationDate = DateTime.Now;
        }

        public void PrintBookDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorFirstName} {AuthorLastName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Registration Date: {RegistrationDate}");
        }
    }
}       