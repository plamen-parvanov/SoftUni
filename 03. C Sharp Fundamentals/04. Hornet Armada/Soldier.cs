public class Soldier
{
    private string soldierType;
    private int soldierCount;
    private int activity;

    public string SoldierType
    {
        get { return this.soldierType; }
        private set { this.soldierType = value; }
    }
    public int SoldierCount
    {
        get { return this.soldierCount; }
        set { this.soldierCount = value; }
    }
    public int Activity
    {
        get { return this.activity; }
        private set { this.activity = value; }
    }

    public Soldier(string soldierType, int soldierCount, int activity)
    {
        this.SoldierType = soldierType;
        this.SoldierCount = soldierCount;
        this.Activity = activity;
    }
}
