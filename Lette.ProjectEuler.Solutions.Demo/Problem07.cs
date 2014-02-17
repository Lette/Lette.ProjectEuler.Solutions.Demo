using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(7, "Find the 10001st prime.", 104743)]
    public class Problem7 : Problem
    {
        public override long Solve()
        {
            return
                Primes.Sequence().Skip(10000).First();
        }
    }
}