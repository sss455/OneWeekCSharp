namespace OneWeekCSharp.Chapter5.Sample511
{
    internal class Sample511
    {
        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            IFuncs1 i1 = d;
            IFuncs2 i2 = d;
            //  i1のメソッドを利用
            i1.Func1();
            i1.Func2();
            //  i2のメソッドを利用
            i2.Func2();
            i2.Func3();
        }
    }
}
