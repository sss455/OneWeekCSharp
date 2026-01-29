namespace OneWeekCSharp.Chapter2.ExampleProblem205_2;

internal class ExampleProblem205_2
{
    static void Main(string[] args)
    {
        // 文字列を入力
        Console.Write("文字列を入力:");
        string s = Console.ReadLine()!;

        if (s.Equals("Hello"))
        {
            Console.WriteLine("Helloが入力されました。");
        }
        else
        {
            Console.WriteLine("Helloと入力して下さい。");
        }
    }
}