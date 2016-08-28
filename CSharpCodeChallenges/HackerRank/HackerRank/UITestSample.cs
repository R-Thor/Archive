using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public static class UITestSample
    {
        public static string[] GetSampleData()
        {
            string[] SampleData = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < SampleData.Length; i++)
            {
                SampleData[i] = Console.ReadLine();
            }
            return (SampleData);
        }

        public static void WriteStringArray(string[] toWrite)
        {
            Console.WriteLine("Output of: public static void WriteStringArray(string[] toWrite)");
            for (int i = 0; i < toWrite.Length; i++)
			{
			    Console.WriteLine(string.Format("[{0}] \t\"{1}\"",i,toWrite[i]));

			}
        }
    }
}
