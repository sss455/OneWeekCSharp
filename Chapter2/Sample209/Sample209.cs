namespace OneWeekCSharp.Chapter2.Sample209;

internal class Sample209
{
    static void Main(string[] args)
    {
        // キーボードから数値を入力
        Console.Write("1から3の整数を入力:");
        int num = int.Parse(Console.ReadLine()!);

        // numが1だった場合
        if (num == 1)
        {
            Console.WriteLine("one");
        }
        // numが2だった場合
        else if (num == 2)
        {
            Console.WriteLine("two");
        }
        // numが3だった場合
        else if (num == 3)
        {
            Console.WriteLine("three");
        }
        // それ以外の値が入力された場合
        else
        {
            Console.WriteLine("不適切な値です。");
        }
    }
}
