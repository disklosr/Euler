namespace Euler
{
    public class P5 : IEulerProblem
    {
        private const int DivisibileEvenlyUpToNumber = 20;

        public string GetAnswer()
        {
            int k = 1;
            int candidate = 1;

            while (true)
            {
                candidate = DivisibileEvenlyUpToNumber * k;
                if (IsDivisible(candidate))
                {
                    return candidate.ToString();
                }

                k++;
            }
        }

        private bool IsDivisible(int number)
        {
            for (int i = DivisibileEvenlyUpToNumber - 1; i >= 2; i--)
            {
                if (number % i != 0)
                    return false;
            }

            return true;
        }
    }
}