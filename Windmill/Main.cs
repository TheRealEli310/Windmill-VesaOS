using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill
{
    class Windmill
    {
        public byte[] program = new byte[]
        {
            0x11, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x01, 0x2c,
            0x11, 0x00, 0x00, 0x00, 0x04, 0x04, 0x00, 0x00, 0x00, 0x0F,
            0x41, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04,
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

