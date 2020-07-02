using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ListBenchmark
{
    [MemoryDiagnoser]
    public class ArrayBenchmark
    {
        private int[] _array = new int[1000];

        [Benchmark]
        public bool ArrayMetodoAny()
        {
            return _array.Any();
        }

        [Benchmark]
        public bool ArrayPropriedadeLenth()
        {
            return _array.Length != 0;
        }

        [Benchmark]
        public bool ArrayMetodoCount()
        {
            return _array.Count() != 0;
        }
    }
}