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
        public bool ListMetodoAny()
        {
            return _lista.Any();
        }

        [Benchmark]
        public bool ListPropriedadeCount()
        {
            return _lista.Count != 0;
        }

        [Benchmark]
        public bool ListMetodoCount()
        {
            return _lista.Count() != 0;
        }
    }
}