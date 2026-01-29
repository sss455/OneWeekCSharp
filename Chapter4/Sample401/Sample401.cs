namespace OneWeekCSharp.Chapter4.Sample401;

internal class Sample401
{
    static void Main(string[] args)
    {
        // Personクラスのインスタンスを２つ生成
        Person p1, p2;
        p1 = new Person();
        p2 = new Person();

        p1.name = "山田太郎";   // フィールドnameに値を代入
        p1.age = 19;            // フィールドageに値を代入

        // メソッドでnameとageを設定
        p2.SetAgeAndName("佐藤花子", 23);

        // それぞれのインスタンスのnameとageを表示
        p1.ShowAgeAndName();
        p2.ShowAgeAndName();
    }
}
