namespace OneWeekCSharp.Chapter5.Sample505;

internal class Sample505
{
    static void Main(string[] args)
    {
        // Parentクラスのインスタンス生成
        Parent p = new Parent();

        // Childクラスのインスタンス生成
        Parent c = new Child();

        // それぞれのクラスのFooメソッドを実行
        p.Foo();
        c.Foo();
    }
}