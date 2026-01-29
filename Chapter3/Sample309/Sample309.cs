namespace OneWeekCSharp.Chapter3.Sample309;

internal class Sample309
{
    static void Main(string[] args)
    {
        // p.143 多次元配列
        int[,] a = new int[3, 4];

        // int[,] b =
        //     {
        //         { 1, 2,  3,  4 },
        //         { 4, 5,  6,  7 },
        //         { 8, 9, 10, 11 },
        //     };

        // 2次元配列に値を代入
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 4; n++)
            {
                a[m, n] = m + n;
            }
        }

        // 2次元配列の値を出力
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 4; n++)
            {
                Console.Write("a[{0},{1}]={2} ", m, n, a[m, n]);
            }
            Console.WriteLine();
        }
    }
}