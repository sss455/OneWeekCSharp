namespace ExampleProblem505
{
    internal class Mice : Mammals
    {
        public Mice()
        {
            this.name = "ネズミ";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
}
