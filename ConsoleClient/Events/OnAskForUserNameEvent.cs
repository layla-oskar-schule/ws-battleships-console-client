using Lib.Constants;

namespace ConsoleClient.Events
{
    public class OnAskForUserNameEvent : ServerEvent
    {
        public OnAskForUserNameEvent() : base(EventName.AskUserNameRequest) { }

        public override void OnMessage(Client client, string? message)
        {
            Console.Write("Username: ");
            string? username = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(username))
                OnMessage(client, message);
            else
                client.SendMessage(EventName.SendUserNameEvent + EventName.SUFFIX + username);
        }
    }
}
