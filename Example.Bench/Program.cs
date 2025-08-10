using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Example.Bench;

#pragma warning disable CA1822
public class BenchmarkTarget
{
    [Benchmark]
    public int Add()
    {
        int a = 5;
        int b = 3;
        return Func.Add(a, b);
    }

    [Benchmark]
    public int Sub()
    {
        int a = 5;
        int b = 3;
        return Func.Sub(a, b);
    }
}
#pragma warning restore CA1822

public static class Program
{
    public static void Main()
    {
        var _ = BenchmarkRunner.Run<BenchmarkTarget>();
    }
}
