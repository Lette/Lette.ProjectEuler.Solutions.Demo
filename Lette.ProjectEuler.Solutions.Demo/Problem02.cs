using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(2, "Find the sum of all the even-valued terms in the Fibonacci sequence which do not exceed four million.", 4613732)]
    public class Problem2 : Problem
    {
        public override long Solve()
        {
            return
                Fibonacci.Sequence()
                    .TakeWhile(i => i <= 4000000)
                    .Where(i => i % 2 == 0)
                    .Sum();
        }
    }
}