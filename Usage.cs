using System;
using System.Threading;

namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CountDownTimer timer = new CountDownTimer(new TimeSpan(0,0,4,0));
            timer.Start();
            Thread.Sleep(2000);
            Console.WriteLine(timer.Remaining());
            Thread.Sleep(4000);
            Console.WriteLine(timer.Remaining());
            Console.WriteLine("Enter any key...");
            Console.ReadKey();

            CountDownTimer timer1 = new CountDownTimer(new TimeSpan(0, 0, 4, 0));
            timer1.Start();
            Thread.Sleep(2000);
            Console.WriteLine(timer1.Remaining());
            Thread.Sleep(4000);
            Console.WriteLine(timer1.Remaining());
            Console.WriteLine("Enter any key....");
            Console.ReadKey();
        }
    }
}
