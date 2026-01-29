namespace Sample503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Calculatorクラスのインスタンス
            Calculator c1 = new Calculator();
            c1.Num1 = 10;
            c1.Num2 = 3;
            //  足し算・引き算の結果を表示
            c1.Add();
            c1.Sub();
            ExCalculator c2 = new ExCalculator();
            c2.Num1 = 10;
            c2.Num2 = 3;
            //  足し算・引き算の結果を表示
            c2.Add();
            c2.Sub();
            //  掛け算・割り算の結果を表示
            c2.Mul();
            c2.Div();
        }
    }
}
