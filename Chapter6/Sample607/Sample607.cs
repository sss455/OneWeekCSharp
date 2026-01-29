namespace OneWeekCSharp.Chapter6.Sample607
{
    // デリゲート
    internal delegate int Calculation(int a, int b);

    internal class Sample607
    {
        static void Main(string[] args)
        {
            // デリゲートCaculationにラムダ式を代入
            Calculation add = (a, b) => a + b;
            Calculation sub = (a, b) => a - b;
            int a = 5, b = 4;
            Console.WriteLine("{0} + {1} = {2}", a, b, add(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, sub(a, b));
        }
    }
}
