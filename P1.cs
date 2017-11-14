using Euler;

public class P1 : IEulerProblem
{
    public string GetAnswer()
    {
        var below = 1000;
        var sum = 0;

        for (int i = 0; i < below; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum.ToString();
    }
}