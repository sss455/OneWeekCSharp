namespace OneWeekCSharp.Chapter5.Sample511;

internal class Dummy : IFuncs1, IFuncs2  // 実装クラス
{
    public void Func1()
    {
        Console.WriteLine("Func1");
    }

    public void Func2()
    {
        Console.WriteLine("Func2");
    }

    public void Func3()
    {
        Console.WriteLine("Func3");
    }
}
