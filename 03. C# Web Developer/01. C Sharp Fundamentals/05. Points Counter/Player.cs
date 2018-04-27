﻿public class Player
{
    private string name;
    private int points;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public int Points
    {
        get { return this.points; }
        private set { this.points = value; }
    }

    public Player(string name, int points)
    {
        this.Name = name;
        this.Points = points;
    }
}
