This repo is to support my question: https://stackoverflow.com/questions/66477084/weird-performance-behavior-of-net-dictionary-insertion?noredirect=1#comment117522643_66477084

Results on my machine:
```
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


|   Method |    Mean |    Error |   StdDev |
|--------- |--------:|---------:|---------:|
| TestBoth | 1.269 s | 0.0222 s | 0.0208 s |
|  TestOne | 1.381 s | 0.0257 s | 0.0241 s |
```
