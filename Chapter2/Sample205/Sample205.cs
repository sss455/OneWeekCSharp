namespace OneWeekCSharp.Chapter2.Sample205
{
    internal class Sample205
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.Write("str1=");
            str1 = Console.ReadLine();  //  1つ目の文字列を入力
            Console.Write("str2=");
            str2 = Console.ReadLine();  //  2つ目の文字列を入力
            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
        }
    }
}
