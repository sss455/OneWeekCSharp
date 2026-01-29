namespace OneWeekCSharp.Chapter5.Sample508_2;

internal class Sparrow : Bird
{
    // コンストラクタ
    public Sparrow() : base("すずめ")
    {
    }

    // オーバーライド
    // すずめが鳴く
    public override void Sing()
    {
        Console.WriteLine("チュンチュン");
    }
}