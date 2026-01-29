namespace OneWeekCSharp.Chapter4.ExampleProblem405;

internal class ExampleProblem405
{
    static void Main(string[] args)
    {
        Console.Write("文字列を入力してください:");
        string str = Console.ReadLine()!;

        Console.WriteLine("文字列の長さ:{0}", str.Length);
    }
}
