using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(9, "Find the only Pythagorean triplet, {a, b, c}, for which a + b + c = 1000.", 31875000)]
    public class Problem9 : Problem
    {
        public override long Solve()
        {
            return
                PythagoreanTriplet.Sequence()
                    .Where(t => 1000 % (t.Item1 + t.Item2 + t.Item3) == 0)
                    .Select(t => new { Tuple = t, Multiplier = 1000 / (t.Item1 + t.Item2 + t.Item3) })
                    .Select(t =>
                        t.Tuple.Item1 * t.Multiplier
                        *
                        t.Tuple.Item2 * t.Multiplier
                        *
                        t.Tuple.Item3 * t.Multiplier)
                    .First();
        }
    }
}