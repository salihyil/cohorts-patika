namespace Pratik_Patikaflix_Diziler_Platformu
{
    public class Series
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public string Genre { get; set; }
        public int StartYear { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }

        public Series(string name, int productionYear, string genre, int startYear, string director, string platform)
        {
            Name = name;
            ProductionYear = productionYear;
            Genre = genre;
            StartYear = startYear;
            Director = director;
            Platform = platform;
        }

        // Virtual method that can be overridden by derived classes
        public virtual string GetSeriesInfo()
        {
            return $"Dizi: {Name}, Yönetmen: {Director}, Tür: {Genre}";
        }
    }
}