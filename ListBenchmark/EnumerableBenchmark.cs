using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ListBenchmark
{
    [MemoryDiagnoser]
    public class EnumerableBenchmark
    {
        private IEnumerable<int> _enumerable = new int[1000];

        [Benchmark]
        public bool EnumerableMetodoAny()
        {
            return _enumerable.Any();
        }

        [Benchmark]
        public bool EnumerableMetodoCount()
        {
            return _enumerable.Count() != 0;
        }
    }
}