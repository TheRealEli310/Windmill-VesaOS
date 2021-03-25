using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill.Lib
{
    static class Math
    {
        public static void CalculateByte(Windmill super)
        {
            int op = super.program[super.index] % 16;
            super.index++;

            int loc1 = Memory.GetRamLoc(super);
            super.index++;
            int loc2 = Memory.GetRamLoc(super); 

            switch (op)
            {
                case 0x00:
                    super.ram[loc1] += super.ram[loc2];
                    break;
                case 0x01:
                    super.ram[loc1] -= super.ram[loc2];
                    break;
                case 0x02:
                    super.ram[loc1] *= super.ram[loc2];
                    break;
                case 0x03:
                    super.ram[loc1] /= super.ram[loc2];
                    break;
                case 0x04:
                    super.ram[loc1] %= super.ram[loc2];
                    break;
            }
        }
    }
}
