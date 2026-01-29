namespace ExampleProblem401
{
    internal class Rectangle
    {
        //  幅
        public double width;
        //  高さ
        public double height;
        //  面積の取得
        public double GetArea()
        {
            return width * height;
        }
        //  周の長さ
        public double GetPerimeter()
        {
            return width * 2 + height * 2;
        }
    }
}
