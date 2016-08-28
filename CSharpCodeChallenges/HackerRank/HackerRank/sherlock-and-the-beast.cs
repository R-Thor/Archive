using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public static class sherlock_and_the_beast
    {
        public const string Fives = "555";
        public const string Threes = "33333";
        public static void Run()
        {
            string[] SampleData = UITestSample.GetSampleData();
#if DEBUG
            UITestSample.WriteStringArray(SampleData);
#endif
            //int Num5Segments = 0;
            for (int i = 0; i < SampleData.Length; i++)
            {
                int totalItemDigits = int.Parse(SampleData[i]);
                StringBuilder sb = new StringBuilder(totalItemDigits);
                int Max5s = totalItemDigits / 3;
                int WorkingMax5s = Max5s;
                int Simple5Remainder = totalItemDigits % 3;
                int workingSimple5Remainder = Simple5Remainder;

                //int Max3s = totalItemDigits / 5;
                //int Simple3Remainder = totalItemDigits % 5;
                int WorkingMax3s = 0;

                
                while (WorkingMax5s>0&&workingSimple5Remainder % 5 != 0)
                {
                    WorkingMax5s--;
                    workingSimple5Remainder += 3;
                    if ((workingSimple5Remainder % 5) == 0)
                    {
                        WorkingMax3s = workingSimple5Remainder / 5;
                    }
                }

                if (WorkingMax5s + WorkingMax3s != 0)
                {
                    for (; WorkingMax5s > 0; WorkingMax5s--)
                    {
                        sb.Append(Fives);
                    }
                    for (; WorkingMax3s > 0; WorkingMax3s--)
                    {
                        sb.Append(Threes);
                    }

                }
                else
                {
                    sb = new StringBuilder("-1");
                }

                Console.WriteLine(sb.ToString());
             }

        }
    }
}
