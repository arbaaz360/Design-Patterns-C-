using Factory;
using Iterator;
using Momento;
using State;
using Strategy;
using System;
using Template;

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
                    var history = new History();

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
                    PhotoProcessor photoProcessor = new PhotoProcessor(new BnW(),new JPEG());
                    photoProcessor.ProcessPhoto();
                    break;
                case 7:
                    AbstractPreFlightCheckList flightChecklist = new F16PreFlightCheckList();
                    flightChecklist.runChecklist();

                    break;
            }

            Console.ReadLine();

        }
    }
}



