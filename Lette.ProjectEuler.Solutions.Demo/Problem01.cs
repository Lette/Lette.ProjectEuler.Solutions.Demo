using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(1, "Add all the natural numbers below one thousand that are multiples of 3 or 5.", 233168)]
    public class Problem1 : Problem
    {
        public override long Solve()
        {
            return
                1L.To(999)
                    .Where(i => i % 3 == 0 || i % 5 == 0)
                    .Sum();
        }
    }
}