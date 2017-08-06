using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class Problem3_LargestPrimeFactor
    {
        //TODO - Rewrite more efficiently.
        public static long GetResult()
        {
            long number = 600851475143;
            long largestFactor = 0;
            long[] factors = new long[2];

            for(long i = 2; i*i < number; i++) //Loop up to sqrt
            {
                if(number % i == 0) //Is a divisor
                {
                    factors[0] = i;
                    factors[1] = number / i;

                    for(int k = 0; k < 2; k++)
                    {
                        bool isPrime = true;
                        for(long j = 2; j*j < factors[k]; j++)
                        {
                            if(factors[k] % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if(isPrime && factors[k] > largestFactor)
                        {
                            largestFactor = factors[k];
                        }
                    }
                }
            }
            return largestFactor;
        }
    }
}
