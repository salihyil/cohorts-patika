namespace Pratik_IMDB_Listesi
{
    internal class Program
    {
        private const double MIN_IMDB_SCORE = 0;
        private const double MAX_IMDB_SCORE = 10;
        static void Main(string[] args)
        {
            List<Movie> movies = [];
            AddMovies(movies);
            DisplayMovieLists(movies);

            Console.ReadKey();
        }

        static void AddMovies(List<Movie> movies)
        {
            bool isContinue = true;
            while (isContinue)
            {

                PrintWrite("Film ismini giriniz: ");
                string movieName = Console.ReadLine();

                if (string.IsNullOrEmpty(movieName))
                {
                    PrintWriteLineError("Film ismi boş olamaz!\n");
                    continue;
                }

                double imdbScore;
                while (true)
                {
                    PrintWrite("Film imdb puanını giriniz: ");
                    if (!double.TryParse(Console.ReadLine(), out imdbScore) || imdbScore < MIN_IMDB_SCORE || imdbScore > MAX_IMDB_SCORE)
                    {
                        PrintWriteLineError("Geçersiz puan girişi! Lütfen 0 ile 10 arasında bir sayı giriniz.\n");
                        continue;
                    }
                    break;
                }

                Movie movie = new Movie(movieName, imdbScore);
                movies.Add(movie);

                PrintWrite("Yeni film eklemek istiyor musunuz? (evet/hayır) -> ");
                isContinue = Console.ReadLine().ToLower() == "evet";

                Console.WriteLine();
            }
        }

        static void DisplayMovieLists(List<Movie> movies)
        {
            PrintWriteLine("\nTüm filmler:");
            foreach (Movie movie in movies)
            {
                PrintMovie(movie);
            }

            PrintWriteLine("\nImdb puanı 4 ile 9 arasında olan filmler:");
            var filteredByScore = movies.Where(movie => movie.ImdbScore >= 4 && movie.ImdbScore <= 9);
            if (filteredByScore.Any())
            {
                foreach (Movie movie in filteredByScore)
                {
                    PrintMovie(movie);
                }
            }
            else
            {
                PrintWriteLineError("Bu kritere uygun film bulunamadı!");
            }

            PrintWriteLine("\nİsmi 'A' ile başlayan filmler:");
            var filteredByName = movies.Where(movie => movie.Name.ToLower().StartsWith('a'));
            if (filteredByName.Any())
            {
                foreach (Movie movie in filteredByName)
                {
                    PrintMovie(movie);
                }
            }
            else
            {
                PrintWriteLineError("Bu kritere uygun film bulunamadı!");
            }
        }

        static void PrintWriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintWrite(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }

        static void PrintWriteLineError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintMovie(Movie movie)
        {
            Console.WriteLine($"Adı: {movie.Name} - İmdb puanı: {movie.ImdbScore}");
        }
    }
}
