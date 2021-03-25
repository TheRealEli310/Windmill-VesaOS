using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill.Lib
{
    static class Math
    {
        public static void FindFunction(Windmill super)
        {
            super.index++;
            switch (super.program[super.index - 1] % 16)
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