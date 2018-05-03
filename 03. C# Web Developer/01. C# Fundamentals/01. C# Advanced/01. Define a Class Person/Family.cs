﻿using System.Collections.Generic;
using System.Linq;

public class Family
{
   public List<Person> Members { get; set; }

    public Family()
    {
        this.Members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        Members.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.Members.OrderByDescending(x => x.Age).First();
    }
}

