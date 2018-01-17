using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            var problems = LoadAllProblems();

            Func<IEulerProblem, string> method = problem => problem.GetAnswer().ToString();

            WriteHeader();

            foreach (var problem in problems)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result = method(problem);
                watch.Stop();

                var executionTime = $"{watch.Elapsed.Minutes}m {watch.Elapsed.Seconds}s {watch.Elapsed.Milliseconds}ms";
                Console.WriteLine($"{problem.GetType().Name.PadRight(10)}{result.PadRight(30)}{executionTime.PadRight(30)}");
            }

            Console.ReadKey();
        }

        private static void WriteHeader()
        {
            Console.WriteLine($"{"Problem".PadRight(10)}{"Answer".PadRight(30)}{"Time".PadRight(30)}");
            Console.WriteLine($"{"-------".PadRight(10)}{"------".PadRight(30)}{"----".PadRight(30)}");
        }
        
        private static IReadOnlyCollection<IEulerProblem> LoadAllProblems()
        {
            var type = typeof(IEulerProblem);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface)
                .OrderByDescending(t => t.Name)
                .Select(t => (IEulerProblem) Activator.CreateInstance(t))
                .ToList();
        }
    }
}