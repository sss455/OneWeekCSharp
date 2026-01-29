namespace OneWeekCSharp.Chapter5.Sample508
{
    internal class Crow : Bird
    {
        // コンストラクタ
        public Crow() : base("カラス")
        {
        }
        //  カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
