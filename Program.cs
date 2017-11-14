using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            IEulerProblem[] problems = { new P1(), new P2(), new P3() };

            Func<IEulerProblem, string> method = problem => problem.GetAnswer().ToString();

            WriteHeader();

            foreach (var problem in problems)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result = method(problem);
                watch.Stop();

                var executionTime = $"{watch.Elapsed.Minutes}m {watch.Elapsed.Seconds}s {watch.Elapsed.Milliseconds}ms";
                Console.WriteLine($"{problem.GetType().Name.PadRight(10)}{result.PadRight(15)}{executionTime.PadRight(30)}");
            }

            Console.ReadKey();
        }

        private static void WriteHeader()
        {
            Console.WriteLine($"{"Problem".PadRight(10)}{"Answer".PadRight(15)}{"Time".PadRight(30)}");
            Console.WriteLine($"{"-------".PadRight(10)}{"------".PadRight(15)}{"----".PadRight(30)}");
        }
    }
}