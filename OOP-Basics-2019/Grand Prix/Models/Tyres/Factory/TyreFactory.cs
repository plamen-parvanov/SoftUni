public class TyreFactory
{
    public ITyre CreateTyre(string[] args)
    {
        var type = args[0];
        var hardness = double.Parse(args[1]);

        ITyre tyre;

        switch (type)
        {
            case "Ultrasoft":
                var grip = double.Parse(args[2]);
                tyre = new UltrasoftTyre(hardness, grip);
                break;
            case "Hard":
                tyre = new HardTyre(hardness);
                break;
            default:
                throw new System.ArgumentException();
        }

        return tyre;
    }
}
