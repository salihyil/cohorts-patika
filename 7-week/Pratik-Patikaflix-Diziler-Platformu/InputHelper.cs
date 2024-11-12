namespace Pratik_Patikaflix_Diziler_Platformu
{
    public static class InputHelper
    {
        public static string GetNonEmptyString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? string.Empty;
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static int GetInteger(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
        }
    }
}