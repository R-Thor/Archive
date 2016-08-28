using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public static class utopian_tree
    {
        internal static void Run()
        {
            int TestCases = int.Parse(Console.ReadLine());
            int[,] Cycles = new int[TestCases,2];
            for (int x = 0; x < TestCases; x++)
            {
                Cycles[x,0] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < TestCases; x++)
            {
                int size = 1;
                for (int y = 0; y < Cycles[x, 0]; y++)
                {
                    switch ((y) % 2)
                    {
                        case 0:
                            size *= 2;
                            break;
                        case 1:
                            size ++;
                            break;
                    }
                }
                Cycles[x, 1] = size;
            }
            for (int x = 0; x < TestCases; x++)
            {
                Console.WriteLine(Cycles[x, 1].ToString());
            }
        }
    }
}
