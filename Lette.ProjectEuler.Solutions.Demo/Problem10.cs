using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(10, "Calculate the sum of all the primes below two million.", 142913828922L)]
    public class Problem10 : Problem
    {
        public override long Solve()
        {
            return
                Primes.Sequence()
                    .TakeWhile(p => p < 2000000)
                    .Sum();
        }
    }
}