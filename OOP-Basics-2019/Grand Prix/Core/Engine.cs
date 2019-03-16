using System;
using System.Linq;
using System.Text;

public class Engine
{
    private RaceTower raceTower;
    private StringBuilder outputMessage;

    public Engine(RaceTower raceTower)
    {
        this.raceTower = raceTower;
        this.outputMessage = new StringBuilder();
    }
    public void Run()
    {
        ReadInput();

        Finish();

        Print();
    }

    private void Print()
    {
        Console.WriteLine(outputMessage.ToString().TrimEnd());
    }

    private void Finish()
    {
        this.outputMessage.AppendLine(this.raceTower.Winner());
    }

    private void ReadInput()
    {
        var totalLaps = int.Parse(Console.ReadLine());
        var length = int.Parse(Console.ReadLine());

        this.raceTower.SetTrackInfo(totalLaps, length);

        while (!raceTower.IsOver)
        {
            var inputLine = Console.ReadLine();

            Execute(inputLine);
        }
    }

    private void Execute(string input)
    {
        var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var command = arr[0];
        var args = arr.Skip(1).ToList();

        switch (command)
        {
            case "RegisterDriver":
                this.raceTower.RegisterDriver(args);
                break;
            case "Leaderboard":
                this.outputMessage.AppendLine(this.raceTower.GetLeaderboard());
                break;
            case "CompleteLaps":
               var result = this.raceTower.CompleteLaps(args);
                if (!string.IsNullOrEmpty(result))
                {
                    this.outputMessage.AppendLine(this.raceTower.CompleteLaps(args));
                }
                break;
            case "Box":
                this.raceTower.DriverBoxes(args);
                break;
            case "ChangeWeather":
                this.raceTower.ChangeWeather(args);
                break;
            default:
                throw new ArgumentException("E nema takava komanda ;)");
        }
    }
}
