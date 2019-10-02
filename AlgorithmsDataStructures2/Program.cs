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
            int a1 = 5 | 9;     //  13
            int a2 = 3 ^ 7;       // 4
            int a3 = 10 & 12;     // 8
            int a4 = 4 << 2;   // 16

            int b1 = -7 | 13;     // -3 
            int b2 = -8 ^ 5;   // -3
            int b3 = -10 & 3;   // 2
            int b4 = 12 >> 2;    // 3

            int c1 = -7 | -14;  // -5
            int c2 = -4 ^ -11;   // 9
            int c3 = -5 & -8;   // -8
            int c4 = -15 << 2;  // -60

            int d = -7 >> 2;   // -2


            float[] array = new float[30];
            float x = 0;

            for (int i = 0; i < 30; i++)
            {
                array[i] = 3 * x - (x * x);
                x += 0.1f;
            }
        }
    }
}
