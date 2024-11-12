namespace Pratik_Patikaflix_Diziler_Platformu
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Series> seriesList = new List<Series>{
                new Series("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"),
                new Series("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
                new Series("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
                new Series("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
                new Series("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
                new Series("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
                new Series("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
                new Series("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
                new Series("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D")
            };

            string continueAdding;
            do
            {
                Console.WriteLine("\nDizi bilgilerini giriniz:");

                string name = InputHelper.GetNonEmptyString("Dizi Adı: ");
                int productionYear = InputHelper.GetInteger("Yapım Yılı: ");
                string genre = InputHelper.GetNonEmptyString("Türü: ");
                int startYear = InputHelper.GetInteger("Yayınlanmaya Başlama Yılı: ");
                string director = InputHelper.GetNonEmptyString("Yönetmen: ");
                string platform = InputHelper.GetNonEmptyString("Platform: ");

                seriesList.Add(new Series(name, productionYear, genre, startYear, director, platform));

                Console.Write("\nYeni dizi eklemek istiyor musunuz? (E/H): ");
                continueAdding = Console.ReadLine().ToUpper();
            } while (continueAdding == "E");

            // Komedi dizilerini filtreleme
            var comedySeriesList = seriesList
                .Where(s => s.Genre.Contains("komedi", StringComparison.OrdinalIgnoreCase))
                .Select(s => new ComedySeries(s.Name, s.Genre, s.Director))
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Director)
                .ToList();

            // Komedi dizilerini yazdırma
            Console.WriteLine("\nKomedi Dizileri:");
            Console.WriteLine("----------------");
            foreach (var comedySeries in comedySeriesList)
            {
                Console.WriteLine(comedySeries.GetSeriesInfo());
                Console.WriteLine("-------------------");
            }


            Console.ReadKey();
        }
    }
}