using System;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }
        public void handle(HttpRequest request)
        {
            if (!doHandle(request))
                return;

            if(next!=null)
            next.handle(request);
        }  
        public abstract bool doHandle(HttpRequest request);
    }

    public class WebServer
    {
        private Handler handler;
        public WebServer(Handler handler) 
        {
            this.handler = handler;
        }
        public void handle(HttpRequest request)
        {
            handler.handle(request);
        }
    }

    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            var isValid = request.GetUsername() == "admin" && request.GetPassword() == "1234";
            Console.WriteLine("Authentication");
            return isValid;
        }
    }

    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Compressing..");
            return true;
        }
    }
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Logging..");
            return true;
        }
    }

    public class HttpRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        internal string GetUsername()
        {
            return UserName;
        }

        internal string GetPassword()
        {
            return Password;
        }

    }
}
