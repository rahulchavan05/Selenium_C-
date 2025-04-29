using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Logicals.Parallel
{

    
    class Program
    {
        [Test]
        public static async Task Main()
        {
            Task task1 = Task.Run(() => DoWork("Task 1"));
            Task task2 = Task.Run(() => DoWork("Task 2"));

            await Task.WhenAll(task1, task2);

            //Console.WriteLine("Both tasks completed.");
        }

        static void DoWork(string taskName)
        {
            Console.WriteLine($"{taskName} is running on thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"{taskName} is completed.");
        }
    }

}
