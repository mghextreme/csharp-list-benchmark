# Resultados

## List

|               Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------:|----------:|----------:|-------:|------:|------:|----------:|
|        ListMetodoAny | 13.840 ns | 0.2115 ns | 0.1766 ns | 0.0085 |     - |     - |      40 B |
| ListPropriedadeCount |  1.778 ns | 0.0169 ns | 0.0158 ns |      - |     - |     - |         - |
|      ListMetodoCount |  4.232 ns | 0.0291 ns | 0.0272 ns |      - |     - |     - |         - |

## Enumerable

|                Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|   EnumerableMetodoAny | 11.34 ns | 0.230 ns | 0.215 ns | 0.0068 |     - |     - |      32 B |
| EnumerableMetodoCount | 13.53 ns | 0.075 ns | 0.071 ns |      - |     - |     - |         - |

## Collection

|                     Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |----------:|----------:|----------:|-------:|------:|------:|----------:|
|        CollectionMetodoAny | 12.456 ns | 0.1061 ns | 0.0886 ns | 0.0068 |     - |     - |      32 B |
| CollectionPropriedadeCount |  1.850 ns | 0.0280 ns | 0.0262 ns |      - |     - |     - |         - |
|      CollectionMetodoCount | 14.366 ns | 0.2200 ns | 0.2160 ns |      - |     - |     - |         - |

## Array

|                 Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|         ArrayMetodoAny | 13.5348 ns | 0.2936 ns | 0.3381 ns | 0.0068 |     - |     - |      32 B |
| ArrayPropriedadeLength |  0.0000 ns | 0.0000 ns | 0.0000 ns |      - |     - |     - |         - |
|       ArrayMetodoCount | 14.2312 ns | 0.1376 ns | 0.1219 ns |      - |     - |     - |         - |
