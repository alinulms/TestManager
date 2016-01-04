using System.ComponentModel.Composition;
using TestManager.Services;

namespace TestManager.Tests
{
    [Export(typeof (ITest))]
    internal class LoremIpsum : TestBase
    {
        public LoremIpsum() : base("Lorem ipsum hardcoded text", TestCategories.Code)
        {
        }

        public override TestResult RunTest()
        {
            return new TestResult
            {
                Recommendation = "THis is my recommendation",
                TestOkText = "Result is ok"
            };
        }
    }
}