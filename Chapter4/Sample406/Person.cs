namespace OneWeekCSharp.Chapter4.Sample406;

internal class Person
{
    // フィールドname(名前)
    private string name = "";
    // フィールドage(年齢)
    private int age = 0;


    // コンストラクタ(引数なし)
    public Person() : this("名無し", 0)
                   // ★↑引数なしのコンストラクタを実行する前に、引数ありのコンストラクタを呼び出す。
    {
        Console.WriteLine("引数なしコンストラクタ");
    }

    // コンストラクタ（引数あり）
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}", name, age);
    }


    // nameプロパティ
    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    // ageプロパティ
    public int Age
    {
        set { age = value; }
        get { return age; }
    }


    // プロパティname, ageの表示
    public void ShowAgeAndName()
    {
        Console.WriteLine("名前：{0} 年齢：{1}", name, age);
    }
}
