namespace OneWeekCSharp.Chapter5.Sample501;

internal class Sample501
{
    static void Main(string[] args)
    {
        // 要素2つの配列を作る
        Data[] d = new Data[2];

        // Dataのインスタンスの数を表示
        Data.ShowNumber();

        for (int i = 0; i < d.Length; i++)
        {
            // Dataのインスタンスを生成
            d[i] = new Data(i * 100);

            // Dataのインスタンスの数を表示
            Data.ShowNumber();
        }
    }
}
