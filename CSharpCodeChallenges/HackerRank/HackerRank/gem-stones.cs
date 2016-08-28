using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public static class gem_stones
    {

        internal static void Run()
        {
            int sampleCountInt = int.Parse(Console.ReadLine());
            char[] baseElements = GetDistinctElements(Console.ReadLine().ToCharArray());
            for (int passcounter = 0; passcounter < sampleCountInt - 1; passcounter++)
            {
                baseElements = AndElementsArray(baseElements, GetDistinctElements(Console.ReadLine().ToCharArray()));
            }
            Console.WriteLine(baseElements.Length.ToString());
        }

        private static char[] AndElementsArray(char[] baseElements, char[] TestSample)
        {
            string andElementsString = string.Empty;
            for (int baseCounter = 0; baseCounter < baseElements.Length; baseCounter++)
            {
                for (int testCounter = 0; testCounter < TestSample.Length; testCounter++)
                {
                    if (baseElements[baseCounter] == TestSample[testCounter])
                    {
                        andElementsString+= baseElements[baseCounter].ToString();
                    }
                }
            }


            return (andElementsString.ToCharArray());
        }
        private static char[] GetDistinctElements(char[] Elements)
        {
            char[] distinctElements = new char[0];

            for (int x = 0; x < Elements.Length; x++)
            {
                if (distinctElements.Length == 0 || IsDistinctPotentialGem(distinctElements, Elements[x]))
                {
                    char[] TempPotentialGems = new char[distinctElements.Length + 1];
                    for (int y = 0; y < distinctElements.Length; y++)
                    {
                        TempPotentialGems[y] = distinctElements[y];
                    }
                    TempPotentialGems[TempPotentialGems.Length - 1] = Elements[x];
                    distinctElements = TempPotentialGems;
                }
            }
            return (distinctElements);
        }
        private static bool IsDistinctPotentialGem(char[] PotentialGems, char TestElement)
        {
            bool isDistinctPotentialGem = true;
            for (int x = 0; x < PotentialGems.Length; x++)
            {
                
                if ((TestElement == PotentialGems[x]))
                {
                    isDistinctPotentialGem = false;
                    break;
                }
            }
            return (isDistinctPotentialGem);
        }
    }
}
