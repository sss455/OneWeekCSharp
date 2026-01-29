namespace OneWeekCSharp.Chapter7.Prob307
{
    internal class Prob307
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //  i+jが偶数であれば■、そうでなければ□を表示する
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
