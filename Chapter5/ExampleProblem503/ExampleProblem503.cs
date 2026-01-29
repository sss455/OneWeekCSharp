namespace OneWeekCSharp.Chapter5.ExampleProblem503
{
    internal class ExampleProblem503
    {
        static void Main(string[] args)
        {
            Bingo card = new Bingo();
            Console.Write("ビンゴのマスの縦・横のサイズを入力:");
            int size = int.Parse(Console.ReadLine());
            card.Init(size);
            card.Show();
        }
    }
}
