namespace ExampleProblem602
{
    // デリゲート
    internal delegate void Operation(int a, int b);

    // Calcクラス
    internal class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            // ラムダ式で加算処理（staticメソッドを使わず）
            Operation o1 = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            // ラムダ式でSubメソッドをラップ（明示的にcを使う）
            Operation o2 = (a, b) => c.Sub(a, b);
            // 実行
            o1(2, 1);
            o2(2, 1);
        }
    }
}
