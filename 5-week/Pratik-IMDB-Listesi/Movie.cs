namespace Pratik_IMDB_Listesi
{
    public class Movie
    {
        //fields

        //properties
        public string Name { get; set; }
        public double ImdbScore { get; set; }

        //constructors
        public Movie(string name, double imdbScore)
        {
            Name = name;
            ImdbScore = imdbScore;
        }

        //methods
    }
}
