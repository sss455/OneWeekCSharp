namespace OneWeekCSharp.Chapter5.ExampleProblem503;

internal class ExampleProblem503
{
    static void Main(string[] args)
    {
        Console.Write("ビンゴのマスの縦・横のサイズを入力:");
        int size = int.Parse(Console.ReadLine()!);

        Bingo card = new Bingo();
        card.Init(size);
        card.Show();
    }
}
