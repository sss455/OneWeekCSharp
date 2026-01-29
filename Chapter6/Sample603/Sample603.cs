namespace OneWeekCSharp.Chapter6.Sample603
{
    internal class Sample603
    {
        static void Main(string[] args)
        {
            //  連想配列クラスの生成
            Dictionary<string, string> capital =
                new Dictionary<string, string>();
            //  データの追加
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            Console.WriteLine("世界の首都");
            foreach (string s in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}です。", s, capital[s]);
            }
        }
    }
}
