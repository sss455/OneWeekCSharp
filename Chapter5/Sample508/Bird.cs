namespace OneWeekCSharp.Chapter5.Sample508;

// 抽象クラス
internal abstract class Bird
{
    //  名前フィールド
    private string name;


    //  引数つきコンストラクタ
    public Bird(string name)
    {
        this.name = name;
    }


    // 名前を取得
    public string Name
    {
        get { return name; }
    }

    //  鳴く（抽象メソッド）
    public abstract void Sing();
}
