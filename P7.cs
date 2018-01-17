using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    public class P7 : IEulerProblem
    {
        public string GetAnswer()
        {
            var foundPrimes = 0;

            for (Int64 i = 2; i < Int64.MaxValue; i++)
            {
                if (IsPrime(i))
                    foundPrimes++;

                if (foundPrimes == 10001)
                    return i.ToString();
            }

            throw new Exception("didn't find anything!");
        }

        private bool IsPrime(long number)
        {
            for (int k = 2; k <= Math.Sqrt(number); k++)
            {
                if (number % k == 0)
                    return false;
            }

            return true;
        }
    }
}
