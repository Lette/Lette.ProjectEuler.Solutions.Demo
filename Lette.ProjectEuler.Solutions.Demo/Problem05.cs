using System.Linq;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Math;
using Lette.ProjectEuler.Math.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo
{
    [Euler(5, "What is the smallest number divisible by each of the numbers 1 to 20?", 232792560)]
    public class Problem5 : Problem
    {
        public override long Solve()
        {
            return
                1L.To(20)
                    .SelectMany(i => i.Factors().GroupBy(g => g))
                    .GroupBy(g => g.Key)
                    .Select(g => g.OrderBy(h => h.Count()).Last())
                    .SelectMany(g => g)
                    .Aggregate(1L, (i, j) => i * j);
        }
    }
}

/*

Example up to 10:

To  Factors  GroupBy    SelectMany  GroupBy                           OrderBy-Count                     Select-Last  SelectMany  Aggregate

1   1        {1}        1           {1}                               {1}                               {1}          1           2520
2   2        {2}        2           {2}, {2, 2}, {2}, {2, 2, 2}, {2}  {2}, {2}, {2}, {2, 2}, {2, 2, 2}  {2, 2, 2}    2
3   3        {3}        3           {3}, {3}, {3, 3}                  {3}, {3}, {3, 3}                  {3, 3}       2
4   2, 2     {2, 2}     2, 2        {5}, {5}                          {5}, {5}                          {5}          2
5   5        {5}        5           {7}                               {7}                               {7}          3
6   2, 3     {2}, {3}   2                                                                                            3
7   7        {7}        3                                                                                            5
8   2, 2, 2  {2, 2, 2}  7                                                                                            7
9   3, 3     {3, 3}     2, 2, 2
10  2, 5     {2}, {5}   3, 3
                        2
                        5
*/