namespace OneWeekCSharp.Chapter3.ExampleProblem307;

internal class ExampleProblem307
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] n = new int[10];


        for (int i = 0; i < n.Length; i++)
        {
            int num = rnd.Next(1, 101);  // 1から100までの乱数発生
            n[i] = num;                  // 乱数を配列に代入
            Console.Write("{0} ", num);  // 値を表示
        }
        Console.WriteLine();


        // 奇数・偶数を表示
        string[] names = { "偶数:", "奇数:" };

        for (int i = 0; i <= 1; i++)
        {
            Console.Write(names[i]);
            for (int j = 0; j < n.Length; j++)
            {
                if (n[j] % 2 == i)
                {
                    Console.Write("{0} ", n[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
