using OneWeekCSharp.Chapter5.ExampleProblem505;

namespace OneWeekCSharp.Chapter5.ExampleProblem505
{
    internal class ExampleProblem505
    {
        static void Main(string[] args)
        {
            //  哺乳類クラスのオブジェクトの配列を生成
            Mammals[] animals = new Mammals[2];
            animals[0] = new Cats();    //  猫クラスのインスタンス生成
            animals[1] = new Mice();    //  ネズミクラスのインスタンス生成
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}
