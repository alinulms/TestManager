namespace TestManager.Services
{
    public abstract class TestBase : ITest
    {
        protected const string HardcodedText = "Hardcoded text";

        protected TestBase(string name, TestCategories categories)
        {
            Name = name;
            Category = categories;
        }

        public string Name { get; }
        public TestCategories Category { get; }
        public abstract TestResult RunTest();
    }
}