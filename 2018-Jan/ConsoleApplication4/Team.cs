using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private Player currPlayer;
    private List<Player> players;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public Player CurrPlayer
    {
        get { return this.currPlayer; }

        private set
        {
           this.currPlayer = value;
            
        }
    }
    public List<Player> Players
    {
        get { return this.players; }
        private set
        {
            if (players == null)
            {
                players = new List<Player>();
            }
            else if (players.Contains(this.currPlayer))
            {
                players.Remove(this.currPlayer);
            }

                this.players.Add(this.currPlayer);   
        }
    }

    public Team(string name, Player player)
    {
        this.Name = name;
        this.CurrPlayer = player;
    }

    public int GetTotalPoints()
    {
        return players.Sum(x => x.Points); 
    }

    public string GetTopPlayerName()
    {
        var ordered = players.OrderByDescending(p => p.Points).ToList();
        return ordered[0].Name;
    }
}
