public class Spy
{
    public string Name { get; private set; }
    public int DaysInServ { get; set; }

    public Spy(string name, int daysInServ)
    {
        this.Name = name;
        this.DaysInServ = daysInServ;
    }
}