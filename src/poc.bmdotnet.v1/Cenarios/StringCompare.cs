using BenchmarkDotNet.Attributes;
using System.Text;

namespace poc.bmdotnet.v1.Cenarios
{
    [RankColumn]
    [MemoryDiagnoser]
    public class StringCompare
    {
        [Benchmark]
        public void StringConcat_Normal()
        {
            IEnumerable<int> numeros = Enumerable.Range(0, 1000);
            string valor = string.Empty;

            foreach (int i in numeros)
            {
                valor += i;
            }
        }

        [Benchmark]
        public void StringConcat_StringBuilder()
        {
            IEnumerable<int> numeros = Enumerable.Range(0, 1000);
            StringBuilder sb;
            sb = new StringBuilder();

            foreach (int i in numeros)
            {
                sb.Append(i);
            }
        }
    }
}
