namespace OneWeekCSharp.Chapter3.ExampleProblem301_1;

internal class ExampleProblem301_1
{
    static void Main(string[] args)
    {
        Console.Write("*の数を入力:");
        // 整数値を入力
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
