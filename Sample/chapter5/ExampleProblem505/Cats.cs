namespace ExampleProblem505
{
    internal class Cats : Mammals
    {
        public Cats()
        {
            this.name = "猫";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
    }

}
