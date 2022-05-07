using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);
            cron2.Start();
            Thread.Sleep(1000);
            cron1.Stop();
            cron2.Stop();
            
            TimeSpan tcron1 = cron1.Elapsed;
            TimeSpan tcron2 = cron2.Elapsed;
            Console.WriteLine($"{tcron1} sec");
            Console.WriteLine($"{tcron2} sec");
        }
    }
}
