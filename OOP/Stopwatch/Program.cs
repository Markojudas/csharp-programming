using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var stopwatch = new StopWatch();

            System.Console.WriteLine("Starting the timer!");
            stopwatch.Start();
            
            Thread.Sleep(1000);
            
            System.Console.WriteLine("Stoping the timer!");
            stopwatch.Stop();
            
            System.Console.WriteLine("Time Span in Seconds: " + stopwatch.GetDuration());
                                    
        }
    }
}
