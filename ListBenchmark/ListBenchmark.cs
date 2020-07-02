using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ListBenchmark
{
    [MemoryDiagnoser]
    public class ListBenchmark
    {
        private IList<int> _lista = new int[1000].ToList();

        [Benchmark]
        public bool ListAnyMethod()
        {
            return _lista.Any();
        }

        [Benchmark]
        public bool ListCountProperty()
        {
            return _lista.Count != 0;
        }

        [Benchmark]
        public bool ListCountMethod()
        {
            return _lista.Count() != 0;
        }
    }
}