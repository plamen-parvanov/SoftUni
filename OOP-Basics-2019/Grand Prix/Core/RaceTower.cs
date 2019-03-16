using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private int totalLaps;
    private int length;
    private int currentLap;
    private List<IDriver> drivers;
    private List<IDriver> stoppedDrivers;
    private DriverFactory driverFactory;
    private CarFactory carFactory;
    private TyreFactory tyreFactory;
    private Weather weather;

    public RaceTower()
    {
        this.drivers = new List<IDriver>();
        this.stoppedDrivers = new List<IDriver>();
        this.driverFactory = new DriverFactory();
        this.carFactory = new CarFactory();
        this.tyreFactory = new TyreFactory();
        this.weather = Weather.Sunny;
        this.IsOver = false;
    }

    public bool IsOver { get; private set; }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.currentLap = 0;
        this.totalLaps = lapsNumber;
        this.length = trackLength;
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        IDriver driver = CreateDriver(commandArgs);

        this.drivers.Add(driver);
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var reasonToBox = commandArgs[0];
        var name = commandArgs[1];

        var driver = drivers.Where(d => d.Name == name && !d.IsStopped)
                            .FirstOrDefault();

        switch (reasonToBox)
        {
            case "Refuel":
                var amount = double.Parse(commandArgs[2]);
                driver.BoxIncreaseFuel(amount);
                break;
            case "ChangeTyres":
                var tyre = this.tyreFactory.CreateTyre(commandArgs.Skip(2).ToArray());
                driver.BoxChangeTyres(tyre);
                break;
            default:
                throw new ArgumentException("Nema takov box komand :p");
        }
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var result = new StringBuilder();

        var lapsToComplete = int.Parse(commandArgs[0]);

        if (lapsToComplete > this.totalLaps - this.currentLap)
        {
            result.AppendLine($"There is no time! On lap {this.currentLap}.");

            return string.Empty;
        }

        for (int i = 0; i < lapsToComplete; i++)
        {
            result.AppendLine(CopleteLap());
        }

        if (this.totalLaps == currentLap)
        {
            this.IsOver = true;
        }

        return result.ToString().TrimEnd();
    }

    public string GetLeaderboard()
    {
        var result = new StringBuilder();

        result.AppendLine($"Lap {this.currentLap}/{this.totalLaps}");

        AppendInfoForPlayersStillInRace(result);

        AppendInfoForStoppedPlayers(result);

        return result.ToString().TrimEnd();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var weather = Enum.Parse<Weather>(commandArgs[0]);

        this.weather = weather;
    }

    public string Winner()
    {
        var winner = this.drivers.Where(d => !d.IsStopped).FirstOrDefault();

        return $"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.";
    }

    private IDriver CreateDriver(List<string> commandArgs)
    {
        var tyre = this.tyreFactory.CreateTyre(commandArgs.Skip(4).ToArray());

        var hp = int.Parse(commandArgs[2]);
        var fuelAmount = double.Parse(commandArgs[3]);

        var car = this.carFactory.CreteCar(hp, fuelAmount, tyre);

        var type = commandArgs[0];
        var name = commandArgs[1];

        var driver = this.driverFactory.CreateDriver(type, name, car);

        return driver;
    }

    private void AppendInfoForPlayersStillInRace(StringBuilder result)
    {
        var orderedNotStoppedDrivers = this.drivers
                                           .Where(d => d.IsStopped == false)
                                           .OrderBy(d => d.TotalTime)
                                           .ToList();
        for (int i = 0; i < orderedNotStoppedDrivers.Count; i++)
        {
            var driverName = orderedNotStoppedDrivers[i].Name;
            var totalTime = orderedNotStoppedDrivers[i].TotalTime;

            result.AppendLine($"{i + 1} {driverName} {totalTime:F3}");
        }
    }

    private void AppendInfoForStoppedPlayers(StringBuilder result)
    {
        var position = this.drivers.Count - this.stoppedDrivers.Count + 1;
        stoppedDrivers.Reverse();
        for (int i = 0; i < stoppedDrivers.Count; i++)
        {
            position += i;
            var name = stoppedDrivers[i].Name;
            var failureReason = stoppedDrivers[i].FailureReason;

            result.AppendLine($"{position} {name} {failureReason}");
        }
    }

    private string CopleteLap()
    {
        var result = new StringBuilder();

        var stillRacingDrivers = drivers.Where(d => !d.IsStopped).ToList();

        foreach (var driver in stillRacingDrivers)
        {
            try
            {
                driver.IncreaseTotalTime(this.length);

                driver.ReduceFuel(this.length);

                driver.DegradateTyre();
            }
            catch (CustomException ex)
            {
                driver.FailureReason = ex.Message;
                driver.IsStopped = true;
                this.stoppedDrivers.Add(driver);
            }
        }

        this.currentLap++;

        var ordered = stillRacingDrivers.Where(d => !d.IsStopped)
                                        .OrderBy(d => d.TotalTime)
                                        .ToList();
        ordered.Reverse();

        var length = ordered.Count;

        for (int i = 0; i < length; i++)
        {
            var driver = ordered[i];

            if (i < length - 1)
            {
                var secondDriver = ordered[i + 1];
                try
                {
                    if (CheckForOvertaking(result, driver, secondDriver))
                    {
                        result.AppendLine(string.Format("{0} has overtaken {1} on lap {2}.",
                            secondDriver.Name, driver.Name, this.currentLap));
                        i++;
                    }
                }
                catch (CustomException ex)
                {
                    secondDriver.FailureReason = ex.Message;
                    secondDriver.IsStopped = true;
                    this.stoppedDrivers.Add(secondDriver);
                }
            }
        }

        return result.ToString().TrimEnd();
    }

    private bool CheckForOvertaking(StringBuilder result, IDriver overtaker,
        IDriver overtaken)
    {
        var difference = overtaker.TotalTime - overtaken.TotalTime;

        if (difference <= 3 && overtaken is AggressiveDriver &&
            overtaken.Car.Tyre is UltrasoftTyre && this.weather == Weather.Foggy)
        {
            throw new CrashedException();
        }

        if (difference <= 3 && overtaken is EnduranceDriver &&
           overtaken.Car.Tyre is HardTyre && this.weather == Weather.Rainy)
        {
            throw new CrashedException();
        }

        if (difference <= 2)
        {
            overtaker.TotalTime -= difference;
            overtaken.TotalTime += difference;

            return true;
        }

        return false;
    }
}
