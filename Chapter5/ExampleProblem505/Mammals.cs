namespace OneWeekCSharp.Chapter5.ExampleProblem505;

// 抽象クラス
internal abstract class Mammals
{
    // 名前
    protected string name = "";

    // 抽象メソッド
    // 吠える
    public abstract void Bark();

    // 名前を表示する
    public void ShowName()
    {
        Console.WriteLine("名前:{0}", name);
    }
}
