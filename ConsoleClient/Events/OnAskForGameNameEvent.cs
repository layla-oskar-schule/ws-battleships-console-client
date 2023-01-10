using Lib.Constants;

namespace ConsoleClient.Events
{
    public class OnAskForGameNameEvent : ServerEvent
    {
        public OnAskForGameNameEvent() : base(EventName.AskGameNameRequest) { }

        public override void OnMessage(Client client, string? message)
        {
            Console.Write("Gamename: ");
            string? username = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(username))
                OnMessage(client, message);
            else
                client.SendMessage(EventName.SendGameNameEvent + EventName.SUFFIX + username);
        }
    }
}
