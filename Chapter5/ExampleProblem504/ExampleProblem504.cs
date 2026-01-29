namespace OneWeekCSharp.Chapter5.ExampleProblem504;

internal class ExampleProblem504
{
    static void Main(string[] args)
    {
        // インスタンスの生成
        Ship       ship       = new Ship();         // 船
        BattleShip battleShip = new BattleShip();   // 戦艦

        // 航行する
        ship.Sail();        // 船
        battleShip.Sail();  // 戦艦

        // 戦闘する
        battleShip.Fight(); // 戦艦
    }
}
