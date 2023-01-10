using Lib.Constants;

namespace ConsoleClient.Events
{
    public class MessageEventHandler : MessageEvent
    {
        private readonly List<ServerEvent> events = new()
        {
            new OnAskForUserNameEvent(),
            new OnAskForGameNameEvent(),
            new OnAskBoatLocationEvent(),
            new OnAskFireLocationEvent(),
            new OnSendMessageEvent(),
            new OnSendGameFieldEvent(),
        };

        public override void OnMessage(Client client, string? message)
        {
            if (!String.IsNullOrEmpty(message) && message.Contains(EventName.SUFFIX)) 
            { 
                foreach(ServerEvent serverEvent in events)
                {
                    if(serverEvent.Name == message.Split('$')[0])
                        serverEvent.OnMessage(client, message.Split('$')[1]);
                }
            }
        }
    }
}
