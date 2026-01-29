namespace OneWeekCSharp.Chapter5.Sample507
{
    internal class Sparrow
    {
        private string name = "すずめ";
        //  すずめが鳴く
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        // 名前を取得
        public string Name
        {
            get { return name; }
        }
    }
}
