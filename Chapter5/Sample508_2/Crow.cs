namespace OneWeekCSharp.Chapter5.Sample508_2;

internal class Crow : Bird
{
    // コンストラクタ
    public Crow() : base("カラス")
    {
    }

    // オーバーライド
    // カラスが鳴く
    public override void Sing()
    {
        Console.WriteLine("カーカー");
    }
}
