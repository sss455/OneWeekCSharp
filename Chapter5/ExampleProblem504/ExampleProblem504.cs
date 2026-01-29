namespace OneWeekCSharp.Chapter5.ExampleProblem504
{
    internal class ExampleProblem504
    {
        static void Main(string[] args)
        {
            //  インスタンスの生成
            Ship ship = new Ship();
            BattleShip battleShip = new BattleShip();
            //  航行する
            ship.Sail();
            battleShip.Sail();
            //  戦闘する
            battleShip.Fight();
        }
    }
}
