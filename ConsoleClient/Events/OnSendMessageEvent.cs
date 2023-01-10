using Lib.Constants;

namespace ConsoleClient.Events
{
    internal class OnSendMessageEvent : ServerEvent
    {
        public OnSendMessageEvent() : base(EventName.SendMessageEvent) { }

        public override void OnMessage(Client client, string? message)
        {
            if (String.IsNullOrWhiteSpace(message))
                return;
            Console.WriteLine(message);
        }
    }
}
