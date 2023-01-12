using ConsoleClient;
using ConsoleClient.Configuration;
using System.Net.WebSockets;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        ConfigManager configManager = new ConfigManager();
        configManager.Load();
        Console.WriteLine(configManager.Config.Type);
        Console.WriteLine(configManager.Config.ApiUrl);


        // new Client("wss://api.battleships.oskars.tech/game").Start().GetAwaiter().GetResult();
    }
}