namespace Pratik_Patikafy_Muzik_Platformu
{
    public class Singer
    {
        private readonly Guid _id;
        public Guid Id { get => _id; }
        public string Name { get; set; }
        public string MusicType { get; set; }
        public int DebutYear { get; set; }
        public double AlbumSales { get; set; }

        public Singer(string name, string musicType, int debutYear, double albumSales)
        {
            _id = Guid.NewGuid();
            Name = name;
            MusicType = musicType;
            DebutYear = debutYear;
            AlbumSales = albumSales;
        }

        
    }
}