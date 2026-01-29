namespace OneWeekCSharp.Chapter5.Sample503
{
    internal class Calculator
    {
        //  1つ目の数値
        protected int num1;
        //  2つ目の数値
        protected int num2;
        //  num1のプロパティ
        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        //  num2のプロパティ
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }
        //  足し算
        public void Add()
        {
            Console.WriteLine("{0} + {1} = {2}",
                    num1, num2, num1 + num2);
        }
        //  引き算
        public void Sub()
        {
            Console.WriteLine("{0} - {1} = {2}",
                        num1, num2, num1 - num2);
        }
    }
}