using Adapter;
using Bridge;
using ChainOfResponsibility;
using ClassLibrary1;
using Command;
using Command.Undo;
using Decorator;
using Facade;
using Factory;
using FlyWeight;
using Iterator;
using Mediator;
using Momento;
using Observer;
using Proxy;
using State;
using Strategy;
using System;
using System.Collections.Generic;
using Template;
using Visitor; 

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factory Pattern. \n" +
                "Enter 2 for Observer Pattern.");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var ef = new EmployeeFactory();
                    Console.WriteLine(ef.GetEmployee(1).GetBonus());
                    Console.ReadLine();
                    break;
                case 2:
                    var observable = new TemperatureMonitor();
                    var observer = new TemperatureReporter();
                    observer.Subscribe(observable);
                    observable.GetTemperature();
                    break;
                case 3:
                    var editor = new Editor();
                    var history = new Momento.History();

                    editor.SetContent("a");
                    history.Push(editor.CreateState());
                    editor.SetContent("b");
                    history.Push(editor.CreateState());
                    editor.SetContent("c");
                    history.Push(editor.CreateState());
                    editor.Restore(history.Pop());
                    editor.Restore(history.Pop());

                    Console.WriteLine(editor.GetContent());
                    break;
                case 4:

                    Canvas canvas = new Canvas();
                    canvas.SelectTool(new BrushTool());
                    canvas.MouseDown();
                    canvas.MouseUp();
                    break;
                case 5:

                    BrowseHistory browseHistory = new BrowseHistory();
                    browseHistory.Push("www.google.com");
                    browseHistory.Push("www.yahoo.com");
                    browseHistory.Push("www.reddif.com");
                    browseHistory.Push("www.youtube.com");

                    IIterator<string> iterator = browseHistory.CreateIterator();
                    while (iterator.HasNext())
                    {
                        var url = iterator.Current();
                        Console.WriteLine(url);
                        iterator.next();
                    }
                    break;
                case 6:
                    //The difference between State and Strategy pattern is that in state pattern there is only a single state of the object and the behaviour is determined by the implementation injected. 
                    //In strategy pattern there could be multiple behaviours in form of multiple properties inside class such as IFilter & ICompression. The implementation injected further changes the behaviour. 
                    PhotoProcessor photoProcessor = new PhotoProcessor(new BnW(), new JPEG());
                    photoProcessor.ProcessPhoto();
                    break;
                case 7: //template
                    AbstractPreFlightCheckList flightChecklist = new F16PreFlightCheckList();
                    flightChecklist.runChecklist();

                    break;
                case 8: //command
                    var service = new CustomerService();
                    var command = new AddCustomerCommand(service);
                    var button = new Command.Button(command);
                    button.click();

                    var composite = new CompositeCommand();
                    composite.Add(new ResizeCommand());
                    composite.Add(new BlackAndWHiteCommand());
                    var button2 = new Command.Button(composite);
                    button2.click();

                    var commandHisotry = new Command.Undo.History();

                    var doc = new Command.Undo.HtmlDocument();
                    doc.SetContent("Hello World");
                    var boldCommand = new BoldCommand(doc, commandHisotry);
                    boldCommand.Execute();
                    Console.WriteLine(doc.GetContent());

                    var undoCommand = new UndoCommand(commandHisotry);
                    undoCommand.Execute();
                    Console.WriteLine(doc.GetContent());

                    break;
                case 9: //Observer
                    DataSource dataSource = new DataSource();
                    dataSource.AddObserver(new Chart());
                    dataSource.AddObserver(new SpreadSheet(dataSource));
                    dataSource.SetValue("value changed");
                    break;
                case 10: //Mediator //the pattern is applied to encapsulate or centralize the interactions amongst a number of objects
                    var dialog = new ArticlesDialogBox();
                    dialog.SimulateUsserInteraction();
                    break;
                case 11: //Chain of Responsibility
                    //autehnticator --> logger --> compressor --> null
                    var compressor = new Compressor(null);
                    var logger = new Logger(compressor);
                    var authenticator = new Authenticator(logger);
                    var server = new WebServer(authenticator);
                    server.handle(new HttpRequest() { UserName = "admin", Password="1234" });
                    break;
                case 12: //Visitor
                    var document = new Visitor.HtmlDocument();
                    document.Add(new HeadingNode());
                    document.Add(new AnchorNode());
                    document.Execute(new HighlighOperation());
                    break;
                case 13: // Composite
                    var shape1 = new Shape();
                    var shape2 = new Shape();
                    var group1 = new Group();
                    group1.Add(shape1);
                    group1.Add(shape2);
                    var group2 = new Group();
                    var shape3 = new Shape();
                    group2.Add(shape3);
                    group1.Add(group2);
                    group1.render();
                    break;
                case 14: //Adapter
                    Image image = new Image();
                    ImageViewer imageViewer = new ImageViewer(image);
                    imageViewer.Apply(new SepiaFilter());
                    imageViewer.Apply(new FancyAdapter(new FancyFilter()));
                    break;
                case 15: //Decorator
                    var cloudStream = new CloudStream();
                    var encryptData = new EncryptStream(cloudStream);
                    var compressData = new CompressStream(encryptData);
                    compressData.write("some random data");
                    break;
                case 16: //Facade
                    NotificationService notificationService = new NotificationService();
                    notificationService.Send("Hello..", "17.0.0.1");
                    break;
                case 17: //Flyweight
                    PointService pointService = new PointService(new PointFactory());
                    var points = pointService.getPoints();
                    foreach(var p in points)
                    {
                        p.draw();
                    }
                    break;
                case 18: //Bridge
                    AdvancedRemoteControl remote = new AdvancedRemoteControl(new SonyTv());
                    remote.setChannel(1);
                    break;
                case 19: //Proxy
                    Library lib = new Library();
                    List<string> bookNames = new List<string>() { "a","b","c"};
                    foreach(var book in bookNames)
                    {
                        lib.eBooks.Add(book,new EBookProxy(book));
                    }
                    lib.OpenEbook("a");
                    break;
            }

            Console.ReadLine();

        }
        
    }
}



