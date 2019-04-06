namespace SoftUniRestaurant.Models.Tables.Factories.Contracts
{
    using Tables.Contracts;

    public interface ITableFactory
    {
        ITable CreateTable(string typeName, int tableNumber, int capacity);
    }
}
