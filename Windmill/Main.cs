using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill
{
    class Windmill
    {
        public byte[] program = new byte[]
        {
            0x12, 0x00, 0x00, 0x00, 0x00, 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21, 0x0a, 0x00,
            0x21, 0x00, 0x00, 0x00, 0x00,
            0x31, 0x00, 0x00, 0x00, 0x40,
            0x21, 0x00, 0x00, 0x00, 0x40,
            0x00, 
        }
        ;

        public byte[] ram;
        public int index;

        public Windmill(uint mAlloc)
        {
            ram = new byte[mAlloc];
        }

        public void RunNext()
        {
            FindCommand();
            index++;
        }

        public void FindCommand()
        {
            switch (program[index] / 16)
            {
                case 0x01:
                    Lib.Memory.FindFunction(this);
                    break;
                case 0x02:
                    Lib.Output.FindFunction(this);
                    break;
                case 0x03:
                    Lib.Input.FindFunction(this);
                    break;
                case 0x04:
                    Lib.Math.FindFunction(this);
                    break;
            }
        }
    }
}

