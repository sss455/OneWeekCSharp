namespace OneWeekCSharp.Chapter4.Sample407;

internal class Sample407
{
    static void Main(string[] args)
    {
        // 大量の文字列を生成して、メモリの使用量を上げる
        string[]? a = new string[10000];

        for (int i = 0; i < 10000; i++)
        {
            a[i] = new string('M', 10000);
        }

        Console.WriteLine("メモリ使用量（GC発動前）　："
                + GC.GetTotalMemory(false));

        // aの参照を解放
        a = null;

        Console.WriteLine("メモリ使用量（参照解除後）："
                + GC.GetTotalMemory(false));

        // ガーベージコレクションを起動
        GC.Collect();

        Console.WriteLine("メモリ使用量（GC発動後）　："
                + GC.GetTotalMemory(false));

        // [実行結果]
        // ・メモリ使用量（GC発動前）　：200700088
        // ・メモリ使用量（参照解除後）：200708312
        // ・メモリ使用量（GC発動後）　：31784
    }
}
