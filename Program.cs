using System;

namespace Cosmos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Windmill.Windmill runner = new Windmill.Windmill(256, new byte[]
            {
                0x11, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x01, 0x2c, //add int 300 to mem
                0x51, 0x00, 0x00, 0x00, 0x00,  //convert int to string
                0x21, 0x00, 0x00, 0x00, 0x00, //print 300 - after converting

                0x10, 0x00, 0x00, 0x00, 0x00, 0x0a, //add line feed to mem
                0x20, 0x00, 0x00, 0x00, 0x00, //print line feed

                0x10, 0x00, 0x00, 0x00, 0x40, 0x4d, //add byte 77 to mem
                0x21, 0x00, 0x00, 0x00, 0x40, //print M - before converting
                0x50, 0x00, 0x00, 0x00, 0x40, //convert to char
                0x21, 0x00, 0x00, 0x00, 0x40, //print 77 - after converting
                0x00,
            });

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (; !runner.program[runner.index].Equals(0);)
                runner.RunNext();

            if (false) //enable or disable memo
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
