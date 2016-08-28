using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime10001st
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Prime 10001 = {0}",GetPrime(10001)));
        }

        private static long GetPrime(long p)
        {
            long result = (from long l in Primes(p) select l).FirstOrDefault();
            return (result);
        }

        private static IEnumerable<long> Primes(long p)
        {
            long evaluation = 2;

            long ordinal = 0;
            for (;;)//long ordinal = 1; ordinal <= p; ordinal++)
            {
                
                for (long workingValue = 1; ordinal <= p; workingValue++)
                {
                    if ((evaluation % workingValue) == 0 && workingValue != evaluation && workingValue != 1)
                    {
                        //not Prime
                        break;
                    }


                    if (workingValue + 1 >= evaluation)
                    {
                        
                        ordinal++;
                        System.Diagnostics.Debug.WriteLine(string.Format("prime=({0},{1})", ordinal, evaluation));
                        if (ordinal == p)
                        {
                            yield return evaluation;
                        }
                        break;

                    }
                    if (ordinal == p)
                    {
                        yield break;
                    }

                }
                evaluation++;
            }
            
        }

    }
}
