using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ListBenchmark
{
    [MemoryDiagnoser]
    public class CollectionBenchmark
    {
        private ICollection<int> _collection = new int[1000];

        [Benchmark]
        public bool CollectionAnyMethod()
        {
            return _collection.Any();
        }

        [Benchmark]
        public bool CollectionCountProperty()
        {
            return _collection.Count != 0;
        }

        [Benchmark]
        public bool CollectionCountMethod()
        {
            return _collection.Count() != 0;
        }
    }
}