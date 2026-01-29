namespace OneWeekCSharp.Chapter2.ExampleProblem204_2
{
    internal class ExampleProblem204_2
    {
        static void Main(string[] args)
        {
            //  月を入力
            Console.Write("月(1～12)を入力して下さい:");
            int m = int.Parse(Console.ReadLine());
            string d = "";
            if (m == 2)
            {
                d = "28か29";
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                d = "30";
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                d = "31";
            }
            else
            {
                Console.WriteLine("適切な値を入力してください");
                return;
            }
            Console.WriteLine("{0}月の長さは{1}日です", m, d);
        }
    }
}
