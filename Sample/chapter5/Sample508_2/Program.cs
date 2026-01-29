namespace OneWeekCSharp.Chapter5.Sample508
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Birdクラスの変数の配列を生成
            Bird[] b = new Bird[2];
            //  b[0]に、Crowクラスのインスタンスを生成
            b[0] = new Crow();
            //  b[1]に、Sparrowクラスのインスタンスを生成
            b[1] = new Sparrow();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}