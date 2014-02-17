using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(3, "Find the largest prime factor of a composite number.", 6857)]
    public class Problem3 : Problem
    {
        public override long Solve()
        {
            return 600851475143L
                .Factors()
                .Last();
        }
    }
}