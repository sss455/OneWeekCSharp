namespace OneWeekCSharp.Chapter3.Sample306;

internal class Sample306
{
    static void Main(string[] args)
    {
        // 変数の代入
        // double d = new double[3];
        // double[] d = { 1.2, 3.7, 4.1 };
        var d = new double[3];
        d[0] = 1.2;
        d[1] = 3.7;
        d[2] = 4.1;

        double sum, avg;  // 合計値、平均値を入れる変数
        sum = 0.0;

        // 合計値の計算
        for (int i = 0; i < d.Length; i++)
        {
            Console.Write(d[i] + " ");
            sum += d[i];
        }
        Console.WriteLine();

        // 平均値の計算
        avg = sum / d.Length;

        Console.WriteLine("合計値：" + sum);
        Console.WriteLine("平均値：" + avg);
    }
}
