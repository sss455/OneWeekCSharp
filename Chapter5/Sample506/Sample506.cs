namespace OneWeekCSharp.Chapter5.Sample506;

internal class Sample506
{
    public void Foo()
    {
        Console.WriteLine("Foo");
    }

    static void Main(string[] args)
    {
        Sample506 s = new Sample506();
        Console.WriteLine(s.ToString());
        // 出力結果: OneWeekCSharp.Chapter5.Sample506.Sample506
    }
}