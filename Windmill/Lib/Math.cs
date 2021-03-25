using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill.Lib
{
    static class Math
    {
        public static void Calculate(Windmill super)
        {
            int op = super.program[super.index] % 16;
            super.index++;

            int loc1 = Memory.GetRamLoc(super);
            int loc2 = Memory.GetRamLoc(super);

            switch (op)
            {
                case 0x00:
                    //add
                    break;
                case 0x01:
                    //substract
                    break;
                case 0x02:
                    //multiply
                    break;
                case 0x03:
                    //divide
                    break;
                case 0x04:
                    //modulus
                    break;
            }
        }
    }
}