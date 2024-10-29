namespace Pratik_Lists_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" Kahve {i + 1} : ");

                Console.ForegroundColor = ConsoleColor.Green;
                coffeeList.Add(Console.ReadLine());
            }

            Console.ResetColor();
            Console.WriteLine("\nGirilen kahve isimleri : ");

            foreach (var coffee in coffeeList)
            {
                Console.WriteLine(coffee);
            }

            Console.ReadKey();
        }
    }
}
