namespace OneWeekCSharp.Chapter5.Sample504;

internal class Sub : Super // サブクラス（Superクラスを継承）
{
    // Subクラスのコンストラクタ
    public Sub()
    {
        Console.WriteLine("Subのコンストラクタ(引数なし)");
    }

    // Subクラスのコンストラクタ
    public Sub(int param) : base(param)
    {
        Console.WriteLine("Subのコンストラクタ(引数:param={0})", param);
    }
}
