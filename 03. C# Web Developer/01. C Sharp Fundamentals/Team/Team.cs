using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public string Name => this.name;
    public IReadOnlyCollection<Person> FirstTeam => this.firstTeam.AsReadOnly();
    public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam.AsReadOnly();

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }

    }
}
