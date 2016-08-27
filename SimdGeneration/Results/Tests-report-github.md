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
 Numerics |  20.1244 ns |  1.7449 ns |   1.00 |      0.00 |
    Test1 | 247.4501 ns |  1.5113 ns |  11.95 |      0.88 |
    Test2 | 178.7826 ns |  0.6580 ns |   8.59 |      0.63 |
    Test3 | 128.1278 ns |  0.6331 ns |   6.15 |      0.45 |
    Test4 | 240.8423 ns | 23.2574 ns |  11.63 |      1.39 |
