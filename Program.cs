using System;

namespace Cosmos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Windmill.Windmill runner = new Windmill.Windmill(4096);
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (; !runner.program[runner.index].Equals(0);)
                runner.RunNext();

            Console.WriteLine(runner.ram[0]);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\nExecution time: "+ elapsedMs);
        }
    }
}
