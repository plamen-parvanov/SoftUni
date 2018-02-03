public class Sale
{
    private string product;
    private double price;
    private double quantity;
    private double priceTotal;

    public Sale(string product, double price, double quantity)
    {
        this.product = product;
        this.price = price;
        this.quantity = quantity;
        this.priceTotal = price * quantity;
    }

    public string Products
    {
        get { return this.product; }
    }

    public double Price
    {
        get { return this.price; }
    }

    public double Quantity
    {
        get { return this.quantity; }
    }

    public double PriceTotal
    {
        get { return this.priceTotal; }
    }

}

