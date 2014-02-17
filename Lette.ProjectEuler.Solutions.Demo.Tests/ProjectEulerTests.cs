using Xunit;
using Xunit.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo.Tests
{
    public class ProjectEulerTests
    {
        [Theory]
        [EulerData]
        public void RunProblems(string number, string description, long? expected, long actual)
        {
            Assert.True(expected.HasValue, "" + actual + " - Cannot verify - expected value is unknown.");
            Assert.Equal(expected, actual);
        }
    }
}