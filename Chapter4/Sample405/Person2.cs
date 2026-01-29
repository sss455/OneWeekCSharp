namespace OneWeekCSharp.Chapter4.Sample405;

internal class Person2
{
    // 名前
    public string? Name
    {
        private set; get;   // ★private
    }

    // 年齢
    public int Age
    {
        set; get;
    }

    // プロパティの設定
    public void SetAgeAndName(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // 情報の表示（メソッド）
    public void ShowAgeAndName()
    {
        Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
    }
}
