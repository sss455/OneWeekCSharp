namespace Prob104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.Write("幅(cm) = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("奥行(cm) = ");
            double depth = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm) = ");
            double height = double.Parse(Console.ReadLine());
            //  幅×奥行×高さが立方体の体積
            Console.WriteLine("立方体の体積 = {0}cm3", width * depth * height);
        }
    }
}
