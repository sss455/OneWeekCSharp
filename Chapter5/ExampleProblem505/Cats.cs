namespace OneWeekCSharp.Chapter5.ExampleProblem505
{
    internal class Cats : Mammals
    {
        public Cats()
        {
            name = "猫";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
    }

}
