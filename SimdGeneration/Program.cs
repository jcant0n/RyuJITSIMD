using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

//using System.Numerics;
//using Test1;
//using Test2;
//using Test3;
using Test4;

namespace SimdGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var RyuJit = ManualConfig
                            .Create(DefaultConfig.Instance)
                            .With(Job.RyuJitX64);

            var AllJits = ManualConfig
                            .Create(DefaultConfig.Instance)
                            .With(Job.AllJits);

            BenchmarkRunner.Run<Tests>(RyuJit);
        }
    }
}
