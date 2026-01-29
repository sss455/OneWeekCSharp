namespace OneWeekCSharp.Chapter3.ExampleProblem301_3;

internal class ExampleProblem301_3
{
    static void Main(string[] args)
    {
        Console.Write("*の数を入力:");
        // 整数値を入力
        int n = int.Parse(Console.ReadLine()!);


        // nが0より大きい場合のみ、do～whileループを実行する
        if (n > 0)
        {
            int i = 0;
            do
            {
                Console.Write("*");
                i++;
            }
            while (i < n);
            Console.WriteLine();
        }
    }
}
