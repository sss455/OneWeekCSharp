namespace OneWeekCSharp.Chapter5.Sample509
{
    //  スーパークラス（抽象プロパティ持つ）
    internal abstract class VectorBase
    {
        //  抽象プロパティ
        public abstract double X
        {
            set;
            get;
        }
        public abstract double Y
        {
            set;
            get;
        }
    }
}
