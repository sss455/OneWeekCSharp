namespace OneWeekCSharp.Chapter4.ExampleProblem408
{
    internal class ExampleProblem408
    {
        static void Main(string[] args)
        {
            Console.Write("ビンゴのマスの縦・横のサイズを入力:");
            int size = int.Parse(Console.ReadLine());
            Bingo card = new Bingo(size);
            card.Show();
        }
    }
}
