public interface ICar
{
    int Hp { get; }

    double FuelAmount { get; }

    ITyre Tyre { get; }

    void ReduceFuel(double amount);

    void IncreaseFuel(double amount);

    void ChangeTyre(ITyre tyre);

    void DegradateTyre();
}
