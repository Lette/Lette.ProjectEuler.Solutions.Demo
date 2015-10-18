using Lette.ProjectEuler.Core.XUnit;
using Xunit;

namespace Lette.ProjectEuler.Solutions.Demo.Tests
{
    public class ProjectEulerTests
    {
        [Theory]
        [EulerData("Lette.ProjectEuler.Solutions.Demo.dll")]
        public void RunProblems(string number, string description, long? expected, long actual)
        {
            Assert.True(expected.HasValue, "" + actual + " - Cannot verify - expected value is unknown.");
            Assert.Equal(expected, actual);
        }
    }
}