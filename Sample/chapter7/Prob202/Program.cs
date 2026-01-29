namespace Prob202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数値を入力してください。");
            //  コンソールから整数値を入力
            int n = int.Parse(Console.ReadLine());
            //  nが0かどうかの判定は「n == 0」
            if (n == 0)
            {
                Console.WriteLine("0です。");
            }
            else
            {
                Console.WriteLine("0ではありません。");
            }
        }
    }
}
