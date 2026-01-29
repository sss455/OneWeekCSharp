namespace OneWeekCSharp.Chapter5.ExampleProblem505;

internal class Mice : Mammals
{
    public Mice()
    {
        name = "ネズミ";
    }

    // オーバーライド
    // 吠える
    public override void Bark()
    {
        Console.WriteLine("チューチュー");
    }
}
