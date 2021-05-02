using System;

namespace Cosmos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Windmill.Windmill runner = new Windmill.Windmill(256, new byte[]
            {
                //add hello world to memory starting at loc 0x00
                0x12, 0x00, 0x00, 0x00, 0x0F, 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x77, 0x6F, 0x72, 0x6C, 0x64, 0x21, 0x00,
                //print string starting at loc 0x00
                0x21, 0x00, 0x00, 0x00, 0x0F, 
                //end program
                0x00,
            });

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (; !runner.program[runner.index].Equals(0);)
                runner.RunNext();

            if (false) //enable or disable memory map
                for (int i = 0; i < 256;)
                {
                    Console.Write(i + " -> ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("0x" + runner.ram[i].ToString("X") + " ");
                        i++;
                    }
                    Console.WriteLine();
                }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\nExecution time: "+ elapsedMs);
        }
    }
}
