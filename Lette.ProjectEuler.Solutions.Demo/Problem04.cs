using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;
using Lette.ProjectEuler.Math.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(4, "Find the largest palindrome made from the product of two 3-digit numbers.", 906609)]
    public class Problem4 : Problem
    {
        public override long Solve()
        {
            return
                900L.To(999).SelectMany(i => 900L.To(999).Select(j => i * j))
                    .Where(k => k.IsPalindromic())
                    .Max();
        }
    }
}