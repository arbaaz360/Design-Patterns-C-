using Factory;
using System;

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
            }
            
        }
    }
}



