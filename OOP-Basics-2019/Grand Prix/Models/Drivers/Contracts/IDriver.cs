public interface IDriver
{
    string Name { get; }

    double TotalTime { get; set; }

    ICar Car { get; }

    double FuelConsumptionPerKm { get; }

    double Speed { get; }

    bool IsStopped { get; set; }

    string FailureReason { get; set; }

    double CalculateSpeed();

    void IncreaseTotalTime(int trackLenght);

    void ReduceFuel(int trackLength);

    void DegradateTyre();

    void BoxIncreaseFuel(double amount);

    void BoxChangeTyres(ITyre tyre);
}
