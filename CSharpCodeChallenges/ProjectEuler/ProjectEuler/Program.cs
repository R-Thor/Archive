using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        //static long[] PrimeArray = null;//new long[0];
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            //Console.WriteLine(string.Format("SumOfMultiplesOf3and5Below(1000)={0}", SumOfMultiplesOf3and5Below(1000)));
            //Console.WriteLine(string.Format("EvenFibonacciNumbersSum(4000000)={0}", EvenFibonacciNumbersSum(4000000)));
            //Console.WriteLine(string.Format("LargestPrimeFactor(600851475143)={0}", LargestPrimeFactor(600851475143)));
            //Console.WriteLine(string.Format("LargestPalindromeProduct(3)={0}", LargestPalindromeProduct(3)));
            //Console.WriteLine(string.Format("SmallestMultiple(3)={0}", SmallestMultiple(1, 20)));
            //Console.WriteLine(string.Format("SumSquareDifference(1, 10)={0}", SumSquareDifference(1, 100)));
            //Console.WriteLine(string.Format("NthPrime(10001)={0}", NthPrime(10001)));
            //Console.WriteLine(string.Format("LargestProductInSeries("
            //    + "73167176531330624919225119674426574742355349194934"
            //    + "96983520312774506326239578318016984801869478851843"
            //    + "85861560789112949495459501737958331952853208805511"
            //    + "12540698747158523863050715693290963295227443043557"
            //    + "66896648950445244523161731856403098711121722383113"
            //    + "62229893423380308135336276614282806444486645238749"
            //    + "30358907296290491560440772390713810515859307960866"
            //    + "70172427121883998797908792274921901699720888093776"
            //    + "65727333001053367881220235421809751254540594752243"
            //    + "52584907711670556013604839586446706324415722155397"
            //    + "53697817977846174064955149290862569321978468622482"
            //    + "83972241375657056057490261407972968652414535100474"
            //    + "82166370484403199890008895243450658541227588666881"
            //    + "16427171479924442928230863465674813919123162824586"
            //    + "17866458359124566529476545682848912883142607690042"
            //    + "24219022671055626321111109370544217506941658960408"
            //    + "07198403850962455444362981230987879927244284909188"
            //    + "84580156166097919133875499200524063689912560717606"
            //    + "05886116467109405077541002256983155200055935729725"
            //    + "71636269561882670428252483600823257530420752963450"
            //    + ",13)={0}", LargestProductInSeries(
            //    "73167176531330624919225119674426574742355349194934"
            //    + "96983520312774506326239578318016984801869478851843"
            //    + "85861560789112949495459501737958331952853208805511"
            //    + "12540698747158523863050715693290963295227443043557"
            //    + "66896648950445244523161731856403098711121722383113"
            //    + "62229893423380308135336276614282806444486645238749"
            //    + "30358907296290491560440772390713810515859307960866"
            //    + "70172427121883998797908792274921901699720888093776"
            //    + "65727333001053367881220235421809751254540594752243"
            //    + "52584907711670556013604839586446706324415722155397"
            //    + "53697817977846174064955149290862569321978468622482"
            //    + "83972241375657056057490261407972968652414535100474"
            //    + "82166370484403199890008895243450658541227588666881"
            //    + "16427171479924442928230863465674813919123162824586"
            //    + "17866458359124566529476545682848912883142607690042"
            //    + "24219022671055626321111109370544217506941658960408"
            //    + "07198403850962455444362981230987879927244284909188"
            //    + "84580156166097919133875499200524063689912560717606"
            //    + "05886116467109405077541002256983155200055935729725"
            //    + "71636269561882670428252483600823257530420752963450"
            //    //+ "05886116467109405077541002256983155209999999999999"
            //    , 13)));

            //Console.WriteLine(string.Format("PythagoreanTriplet(1000)={0}", PythagoreanTripletProduct(1000)));
            Console.WriteLine(string.Format("SumOfPrimes(2000000)={0}", SumOfPrimes(2000000)));

            //Console.WriteLine(string.Format("LargestProductInAGrid("
            //    + "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\n"
            //    + "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\n"
            //    + "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\n"
            //    + "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\n"
            //    + "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\n"
            //    + "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\n"
            //    + "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70\n"
            //    + "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21\n"
            //    + "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72\n"
            //    + "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95\n"
            //    + "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\n"
            //    + "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\n"
            //    + "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\n"
            //    + "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\n"
            //    + "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\n"
            //    + "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\n"
            //    + "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\n"
            //    + "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\n"
            //    + "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\n"
            //    + "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48,4)\n"
            //    + "={0}"
            //    , LargestProductInAGrid("08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\n"
            //    + "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\n"
            //    + "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\n"
            //    + "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\n"
            //    + "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\n"
            //    + "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\n"
            //    + "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70\n"
            //    + "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21\n"
            //    + "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72\n"
            //    + "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95\n"
            //    + "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\n"
            //    + "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\n"
            //    + "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\n"
            //    + "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\n"
            //    + "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\n"
            //    + "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\n"
            //    + "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\n"
            //    + "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\n"
            //    + "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\n"
            //    + "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48\n"
            //    ,4)));
            //RecursivePrimes(2, 2000000);
            //RecursivePrimes(null, null, null);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        ////private static void RecursivePrimes(long currentTest, long Max)
        ////{
        ////    bool isPrime = true;

        ////    if (ProjectEuler.Program.PrimeArray == null)
        ////    {
        ////        ProjectEuler.Program.PrimeArray = new long[0];
        ////    }
        ////    long[] returnPrimes = ProjectEuler.Program.PrimeArray;
        ////    for (long i = 0; i < PrimeArray.Length; i++)
        ////    {
        ////        if (currentTest % PrimeArray[i] == 0)
        ////        {
        ////            isPrime = false;
        ////            break;
        ////        }
        ////    }
        ////    if (isPrime)
        ////    {
        ////        returnPrimes = new long[ProjectEuler.Program.PrimeArray.Length + 1];
        ////        for (long j = 0; j < ProjectEuler.Program.PrimeArray.Length; j++)
        ////        {
        ////            returnPrimes[j] = ProjectEuler.Program.PrimeArray[j];
        ////        }
        ////        returnPrimes[returnPrimes.Length - 1] = currentTest;
        ////        //Debug.WriteLine(currentTest);
        ////        ProjectEuler.Program.PrimeArray = returnPrimes;
        ////        returnPrimes = null;
        ////    }
            
        ////    if (currentTest < Max)
        ////    {
        ////        RecursivePrimes(++currentTest, Max);
        ////    }
            
        ////}
        private static long LargestProductInAGrid(string GridText,long length)
        {
            long LargestProductInAGrid = (from long l in GridProducts(GridText, length) select l).Max();

            return (LargestProductInAGrid);
        }
        private static IEnumerable<long> GridProducts(string Grid,long length)
        {
            string[][] GridTextArrayRows = Grid.Split(new char[] {'\n'},StringSplitOptions.RemoveEmptyEntries).Select(o => o.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)).ToArray();

            for(long row = 0; row<GridTextArrayRows.Length;row++)
            {
                for (long column = 0; column < GridTextArrayRows[row].Length; column++)
                {
                    bool RightSequencePossible = false;
                    bool LeftSequencePossible = false;
                    bool DownSequencePossible = false;
                    bool LeftDiaginalPossible = false;
                    bool RightDiaginalPossible = false;

                    System.Diagnostics.Debug.WriteLine(string.Format("{0},{1}",row,column));

                    if ((column + (length - 1)) < GridTextArrayRows[row].Length)
                    {//can go right
                        RightSequencePossible = true;
                    }
                    if ((column - (length - 1)) >= 0)
                    {//can go right
                        LeftSequencePossible = true;
                    }

                    if ((row + (length - 1)) < GridTextArrayRows.Length)
                    {//can go down
                        DownSequencePossible = true;
                    }
                    if (LeftSequencePossible && DownSequencePossible)
                    {
                        LeftDiaginalPossible = true;
                    }

                    if (RightSequencePossible && DownSequencePossible)
                    {
                        RightDiaginalPossible = true;
                    }
                    
                    if (RightSequencePossible)
                    {
                        long v = 1;
                        for (long c = 0; c < length; c++)
                        {
                            v*=long.Parse(GridTextArrayRows[row][c+column]);
                        }
                        yield return v;
                    }

                    if (DownSequencePossible)
                    {
                        long v = 1;
                        for (long r = 0; r < length; r++)
                        {
                            v *= long.Parse(GridTextArrayRows[r+row][column]);
                        }
                        yield return v;
                    }
                    if (RightDiaginalPossible)
                    {
                        long v = 1;
                        for (long r = 0, c = 0; r < length && c < length; r++, c++)
                        {
                            v *= long.Parse(GridTextArrayRows[r+row][c+column]);
                        }
                        yield return v;
                    }
                    if (LeftDiaginalPossible)
                    {
                        long v = 1;
                        for (long r = 0, c = 0; r < length && c < length; r++, c--)
                        {
                            v *= long.Parse(GridTextArrayRows[r + row][c + column]);
                        }
                        yield return v;
                    }                    

                }
            }
            yield return 1;
        }

        private static long SumOfPrimes(long p)
        {
            long SumOfPrimes = (from long l in Primes(p,2000000) where l < p select l).Sum();
            return (SumOfPrimes);
        }
        //private static IEnumerable<long> Primes(long limit)
        //{

        //    //long test = 0;
        //    long Ordinal = 0;
        //    //while (Ordinal <= limit)
        //    //{
        //    for (long test = 2; ; test++)
        //    {
        //        for (long expression = 2; expression <= test; expression++)
        //        {
        //            if (test % expression == 0)
        //            {
        //                if (test == expression)
        //                {
        //                    Ordinal++;
        //                    yield return test;
        //                    break;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        if (Ordinal == limit)
        //        {
        //            break;
        //        }
        //    }
        //    //}
        //}
        private static long PythagoreanTripletProduct(long Sum)
        {
            long pythagoreanTripletProduct = 1;

            long[] pythagoreanTriplet = PythagoreanTriplet(Sum).ToArray<long>();
            foreach (long item in pythagoreanTriplet)
            {
                pythagoreanTripletProduct *= item;
            }


            return (pythagoreanTripletProduct);
        }

        private static IEnumerable<long> PythagoreanTriplet(long Sum)
        {
            //long a = 0;
            //long b = 1;
            //long c = 2;

                for (long a = 0; a <= Sum; a++)
                {
                    for (long b = a+1; b <= Sum - (a); b++)
                    {
                        for (long c = b+1; c <= Sum-(a+b); c++)
                        {
                            //System.Diagnostics.Debug.WriteLine(string.Format("{0}+{1}+{2}={3}", a, b, c, a+b+c));
                            //System.Diagnostics.Debug.WriteLineIf(a + b + c == Sum, string.Format("{0}+{1}+{2}={3}", a, b, c, a + b + c));
                            //System.Diagnostics.Debug.WriteLineIf(a + b + c == Sum, string.Format("*********HIT*********** {0} = {1}", Math.Pow(a, 2) + Math.Pow(b, 2),Math.Pow(c, 2)));
                            if (a + b + c > Sum)
                            {
                                break;
                            }
                            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && a + b + c == Sum)
                            {
                                yield return a;
                                yield return b;
                                yield return c;
                                //yield break;
                            }
                        }
                    }
                }
        }
        private static long LargestProductInSeries(string Series, int ProductDigits)
        {
            char[] c_Series = Series.ToCharArray();
            long LargestProductInSeries = (from long l in Adjacent(Series, ProductDigits) select l).Max();
            return LargestProductInSeries;
        }
        private static IEnumerable<long> Adjacent(string Series, int ProductDigits)
        {
            char[] c_Series = Series.ToCharArray();
            for (int x = 0; x <= (c_Series.Length - ProductDigits); x++)
            {
                long product = 1;
                for (int y = x; y < ProductDigits+x; y++)
                {
                    int value = int.Parse(c_Series[y].ToString());
                    product *= value;
                }
                yield return product;
            }
            
        }
        private static long NthPrime(long p)
        {
            long NthPrime = (from long l in Primes(p,2000000) select l).Max();
            return (NthPrime);
        }
        private static long[] Primes(long limit, long max)
        {
            long[] PrimeArray = new long[0];
            for (long currentTest = 2; currentTest < limit; currentTest++)
            {
                bool isPrime = true;
                for (long i = 0; i < PrimeArray.Length; i++)
                {
                    if (currentTest % PrimeArray[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        if ((currentTest / PrimeArray[i]) < PrimeArray[i])
                        {
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    long[] returnPrimes = new long[PrimeArray.Length + 1];
                    for (long j = 0; j < PrimeArray.Length; j++)
                    {
                        returnPrimes[j] = PrimeArray[j];
                    }
                    returnPrimes[returnPrimes.Length - 1] = currentTest;
                    //Debug.WriteLineIf(currentTest % 100000 == 0, currentTest);
                    PrimeArray = returnPrimes;
                    returnPrimes = null;
                }
                Debug.WriteLineIf(currentTest % 100000 == 0, string.Format("currentTest={0},PrimeArray[{1}]={2}", currentTest, PrimeArray.Length, PrimeArray[PrimeArray.Length-1]));
            }
            return (PrimeArray);
            //long[] returnPrimes = ProjectEuler.Program.PrimeArray;

            //if (currentTest < Max)
            //{
            //    RecursivePrimes(++currentTest, Max);
            //}


            ////long test = 0;
            //long Ordinal = 0;
            ////while (Ordinal <= limit)
            ////{
            //for (long test = 2; ; test++)
            //{
            //    for (long expression = 2; expression <= test; expression++)
            //    {
            //        if (test % expression == 0)
            //        {
            //            if (test == expression)
            //            {
            //                Ordinal++;
            //                //yield return test;
            //                Console.WriteLine(test);
            //                break;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    if (Ordinal == limit || test >= max)
            //    {
            //        break;
            //    }
            //}

            ////}
        }


        //private static IEnumerable<long> Primes(long limit,long max)
        //{
        //    //long test = 0;
        //    long Ordinal = 0;
        //    //while (Ordinal <= limit)
        //    //{
        //        for (long test = 2; ; test++)
        //        {
        //            for (long expression = 2; expression <= test; expression++)
        //            {
        //                if (test % expression == 0)
        //                {
        //                    if (test == expression)
        //                    {
        //                        Ordinal++;
        //                        yield return test;
        //                        Console.WriteLine(test);
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            if (Ordinal == limit||test>=max)
        //            {
        //                break;
        //            }
        //        }
        //    //}
        //}
        private static long SumSquareDifference(long min, long max)
        {
            long SumOfSquares = (from long l in Sequence(min, max, 1) select (l*l)).Sum();
            long SquaresOfSum = (from long l in Sequence(min, max,1) select l).Sum();
            SquaresOfSum *= SquaresOfSum;
            return (SquaresOfSum - SumOfSquares);
        }
        private static IEnumerable<long> Sequence(long min, long max,long interval)
        {
            for (long number = min; number <= max; number += interval)
            {
                yield return number;
            }
        }

        //private static IEnumerable<long> Squares(long min, long max)
        //{
        //    for (long number = min; number <= max; number++)
        //    {
        //        yield return number * number;
        //    }
        //}

        private static long SmallestMultiple(int p, int p_2)
        {
            bool IsCommon = false;
            long smallestMulitiple = p_2;
            for (; !IsCommon; )
            {
                for (long check = p_2; check >= p; check--)
                {
                    if (smallestMulitiple % check != 0)
                    {
                        break;
                    }
                    if (check == p)
                    {
                        IsCommon = true;
                        break;
                    }
                    
                }
                if (!IsCommon)
                {
                    smallestMulitiple += p_2;
                }

            }
            return (smallestMulitiple);
        }

        private static long LargestPalindromeProduct(long productDigits)
        {
            long LargestPalindromeProduct = (from long l in PalindromeProducts(productDigits) select l).Max();
            return (LargestPalindromeProduct);          
        }
        private static IEnumerable<long> PalindromeProducts(long productDigits)
        {
            IEnumerable<string> e_number = Enumerable.Repeat("9", (int)productDigits + (int)productDigits);
            string s_number = ((productDigits + productDigits) > 0) ? e_number.Aggregate((sum, next) => sum + next) : "";
            int i_number = int.Parse(s_number);
            long product = 0;
            for (int x = i_number; i_number.ToString().Length == (productDigits + productDigits); i_number--)
            {
                s_number = i_number.ToString();

                long factor_1 = long.Parse(s_number.Substring(0, (int)productDigits));

                long factor_2 = long.Parse(s_number.Substring((int)productDigits, (int)productDigits));

                if (factor_1.ToString().Length < productDigits || factor_2.ToString().Length < productDigits)
                {
                    continue;
                }

                product = factor_1 * factor_2;
                string forward = product.ToString();
                string backward = new string(forward.ToCharArray().Reverse().ToArray<char>());
                if (forward == backward)
                {
                    yield return product;
                }
            }
        }
        private static long Factors(long Expression)
        {
            long LargestPrimeFactor = (from long l in PrimeFactors(Expression) select l).Max();
            return (LargestPrimeFactor);
        }
        private static long LargestPrimeFactor(long Expression)
        {
            long LargestPrimeFactor = (from long l in PrimeFactors(Expression) select l).Max();
            return (LargestPrimeFactor);
        }
        private static IEnumerable<long> PrimeFactors(long limit)
        {
            long test = 0;
            while (limit > 1)
            {
                for (; test <= limit; ++test)
                {
                    for (long expression = 1; expression <= test; expression++)
                    {
                        if (test % expression == 0 && expression != 1 && test != expression)
                        {
                            break;
                        }
                        if (test == expression)
                        {
                            if (limit % test == 0)
                            {
                                yield return test;
                                limit = limit / test;
                                if (test != 1)
                                {
                                    test = 1;
                                }
                                break;
                            }
                        }
                    }

                }
            }
            //foreach (long l in Primes)
            //{
            //    if (limit % l == 0)
            //    {
            //        System.Diagnostics.Debug.WriteLine(string.Format("Prime of {0} found: {1}", limit, l));
            //        yield return l;

            //    }
            //}
        }
        private static long EvenFibonacciNumbersSum(int limit)
        {
            long EvenFibonacciNumbersSum = (from long l in FibonacciSequence(limit) where l%2==0 select l).Sum();
            return (EvenFibonacciNumbersSum);
        }
        private static IEnumerable<long> FibonacciSequence(long limit)
        {
            long last = 1;
            yield return (last);
            long current = 2;
            yield return (current);
            long working = 0;

            while(true)
            {
                working = last + current;
                last = current;
                current = working;
                
                if (current > limit)
                {
                    yield break;
                }
                else
                {
                    yield return current;
                }
            }
            //for (long fs = start; fs < limit; fs++)
            //{

            //    yield return (fs);
            //}
        }
        private static long SumOfMultiplesOf3and5Below(long p)
        {
            long SumOfMultiplesOf3and5Below = (from long l in Multiples(p,new long[] { 3, 5 } ) select l).Sum();
            return (SumOfMultiplesOf3and5Below);
        }
        private static IEnumerable<long> Multiples(long limit,params long[] p)
        {
            for(long number = 1;number<limit;number++)
            {
                foreach(long l in p)
                {
                    if (number % l == 0)
                    {
                        System.Diagnostics.Debug.WriteLine(number.ToString());
                        yield return number;
                        break;
                    }
                }
            }
        }
    }
}
