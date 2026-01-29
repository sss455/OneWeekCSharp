namespace OneWeekCSharp.Chapter4.Sample405;

internal class Sample405
{
    static void Main(string[] args)
    {
        Person2 p = new Person2();
        // p.Name = "佐藤花子";           // 名前の変更(できない)★
        p.Age = 32;                       // 年齢の変更
        p.SetAgeAndName("山田太郎", 26);  // 名前と年齢を設定

        // 名前と年齢の表示
        Console.WriteLine("名前：{0} 年齢:{1}", p.Name, p.Age);
    }
}
