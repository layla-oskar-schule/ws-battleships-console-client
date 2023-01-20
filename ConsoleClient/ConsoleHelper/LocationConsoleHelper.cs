using ConsoleClient.Extensions;
using Lib.Constants;
using Lib.Extensions;
using Lib.GameEntities;

namespace ConsoleClient.ConsoleHelper
{
    public static class LocationConsoleHelper
    {
        public static Location AskForLocation()
        {
            Console.Write("location: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input!");
                return AskForLocation();
            }

            return input.ParseLocation();
        }
    }
}
