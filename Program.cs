using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExampole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var task = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Task");
            });
            task.Start();

            await task;

            Console.WriteLine("Hola mundo");

            Console.ReadKey();
        }
    }
}
