public class Raincast
{
    private string type;
    private string source;
    private string forecast;

    public string Type
    {
        get { return this.type; }
        private set { this.type = value; }
    }
    public string Source
    {
        get { return this.source; }
        private set { this.source = value; }
    }
    public string Forecast
    {
        get { return this.forecast; }
        private set { this.forecast = value; }
    }

    public Raincast(string type, string source, string forecast)
    {
        this.Type = type;
        this.Source = source;
        this.Forecast = forecast;
    }
}
