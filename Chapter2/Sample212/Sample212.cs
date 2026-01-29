namespace OneWeekCSharp.Chapter2.Sample212
{
    internal class Sample212
    {
        static void Main(string[] args)
        {
            //  さいころの目を入力
            Console.Write("さいころの目(1～6):");
            //  コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    //  奇数ならば半（ハン）
                    Console.WriteLine("半（ハン）です。");
                    break;
                case 2:
                case 4:
                case 6:
                    //  偶数ならば丁（チョウ）
                    Console.WriteLine("丁（チョウ）です。");
                    break;
                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;
            }
        }
    }
}
