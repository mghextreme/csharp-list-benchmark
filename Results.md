# Results

## List

|            Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |----------:|----------:|----------:|-------:|------:|------:|----------:|
|     ListAnyMethod | 13.840 ns | 0.2115 ns | 0.1766 ns | 0.0085 |     - |     - |      40 B |
| ListCountProperty |  1.778 ns | 0.0169 ns | 0.0158 ns |      - |     - |     - |         - |
|   ListCountMethod |  4.232 ns | 0.0291 ns | 0.0272 ns |      - |     - |     - |         - |

## Enumerable

|                Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|   EnumerableAnyMethod | 11.34 ns | 0.230 ns | 0.215 ns | 0.0068 |     - |     - |      32 B |
| EnumerableCountMethod | 13.53 ns | 0.075 ns | 0.071 ns |      - |     - |     - |         - |

## Collection

|                  Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |----------:|----------:|----------:|-------:|------:|------:|----------:|
|     CollectionAnyMethod | 12.456 ns | 0.1061 ns | 0.0886 ns | 0.0068 |     - |     - |      32 B |
| CollectionCountProperty |  1.850 ns | 0.0280 ns | 0.0262 ns |      - |     - |     - |         - |
|   CollectionCountMethod | 14.366 ns | 0.2200 ns | 0.2160 ns |      - |     - |     - |         - |

## Array

|              Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|      ArrayAnyMethod | 13.5348 ns | 0.2936 ns | 0.3381 ns | 0.0068 |     - |     - |      32 B |
| ArrayLengthProperty |  0.0000 ns | 0.0000 ns | 0.0000 ns |      - |     - |     - |         - |
|    ArrayCountMethod | 14.2312 ns | 0.1376 ns | 0.1219 ns |      - |     - |     - |         - |
