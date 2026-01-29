namespace OneWeekCSharp.Chapter4.Sample404
{
    internal class Access
    {
        //  読み取りオンリーのデータ
        private int data1 = 5;
        //  書き込みオンリーのデータ
        private int data2 = 0;
        //  値の表示
        public void ShowDatas()
        {
            Console.WriteLine("data1={0} data2={1}",
            data1, data2);
        }
        //  data1のプロパティ（読み取りオンリー）
        public int Data1
        {
            get { return data1; }
        }
        //  data2のプロパティ（書き込みオンリー）
        public int Data2
        {
            set { data2 = value; }
        }
    }
}
