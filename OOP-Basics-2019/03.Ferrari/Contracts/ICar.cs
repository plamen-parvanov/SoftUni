﻿namespace _03.Ferrari.Contracts
{
    public interface ICar
    {
        string Model { get; }

        string DriverName { get; }

        string UseBrakes();

        string PushTheGasPedal();
    }
}
