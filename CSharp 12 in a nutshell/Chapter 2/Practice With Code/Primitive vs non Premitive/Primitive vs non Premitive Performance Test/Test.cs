using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_vs_non_Premitive_Performance_Test
{
    public class Test
    {
        [Benchmark]
        public int IntTest()
        {
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {
                x += 1;
            }
            return x;
        }

        [Benchmark]
        public decimal DecimalTest()
        {
            decimal x = 0;
            for (int i = 0; i < 1000; i++)
            {
                x += 1;
            }
            return x;
        }
    }
}
