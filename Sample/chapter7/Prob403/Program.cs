namespace Prob403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  string型の大きさ5の配列を作成
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0}つ目の文字列を入力:", (i + 1));
                //  コンソールから文字列を入力して代入
                str[i] = Console.ReadLine();
            }
            //  結果の表示 forを使ってもよいが、
            // インデックス操作を必要としないので、
            // foreachを用いる
            foreach (string s in str)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
