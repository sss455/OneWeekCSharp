namespace OneWeekCSharp.Chapter4.Sample406
{
    internal class Sample406
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();  //  引数なしのコンストラクタ
            p2 = new Person("太田隆", 29); //  引数ありのコンストラクタ
            p1.Name = "斉藤花子";
            p1.Age = 18;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
