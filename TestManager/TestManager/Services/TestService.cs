using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace TestManager.Services
{
    [Export(typeof (ITestService))]
    public class TestService : ITestService
    {
        [ImportMany(typeof (ITest))]
        public IEnumerable<ITest> Tests { get; set; }

        public virtual void RunTests()
        {
            foreach (var test in Tests)
            {
                var result = test.RunTest();
                throw new Exception(result.TestOkText + " " + result.Recommendation);
            }
        }
    }
}