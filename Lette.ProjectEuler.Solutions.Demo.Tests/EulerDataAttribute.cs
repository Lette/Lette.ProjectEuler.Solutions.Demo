﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Lette.ProjectEuler.Core;
using Lette.ProjectEuler.Core.Runner;
using Xunit.Extensions;

namespace Lette.ProjectEuler.Solutions.Demo.Tests
{
    public class EulerDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo methodUnderTest, Type[] parameterTypes)
        {
            var builder = new ProblemSuiteBuilder();
            var suite = builder.CreateFromAssembly("Lette.ProjectEuler.Solutions.Demo.dll");

            foreach (var problem in suite)
            {
                problem.Prepare();
                var metadata = problem.GetMetaData();
                yield return new object[] { string.Format("{0,4}", metadata.Number), metadata.Description, metadata.Answer, problem.Solve() };
            }
        }
    }
}