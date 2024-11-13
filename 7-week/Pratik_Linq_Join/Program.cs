namespace Pratik_Linq_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>
            {
                new Books { BookId = 1, Title = "Kar", AuthorId = 1 },
                new Books { BookId = 2, Title = "İstanbul", AuthorId = 1 },
                new Books { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
                new Books { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 },
            };

            List<Authors> authors = new List<Authors>
            {
                new Authors { AuthorId = 1, Name = "Orhan Pamuk" },
                new Authors { AuthorId = 2, Name = "Elif Şafak" },
                new Authors { AuthorId = 3, Name = "Orhan Pamuk" },
            };

            var result = books.Join(
                authors,
                book => book.AuthorId,
                author => author.AuthorId,
                (book, author) => new
                {
                    BookTitle = book.Title,
                    AuthorName = author.Name
                });

            foreach (var item in result)
            {
                item.
                Console.WriteLine($"Kitap başlığı: {item.BookTitle} - Yazarın adı: {item.AuthorName}");
            }


            Console.ReadKey();



        }
    }
}
