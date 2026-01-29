namespace OneWeekCSharp.Chapter5.Sample507;

internal class Crow
{
    private string name = "カラス";

    // 名前を取得
    public string Name
    {
        get { return name; }
    }

    // カラスが鳴く
    public void Sing()
    {
        Console.WriteLine("カーカー");
    }
}
