namespace OneWeekCSharp.Chapter4.Sample404;

internal class Sample404
{
    static void Main(string[] args)
    {
        Access a = new Access();

        // a.Data1 = 1;（★読み取りオンリー）
        a.Data2 = 2;

        a.ShowDatas();

        Console.WriteLine("a.data1 = {0}", a.Data1);
        // Console.WriteLine("a.data2 = {0}", a.Data2);（★書き込みオンリー）
    }
}
