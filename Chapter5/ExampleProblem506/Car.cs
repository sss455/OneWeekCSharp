namespace OneWeekCSharp.Chapter5.ExampleProblem506
{
    internal class Car : IDrive, IMechanical
    {
        //  運転メソッド
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        //  メンテナンスメソッド
        public void Maintain()
        {
            Console.WriteLine("メンテナンスする");
        }
    }
}
