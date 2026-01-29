namespace Sample504
{
    //  サブクラス（Superクラスを継承）
    internal class Sub : Super
    {
        //  Subクラスのコンストラクタ
        public Sub()
        {
            Console.WriteLine("Subのコンストラクタ(引数なし)");
        }
        //  Subクラスのコンストラクタ
        public Sub(int param) : base(param)
        {
            Console.WriteLine("Subのコンストラクタ(引数:param={0})",
                    param);
        }
    }
}
