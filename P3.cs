using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class P3 : IEulerProblem
    {
        public string GetAnswer()
        {
            long inputNumber = 600851475143;

            var factors = GetNonTrivialFactors(inputNumber);

            return factors.First(i => IsPrime(i)).ToString();
        }

        private List<long> GetNonTrivialFactors(long number)
        {
            var factors = new List<long>();
            for (long i = Convert.ToInt64(Math.Sqrt(number)); i >=  2; i--)
            {
                if (number % i == 0)
                    factors.Add(i);
            }

            return factors;
        }

        private bool IsPrime(long number)
        {
            return !GetNonTrivialFactors(number).Any();
        }
    }
}
