namespace OneWeekCSharp.Chapter4.Sample403
{
    internal class Sample403
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            //  1つ目のPersonクラスのメソッドのインスタンスを生成
            p1 = new Person();
            //  2つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();
            p1.Name = "山田太郎";   //  フィールドnameに値を代入        
            p1.Age = 19;            //  フィールドageに値を代入
            //  setAgeAndName()メソッドで、nameとageを設定
            p2.SetAgeAndName("佐藤花子", 23);
            //  メソッドから、名前と年齢を表示
            p1.ShowAgeAndName();
            //  プロパティから名前と年齢を表示
            Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
        }
    }
}
