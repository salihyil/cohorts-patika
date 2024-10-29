namespace Pratik_Lists_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu Pratik'te sizden ziyaretçilerin isimlerini eklediğimiz bir liste oluşturmanızı ve bu liste içerisinde for ya da foreach döngüsü ile dönerek isimlerini tek tek ekrana yazdırmanız isteniyor.

            /* ** Davetliler * *
            1 - Bülent Ersoy
            2 - Ajda Pekkan
            3 - Ebru Gündes
            4 - Hadise
            5 - Hande Yener
            6 - Tarkan
            7 - Funda Arar
            8 - Demet Akalin */

            Console.WriteLine("** Davetliler * *");
            List<string> guests = ["Bülent Ersoy", "Ajda Pekkan", "Ebru Gündes", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalin"];

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {guests[i]}");
            }

            Console.ReadLine();
        }
    }
}
