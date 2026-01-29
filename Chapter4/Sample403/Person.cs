namespace OneWeekCSharp.Chapter4.Sample403
{
    internal class Person
    {
        //  名前（フィールド）
        private string name = "";
        //  年齢（フィールド）
        private int age = 0;
        //  情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        //  情報の設定
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        //  情報の設定
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
