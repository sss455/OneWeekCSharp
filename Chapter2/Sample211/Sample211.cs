namespace OneWeekCSharp.Chapter2.Sample211;

internal class Sample211
{
    static void Main(string[] args)
    {
        // キーボードから数値を入力
        Console.Write("1から3の整数を入力:");
        int num = int.Parse(Console.ReadLine()!);

        switch (num)
        {
            // numが1だった場合
            case 1:
                Console.WriteLine("one");
                break;

            // numが2だった場合
            case 2:
                Console.WriteLine("two");
                break;

            // numが3だった場合
            case 3:
                Console.WriteLine("three");
                break;

            // それ以外の値が入力された場合
            default:
                Console.WriteLine("不適切な値です。");
                break;
        }
    }
}
