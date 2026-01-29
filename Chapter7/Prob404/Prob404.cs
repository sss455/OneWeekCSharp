namespace OneWeekCSharp.Chapter7.Prob404
{
    internal class Prob404
    {
        static void Main(string[] args)
        {
            string[] months = {
                "January","February","March","April",
                "May","June","July","August",
                "September","October","November","December" };
            Console.Write("月（1～12）を入力してください:");
            int m = int.Parse(Console.ReadLine());
            if (m >= 1 && m <= months.Length)
            {
                //  m月の中の配列のインデックスはm-1
                Console.WriteLine("{0}月は英語で{1}", m, months[m - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
