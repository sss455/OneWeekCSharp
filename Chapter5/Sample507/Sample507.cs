namespace OneWeekCSharp.Chapter5.Sample507
{
    internal class Sample507
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();          //  カラスクラス
            Sparrow s = new Sparrow();    //  すずめクラス
            //  カラスが鳴く
            Console.Write(c.Name + " : ");
            c.Sing();
            //  すずめが鳴く
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
