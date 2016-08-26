```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-3740QM CPU 2.70GHz, ProcessorCount=8
Frequency=2630747 ticks, Resolution=380.1202 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=64-bit RELEASE [RyuJIT]
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1586.0

Type=Tests  Mode=Throughput  Platform=X64  
Jit=RyuJit  

```
   Method |      Median |     StdDev | Scaled | Scaled-SD |
--------- |------------ |----------- |------- |---------- |
 Numerics |  10.4559 ns |  0.1168 ns |   1.00 |      0.00 |
    Test1 |  77.7808 ns |  0.9867 ns |   7.46 |      0.12 |
    Test2 |  85.1327 ns |  0.3328 ns |   8.13 |      0.09 |
    Test3 |  48.8248 ns |  3.9134 ns |   4.91 |      0.37 |
    Test4 | 150.3237 ns | 26.2603 ns |  14.46 |      2.45 |
