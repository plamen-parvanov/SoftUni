﻿public class Engine
{
    public string model;
    public int power;
    public string displacement;
    public string efficiency;

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }

    public Engine(string model, int power, int displacement) 
        : this(model, power)
    {
        this.displacement = displacement.ToString();
    }

    public Engine(string model, int power, string efficiency)
        : this (model, power)
    {
        this.efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power, displacement)
    {
        this.efficiency = efficiency;
    }
}
