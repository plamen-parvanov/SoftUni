using System;

public abstract class Tyre : ITyre
{
    private double degradation;

    protected Tyre(double hardness)
    {
        this.Degradation = 100;
        this.Hardness = hardness;
    }

    public abstract string Name { get; }

    public double Hardness { get; private set; }

    public virtual double Degradation
    {
        get
        {
            return this.degradation;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new BlownTyreException();
            }

            this.degradation = value;
        }
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}
