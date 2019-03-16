public class StrtUp
{
    public static void Main()
    {
        var RaceTower = new RaceTower();
        var engine = new Engine(RaceTower);
        engine.Run();
    }
}

