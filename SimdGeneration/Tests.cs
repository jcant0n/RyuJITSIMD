using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimdGeneration
{
    public class Tests
    {
        private System.Numerics.Vector4 a0, a1;
        private Test1.Vector4 b0, b1;
        private Test2.Vector4 c0, c1;
        private Test3.Vector4 d0, d1;
        private Test4.Vector4 e0, e1;

        public Tests()
        {
            System.Random r = new System.Random();

            a0 = new System.Numerics.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            a1 = new System.Numerics.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

            b0 = new Test1.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            b1 = new Test1.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

            c0 = new Test2.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            c1 = new Test2.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

            d0 = new Test3.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            d1 = new Test3.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

            e0 = new Test4.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            e1 = new Test4.Vector4((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
        }

        [Benchmark(Baseline = true)]
        public System.Numerics.Vector4 Numerics()
        {
            return a0 * a1 * a0 * a1 * a0 * a1 * a0 * a1 * a0 * a1 * a0 * a1;
        }

        [Benchmark]
        public Test1.Vector4 Test1()
        {
            return b0 * b1 * b0 * b1 * b0 * b1 * b0 * b1 * b0 * b1 * b0 * b1;
        }

        [Benchmark]
        public Test2.Vector4 Test2()
        {
            return c0 * c1 * c0 * c1 * c0 * c1 * c0 * c1 * c0 * c1 * c0 * c1;
        }

        [Benchmark]
        public Test3.Vector4 Test3()
        {
            return d0 * d1 * d0 * d1 * d0 * d1 * d0 * d1 * d0 * d1 * d0 * d1;
        }

        [Benchmark]
        public Test4.Vector4 Test4()
        {
            return e0 * e1 * e0 * e1 * e0 * e1 * e0 * e1 * e0 * e1 * e0 * e1;
        }
    }
}
