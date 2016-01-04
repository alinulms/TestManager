using System.Collections.Generic;

namespace TestManager.Services
{
    public interface ITestService
    {
        IEnumerable<ITest> Tests { get; }

        void RunTests();
    }
}