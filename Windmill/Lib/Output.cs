using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill.Lib
{
    static class Output
    {
        public static void FindFunction(Windmill super)
        {
            super.index++;
            switch (super.program[super.index - 1] % 16)
            {
                case 0x00:
                    PrintChar(super);
                    break;
                case 0x01:
                    PrintString(super);
                    break;
            }
        }

        public static void PrintChar(Windmill super)
        {
            int loc = Memory.GetRamLoc(super);
            Console.WriteLine(loc);
            Console.Write((char) super.ram[loc]);
        }

        public static void PrintString(Windmill super)
        {
            int loc = Memory.GetRamLoc(super);
            string capture = "";

            for (; super.ram[loc] != 0; loc++)
            {
                capture += (char) super.ram[loc];
            }
            Console.Write(capture);
        }
    }
}
