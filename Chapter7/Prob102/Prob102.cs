namespace OneWeekCSharp.Chapter7.Prob102
{
    internal class Prob102
    {
        static void Main(string[] args)
        {
            Console.Write("半径を入力(cm)：");
            //  コンソールから実数値を入力
            double r = double.Parse(Console.ReadLine());
            //  円の面積＝円周率×半径×半径
            Console.WriteLine("円の面積(cm2)：{0}cm2", 3.14 * r * r);
            //  円周の長さ＝2×円周率×半径
            Console.WriteLine("円周の長さ(cm)：{0}cm", 2 * 3.14 * r);
        }
    }
}
