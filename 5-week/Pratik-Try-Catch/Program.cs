namespace Pratik_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayının karesi: " + sayi * sayi);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }

            Console.ReadKey();

        }
    }
}
