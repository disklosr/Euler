using System;

namespace Euler
{
    public class P9 : IEulerProblem
    {
        private int a, b;

        public string GetAnswer()
        {
            BruteForce();
            return (a * b * (1000 - a - b)).ToString();
        }

        private void BruteForce()
        {
            for (a = 1; a < 1000; a++)
            {
                for (b = a; b < 1000; b++)
                {
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow((1000 - a - b), 2))
                        return;
                }
            }
        }
    }
}