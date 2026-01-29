namespace OneWeekCSharp.Chapter3.Sample307
{
    internal class Sample307
    {
        static void Main(string[] args)
        {
            int[] n = { 5, 4, 3, 2, 1 };
            string[] s = { "ABC", "DEF", "GHI" };
            int i;
            //  整数型配列変数nの成分表示
            for (i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            //  文字列型配列変数sの成分表示
            for (i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
