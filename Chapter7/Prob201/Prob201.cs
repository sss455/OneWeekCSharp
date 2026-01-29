namespace OneWeekCSharp.Chapter7.Prob201
{
    internal class Prob201
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数値を入力してください。");
            //  コンソールから整数値を入力
            int n = int.Parse(Console.ReadLine());
            //  nが4かどうかの判定は「n == 4」
            if (n == 4)
            {
                Console.WriteLine("4です。");
            }
        }
    }
}
