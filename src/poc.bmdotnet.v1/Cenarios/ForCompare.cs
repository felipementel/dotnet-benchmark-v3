using BenchmarkDotNet.Attributes;
using System.Text;

namespace poc.bmdotnet.v1.Cenarios
{
    [RankColumn]
    [MemoryDiagnoser]
    public class ForCompare
    {
        [Benchmark]
        public void For_Normal()
        {
            IEnumerable<int> numeros = Enumerable.Range(0, 1000);

            for (int i = 0; i < numeros.Count(); i++)
            {
                Console.WriteLine(i);
            }
        }

        [Benchmark]
        public void ForEach()
        {
            IEnumerable<int> numeros = Enumerable.Range(0, 1000);
            StringBuilder sb;

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
