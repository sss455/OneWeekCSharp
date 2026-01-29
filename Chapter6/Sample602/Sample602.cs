namespace OneWeekCSharp.Chapter6.Sample602
{
    internal class Sample602
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            //  データを追加
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            //  データを削除
            a.Remove("Taro");   //  "Taro"を削除
            a.RemoveAt(1);      //  1番目のデータを削除
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
