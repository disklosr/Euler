using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public class P4 : IEulerProblem
    {
        private const ushort numberOfDigits = 3;

        private readonly uint upperBound = (uint) Math.Pow(10, numberOfDigits) - 1;
        private readonly uint lowerBound = (uint) Math.Pow(10, numberOfDigits - 1);

        public string GetAnswer()
        {
            uint biggestSolutionSoFar = 0;

            for (uint i = upperBound; i >= lowerBound; i--)
            {
                for (uint j = upperBound; j >= lowerBound; j--)
                {
                    if (IsPalindrom(i * j) && i * j > biggestSolutionSoFar)
                        biggestSolutionSoFar = i * j;
                }
            }

            return biggestSolutionSoFar.ToString();
        }

        private bool IsPalindrom(uint number)
        {
            return new string(number.ToString().Reverse().ToArray()).Equals(number.ToString());
        }
    }
}
