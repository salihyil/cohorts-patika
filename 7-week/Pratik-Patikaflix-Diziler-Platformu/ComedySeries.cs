namespace Pratik_Patikaflix_Diziler_Platformu
{
    public class ComedySeries : Series
    {
        public ComedySeries(string name, string genre, string director)
            : base(name, 0, genre, 0, director, "")
        {
        }

        public override string GetSeriesInfo()
        {
            return $"Komedi Dizisi: {Name}\nYönetmen: {Director}\nTür: {Genre}";
        }
    }
}