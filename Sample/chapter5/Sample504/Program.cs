namespace Sample504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sub s1 = new Sub();
            s1.showParam();
            Sub s2 = new Sub(100);
            s2.showParam();
        }
    }
}
