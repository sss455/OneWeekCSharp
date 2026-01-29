# 目次
### 【1日目】　はじめの一歩
1. プログラミングとは何か
2. プログラミングの基本的な考え方
3. プログラムの実行

### 【2日目】　変数と条件分岐
1. 演算と変数
2. 条件分岐

### 【3日目】　繰り返しと配列
1. 繰り返し処理
2. 配列

### 【4日目】　オブジェクト指向①
1. クラスとオブジェクト
2. カプセル化
3. インスタンスの生成と消去

### 【5日目】　オブジェクト指向②
1. 静的メンバ
2. 継承
3. 抽象クラスとインターフェース

### 【6日目】　コレクション・デリゲート・例外処理
1. コレクション
2. デリゲート・ラムダ式
3. 例外処理

### 【7日目】　実践練習
1. 練習問題
2. 練習問題の解答

---


### 【4日目】　オブジェクト指向①
2. カプセル化<br>
2-2. アクセス修飾子とプロパティ<br>
◎アクセス修飾子の種類（p.186）

```cs:Sample403.cs
internal class Sample403
{
    static void Main(string[] args)
    {
        // Personクラスのメソッドのインスタンスを２つ生成
        Person p1, p2;
        p1 = new Person();
        p2 = new Person();

        p1.Name = "山田太郎";   // フィールドnameに値を代入★
        p1.Age  = 19;           // フィールドage に値を代入★

        //  setAgeAndName()メソッドで、nameとageを設定★
        p2.SetAgeAndName("佐藤花子", 23);

        // メソッドから、名前と年齢を表示
        p1.ShowAgeAndName();

        // プロパティから名前と年齢を表示
        Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
    }
}
```

```cs:Person.cs
internal class Person
{
    // 名前（フィールド）
    private string name = string.Empty;
    // 年齢（フィールド）
    private int age = 0;

    // 名前
    public string Name
    {
        set { name = value; }  // ★
        get { return name; }   // ★
    }

    // 年齢
    public int Age
    {
        set { age = value; }  // ★
        get { return age; }   // ★
    }

    // プロパティの設定
    public void SetAgeAndName(string name, int age)
    {
        this.name = name;  // ★
        this.age  = age;   // ★
    }

    // 情報の表示（メソッド）
    public void ShowAgeAndName()
    {
        Console.WriteLine("名前：{0} 年齢：{1}", name, age);
    }
}

```

＜アクセス修飾子＞

| 名前 | 意味
|------|--
| public             | どこからでもアクセスできる
| protected          | 同一クラスか、そのサブクラスからのみアクセスできる　
| internal           | 同一アセンブリ内(DLL)内でアクセスできる　
| protected internal | protected かつ internal
| private            | 同じクラス内からしかアクセスできない

<br><br>
　　2-2. アクセス修飾子とプロパティ<br>
　　◎アクセス修飾子の種類（p.186）

```cs:Sample404.cs
internal class Sample404
{
    static void Main(string[] args)
    {
        Access a = new Access();

        // a.Data1 = 1; （★読み取りオンリー）
        a.Data2 = 2;

        a.ShowDatas();

        Console.WriteLine("a.data1 = {0}", a.Data1);
        // Console.WriteLine("a.data2 = {0}", a.Data2); （★書き込みオンリー）
    }
}
```

```cs:Access.cs
internal class Access
{
    // 読み取りオンリーのデータ
    private int data1 = 5;
    // 書き込みオンリーのデータ
    private int data2 = 0;

    // data1のプロパティ（★読み取りオンリー）
    public int Data1
    {
        get { return data1; }
    }

    // data2のプロパティ（★書き込みオンリー）
    public int Data2
    {
        set { data2 = value; }
    }
    
    // 値の表示
    public void ShowDatas()
    {
        Console.WriteLine("data1={0} data2={1}", data1, data2);
    }
}
```

　　◎フィールドなしでも定義できる自走実装プロパティ（p.192）

```cs:Sample405.cs
internal class Sample405
{
    static void Main(string[] args)
    {
        Person2 p = new Person2();
        // p.Name = "佐藤花子";           // 名前の変更(できない)★
        p.Age = 32;                       // 年齢の変更
        p.SetAgeAndName("山田太郎", 26);  // 名前と年齢を設定

        // 名前と年齢の表示
        Console.WriteLine("名前：{0} 年齢:{1}", p.Name, p.Age);
    }
}
```
```cs:Person2.cs
internal class Person2
{
    // 名前
    public string? Name
    {
        private set; get;   // ★private
    }

    // 年齢
    public int Age
    {
        set; get;
    }

    // プロパティの設定
    public void SetAgeAndName(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // 情報の表示（メソッド）
    public void ShowAgeAndName()
    {
        Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
    }
}
```


3. インスタンスの生成と消去<br>
3-1. コンストラクタ<br>
◎コンストラクタとは何か（p.201）<br>
◎コンストラクタのthis　　（p.202）


```cs:Sample406.cs
internal class Sample406
{
    static void Main(string[] args)
    {
        Person p1, p2, p3;

        p1 = new Person();              // 引数なしのコンストラクタ
        p1.Name = "斉藤花子";
        p1.Age  = 18;

        //p1 = new Person
        //        {
        //            Name = "山田太郎",
        //            Age  = 20,
        //        };


        p2 = new Person("太田隆", 29);  // 引数ありのコンストラクタ

        p1.ShowAgeAndName();
        p2.ShowAgeAndName();
    }
}
```

```cs:Person.cs
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
```

<br>
　　3-2. ガーベージコレクションとメモリ管理<br>
　　◎ガーベージコレクション（p.203）<br><br>

以下のように入力して実行する。<br>
`dotnet run --configuration Release`

```cs:Person.cs
internal class Sample407
{
    static void Main(string[] args)
    {
        // 大量の文字列を生成して、メモリの使用量を上げる
        string[]? a = new string[10000];

        for (int i = 0; i < 10000; i++)
        {
            a[i] = new string('M', 10000);
        }

        Console.WriteLine("メモリ使用量（GC発動前）　："
                + GC.GetTotalMemory(false));

        // aの参照を解放
        a = null;

        Console.WriteLine("メモリ使用量（参照解除後）："
                + GC.GetTotalMemory(false));

        // ガーベージコレクションを起動
        GC.Collect();

        Console.WriteLine("メモリ使用量（GC発動後）　："
                + GC.GetTotalMemory(false));
}
```
```
[実行結果]
・メモリ使用量（GC発動前）　：200700088
・メモリ使用量（参照解除後）：200708312
・メモリ使用量（GC発動後）　：31784
```

