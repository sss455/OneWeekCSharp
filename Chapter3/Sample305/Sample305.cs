namespace OneWeekCSharp.Chapter3.Sample305
{
    internal class Sample305
    {
        static void Main(string[] args)
        {
            double one, two, three;
            double sum, avg; //  合計値、平均値を入れる変数
            //  変数の代入
            one = 1.2;
            two = 3.7;
            three = 4.1;
            Console.WriteLine(one + " " + two + " " + three);
            sum = one + two + three;    //  合計値の計算
            avg = sum / 3.0;            //  平均値の計算
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + avg);
        }
    }
}
