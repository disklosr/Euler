using Euler;

namespace Euler
{

    public class P2 : IEulerProblem
    {
        public string GetAnswer()
        {
            var below = 4000000;

            int next = 0, current = 2, previous = 1;
            int sum = current;

            while (next <= below)
            {
                next = current + previous;

                if (next % 2 == 0)
                    sum += next;

                previous = current;
                current = next;
            }

            return sum.ToString();
        }
    }
}