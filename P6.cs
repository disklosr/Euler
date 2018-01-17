using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public class P6 : IEulerProblem
    {
        public string GetAnswer()
        {
            int param = 100;

            checked
            {
                var sumSquare = Math.Pow(param * (param + 1) / 2, 2);
                var squareSum = Enumerable.Range(1, param).Select(i => Math.Pow(i, 2)).Sum();
                return (sumSquare - squareSum).ToString();
            }            
        }
    }
}
