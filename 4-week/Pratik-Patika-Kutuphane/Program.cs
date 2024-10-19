namespace Pratik_Patika_Kutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Book instance using the parameterized constructor
            Book book1 = new Book("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
            // Print book details
            book1.PrintBookDetails();

            Console.WriteLine("--------------------------------");

            Book book2 = new Book();
            book2.Title = "Başka Bir Kitap";
            book2.AuthorFirstName = "Ayşe";
            book2.AuthorLastName = "Karan";
            book2.PageCount = 215;
            book2.Publisher = "Beta Yayıncılık";
            book2.PrintBookDetails();

            Console.WriteLine("--------------------------------");

            Book book3 = new Book("Daha Başka Bir Kitap", "Mehmet", "Demir", 450, "Gamma Yayıncılık");
            book3.PrintBookDetails();

            Console.ReadKey();

            // Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.
            // Class: Book sınıfı, bir kitabın özelliklerini ve davranışlarını tanımlayan bir yapıdır. Örneğin: public class Book { ... }
            // Property: Book sınıfının özellikleridir, kitabın bilgilerini tutar. Örneğin: public string Title { get; set; }
            // New: Yeni bir nesne oluşturmak için kullanılır. Örneğin: Book book1 = new Book();
            // Constructor: Nesne oluşturulurken çağrılan özel bir metottur. Örneğin: public Book(string title, string authorFirstName, ...) { ... }

        }
    }
}