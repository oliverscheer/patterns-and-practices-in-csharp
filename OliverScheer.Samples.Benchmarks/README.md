# Benchmarks

Used library: BenchmarkDotNet

## Run

```powershell
dotnet run --project OliverScheer.Samples.Benchmarks.csproj -c Release
```

## Result

| Method                          | Mean        | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|-------------------------------- |------------:|----------:|----------:|-------:|-------:|----------:|
| ForLoop                         |    25.68 ns |  0.116 ns |  0.108 ns |      - |      - |         - |
| WhileLoop                       |    25.58 ns |  0.141 ns |  0.118 ns |      - |      - |         - |
| ConcatStringsUsingStringBuilder | 1,134.97 ns | 22.387 ns | 26.650 ns | 1.0357 | 0.0172 |   13000 B |
| ConcatStringsUsingGenericList   |   613.85 ns | 12.183 ns | 28.717 ns | 0.5074 | 0.0114 |    6376 B |
