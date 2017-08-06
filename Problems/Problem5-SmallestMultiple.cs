using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem5_SmallestMultiple
    {
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        ///What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static long GetResult()
        {
            int[] modFactors = new int[20];
            for(int i = 1; i < modFactors.Length+1; i++)
            {
                modFactors[i-1] = i;
            }

            long k = modFactors.Length;
            while(true)
            {
                bool divisible = true;
                for(int j = 0; j < modFactors.Length; j++)
                {
                    if(k % modFactors[j] != 0)
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)
                {
                    return k;
                }
                k += modFactors.Length;
            }
        }
    }
}
