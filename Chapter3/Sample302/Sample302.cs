namespace OneWeekCSharp.Chapter3.Sample302
{
    internal class Sample302
    {
        static void Main(string[] args)
        {
            //  forの2重ループ
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int k = i + j;
                    Console.Write(i + "+" + j + "=" + k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
