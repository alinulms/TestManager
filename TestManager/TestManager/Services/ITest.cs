namespace TestManager.Services
{
    public interface ITest
    {
        string Name { get; }

        TestCategories Category { get; }

        TestResult RunTest();
    }
}