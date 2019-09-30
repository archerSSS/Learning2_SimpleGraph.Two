using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a1 = 5 | 3;     //  7
            int a2 = 10 ^ 7;       // 13
            int a3 = 6 & 12;     // 4
            int a4 = 4 << 2;   // 16

            int b1 = -13 | 8;     // -5
            int b2 = -5 ^ 11;   // -16
            int b3 = -3 & 14;   // 12
            int b4 = 6 >> 2;    // 1

            int c1 = -9 | -13;  // -9
            int c2 = -3 ^ -5;   // 6
            int c3 = -10 & -4;   // -12
            int c4 = -11 << 2;  // -44

            int d = -13 >> 2;   // -4
        }
    }
}
