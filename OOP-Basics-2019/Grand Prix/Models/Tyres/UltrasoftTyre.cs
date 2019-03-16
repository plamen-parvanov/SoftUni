using System;

public class UltrasoftTyre : Tyre
{
    private double degradation;

    public UltrasoftTyre(double hardness, double grip) : base(hardness)
    {
        this.Grip = grip;
    }

    public override string Name => "Ultrasoft";

    public double Grip { get; private set; }

    public override double Degradation
    {
        get
        {
            return this.degradation;
        }
        protected set
        {
            if (value <= 30)
            {
                throw new ArgumentException();
            }

            this.degradation = value;
        }
    }

    public override void ReduceDegradation()
    {
        this.Degradation -= (this.Grip + this.Hardness);
    }
}
