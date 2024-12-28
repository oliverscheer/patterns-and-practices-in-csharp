using BenchmarkDotNet.Attributes;
using System.Text;

namespace OliverScheer.Samples.PeriodicElementNameGenerator;

[MemoryDiagnoser]
public class LoopBenchmarks
{
    const int NumberOfItems = 100;

    [Benchmark]
    public void ForLoop()
    {
        int sum = 0;
        for (int i = 0; i < NumberOfItems; i++)
        {
            sum += i;
            //Console.WriteLine(i);
        }
        //Console.WriteLine($"ForLoop Sum: {sum}");
    }

    [Benchmark]
    public void WhileLoop()
    {
        int currentValue = NumberOfItems;
        int sum = 0;
        while (currentValue > 0)
        {
            sum += currentValue;
            currentValue--;
        }
        //Console.WriteLine($"WhileLoop Sum: {sum}");
    }

    [Benchmark]
    public string ConcatStringsUsingStringBuilder()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < NumberOfItems; i++)
        {
            sb.Append("Hello World!" + i);
        }
        return sb.ToString();
    }

    [Benchmark]
    public string ConcatStringsUsingGenericList()
    {
        var list = new List<string>(NumberOfItems);
        for (int i = 0; i < NumberOfItems; i++)
        {
            list.Add("Hello World!" + i);
        }
        return list.ToString();
    }
}
