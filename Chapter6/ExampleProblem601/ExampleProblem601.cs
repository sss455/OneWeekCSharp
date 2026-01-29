namespace OneWeekCSharp.Chapter6.ExampleProblem601
{
    internal class ExampleProblem601
    {
        static void Main(string[] args)
        {
            //  数値を入れるリストを作成する
            List<int> array = new List<int>();
            while (true)
            {
                Console.Write("正の整数を入力してください:");
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    //  正の整数だったら、リストに値を追加
                    array.Add(number);
                }
                else
                {
                    //  それ以外だったら入力処理を終了する
                    break;
                }
            }
            //  入力された値を全て表示
            foreach (int n in array)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            //  合計値・平均値・最大値・最小値を表示
            Console.WriteLine("合計値:{0}", array.Sum());
            Console.WriteLine("平均値:{0}", array.Average());
            Console.WriteLine("最大値:{0}", array.Max());
            Console.WriteLine("最小値:{0}", array.Min());
        }
    }
}
