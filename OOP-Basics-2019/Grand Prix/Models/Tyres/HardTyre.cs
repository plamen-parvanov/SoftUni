public class HardTyre : Tyre
{
    private double degradation;

    public HardTyre(double hardness) : base(hardness)
    {
    }

    public override string Name => "Hard";
}
