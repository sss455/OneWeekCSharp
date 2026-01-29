namespace Sample204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 変数の宣言
            double a, b, d;
            int c;
            // 変数への値の代入
            a = 1.23;
            b = (double)12; //  キャストありで代入
            c = (int)1.24;  //  キャストありで代入
            d = 10;         //  キャストなしで代入
            // 変数の中身を出力
            Console.WriteLine("a={0} b={1} c={2} d={3}",
                a, b, c, d);
        }
    }
}
