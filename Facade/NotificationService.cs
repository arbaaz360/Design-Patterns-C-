using System;

namespace Facade
{
    public class NotificationService
    {
        public void Send(string msg, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appId", "key");
            server.Send(authToken, new Message(msg), target);
            server.Disconnect();

        }
    }

    internal class Message
    {
        private string msg;

        public Message(string msg)
        {
            this.msg = msg;
        }
    }

    internal class NotificationServer
    {
        public NotificationServer()
        {
        }

        internal bool Authenticate(string v1, string v2)
        {
            return true;
        }

        internal object Connect(string v)
        {
            return "connection";
        }

        internal void Disconnect()
        {
            Console.WriteLine("Server disconnected..");
        }

        internal void Send(object authToken, Message message, string target)
        {
            Console.WriteLine("notification sent..");
        }
    }
}
