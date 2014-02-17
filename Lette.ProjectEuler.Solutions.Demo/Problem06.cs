using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(6, "What is the difference between the sum of the squares and the square of the sums?", 25164150)]
    public class Problem6 : Problem
    {
        public override long Solve()
        {
            return
                1L.To(100).Aggregate(0L, (i, j) => i + j, i => i * i)
                -
                1L.To(100).Aggregate(0L, (i, j) => i + j * j);
        }
    }
}