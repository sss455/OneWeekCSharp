namespace OneWeekCSharp.Chapter5.ExampleProblem506;

internal class ExampleProblem506
{
    // 自動車を運転する
    static void DriveACar(Car car)
    {
        car.Drive();
        //car.Maintain();   
    }

    // 自動車をメンテナンスする
    static void MaintainACar(Car car)
    {
        //car.Drive();
        car.Maintain();
    }

    static void Main(string[] args)
    {
        Car c = new Car();
        DriveACar(c);
        MaintainACar(c);
    }
}
