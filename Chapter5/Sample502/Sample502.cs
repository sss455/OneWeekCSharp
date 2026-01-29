namespace OneWeekCSharp.Chapter5.Sample502;

internal class Sample502
{
    // ★staticなフィールド
    private static int snum = 100;
    // インスタンスフィールド
    public int inum = 200;


    // ★staticなメソッド
    public static void Foo()
    {
        Console.WriteLine("Fooメソッド(staticメソッド)");
    }

    // インスタンスメソッド
    public void Bar()
    {
        Console.WriteLine("Barメソッド(インスタンスメソッド)");
    }

    static void Main(string[] args)
    {
        // インスタンスの生成
        Sample502 p = new Sample502();
        Console.WriteLine("pのインスタンスフィールド:inum = {0}", p.inum);
        Console.WriteLine("Programのクラスフィールド:snum = {0}", snum); // ★

        Foo(); // ★
        p.Bar();
    }
}
