using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public static class the_love_letter_mystery
    {
        public static void Run()
        {
            string[] SampleData = UITestSample.GetSampleData();
            for (int x = 0; x < SampleData.Length; x++)
            {
                string workingTest = SampleData[x];
                int Changes = 0;
                while (!IsPalindrome(workingTest))
                {
                    char[] middleChar = FindMiddleChar(workingTest);

                    //if(workingTest.ToCharArray()[0] <workingTest.ToCharArray()[0]
                }
            }
            //if(!palindrome()
        }

        private static char[] FindMiddleChar(string workingTest)
        {
            char[] retValue = new char[1];
            int Remainder = workingTest.Length % 2;
            if (Remainder == 1)
            {
                retValue[0] = workingTest.ToCharArray()[((workingTest.Length / 2) + Remainder)-1];
            }
            else
            {
                retValue = new char[2];
                retValue[0] = workingTest.ToCharArray()[(workingTest.Length / 2)-1];
                retValue[1] = workingTest.ToCharArray()[(workingTest.Length / 2)];
            }
            return (retValue);
        }

        private static bool IsPalindrome(string workingTest)
        {
            return((workingTest.ToCharArray()==workingTest.ToCharArray().Reverse()));
        }
    }
}
