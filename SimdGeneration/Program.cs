﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

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
