namespace OneWeekCSharp.Chapter7.Prob304
{
    internal class Prob304
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int n = int.Parse(Console.ReadLine());
            //  2の倍数
            Console.WriteLine("2の倍数");
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //  3の倍数
            Console.WriteLine("3の倍数");
            for (int i = 3; i <= n; i += 3)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //  5の倍数
            Console.WriteLine("5の倍数");
            for (int i = 5; i <= n; i += 5)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
