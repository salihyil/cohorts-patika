namespace Pratik_Patikafy_Muzik_Platformu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Singer> singers = new List<Singer>
            {
                new Singer("Ajda Pekkan", "Pop", 1968, 20000000),
                new Singer("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10000000),
                new Singer("Funda Arar", "Pop", 1999, 3000000),
                new Singer("Sertab Erener", "Pop", 1994, 5000000),
                new Singer("Sıla", "Pop", 2009, 3000000),
                new Singer("Serdar Ortaç", "Pop", 1994, 10000000),
                new Singer("Tarkan", "Pop", 1992, 40000000),
                new Singer("Hande Yener", "Pop", 1999, 7000000),
                new Singer("Hadise", "Pop", 2005, 5000000),
                new Singer("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10000000),
                new Singer("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2000000)
            };

            Console.Write("Adı 'S' ile başlayan şarkıcılar:\n");
            var singersStartingWithS = singers.Where(s => s.Name.ToLower().StartsWith('s')).ToList();
            for (int i = 0; i < singersStartingWithS.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {singersStartingWithS[i].Name}");
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            Console.Write("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:\n");
            var singersWithHighSales = singers.Where(s => s.AlbumSales > 10000000).ToList();
            for (int i = 0; i < singersWithHighSales.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {singersWithHighSales[i].Name}");
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            Console.Write("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız:\n");
            var singersBefore2000AndPop = from singer in singers
                                          where singer.DebutYear < 2000 && singer.MusicType.Contains("pop", StringComparison.CurrentCultureIgnoreCase)
                                          orderby singer.DebutYear, singer.Name
                                          group singer by singer.DebutYear into groupedSingers
                                          select groupedSingers;

            foreach (var group in singersBefore2000AndPop)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var singer in group)
                {
                    Console.WriteLine($"    - {singer.Name}");
                }
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            Console.WriteLine("En çok albüm satan şarkıcılar:\n");
            var singersWithMostSales = singers.OrderByDescending(singer => singer.AlbumSales).ThenBy(singer => singer.Name).ToList();
            foreach (var group in singersWithMostSales)
            {
                Console.WriteLine($"{group.Name} - {group.AlbumSales:N0}");
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");
            var newSinger = singers.OrderByDescending(singer => singer.DebutYear).First().Name;
            var oldSinger = singers.OrderBy(singer => singer.DebutYear).First().Name;
            var newSingerDebutYear = singers.OrderByDescending(singer => singer.DebutYear).First().DebutYear;
            var oldSingerDebutYear = singers.OrderBy(singer => singer.DebutYear).First().DebutYear;

            Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı:\n");
            Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newSinger} ({newSingerDebutYear})");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldSinger} ({oldSingerDebutYear})");


            Console.ReadKey();
        }
    }
}
