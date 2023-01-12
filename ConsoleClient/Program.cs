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
        
        new Client(configManager.Config.ApiUrl).Start().GetAwaiter().GetResult();
    }
}