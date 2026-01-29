namespace OneWeekCSharp.Chapter7.Prob402
{
    internal class Prob402
    {
        static void Main(string[] args)
        {
            //  double型の大きさ４の配列の宣言と初期化
            double[] d = { 0.01, -2.1, 3.7, 0.4 };
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write("d[{0}]={1} ", i, d[i]);  //  値の表示
            }
            Console.WriteLine();
        }
    }
}
