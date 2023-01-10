using ConsoleClient.ConsoleHelper;
using Lib.Constants;
using Lib.GameEntities;

namespace ConsoleClient.Events
{
    public class OnAskFireLocationEvent : ServerEvent
    {
        public OnAskFireLocationEvent() : base(EventName.AskShootLocationRequst) { }

        public override void OnMessage(Client client, string? message)
        {
            Console.WriteLine("Your turn! Try to shoot the boats of your enemy.");
            Location location = LocationConsoleHelper.AskForLocation();
            client.SendMessage($"{EventName.SendShootLocationEvent}{EventName.SUFFIX}{location}");
        }
    }
}
