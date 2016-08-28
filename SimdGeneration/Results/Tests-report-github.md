```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-3740QM CPU 2.70GHz, ProcessorCount=8
Frequency=2630753 ticks, Resolution=380.1193 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=64-bit RELEASE [RyuJIT]
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1586.0

Type=Tests  Mode=Throughput  Platform=X64  
Jit=RyuJit  

```
   Method |      Median |     StdDev | Scaled | Scaled-SD |
--------- |------------ |----------- |------- |---------- |
 Numerics |  20.4808 ns | 65.8805 ns |   1.00 |      0.00 |
    Test1 | 249.0435 ns |  1.1672 ns |   9.55 |      4.55 |
    Test2 | 178.5769 ns |  2.0455 ns |   6.88 |      3.28 |
    Test3 | 172.1063 ns |  1.5593 ns |   6.57 |      3.13 |
    Test4 | 238.0992 ns | 23.2908 ns |   9.18 |      4.48 |
