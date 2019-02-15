namespace _05.BorderControl.Contracts
{
    public interface IBuyer : IName
    {
        int Food { get; }

        void BuyFood();
    }
}
