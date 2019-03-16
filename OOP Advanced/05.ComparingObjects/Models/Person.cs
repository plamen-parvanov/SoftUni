using System;

namespace _05.ComparingObjects.Models
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string town) : this(name, age)
        {
            this.Town = town;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            } 
            
            //if (result == 0)
              //{
              //    result = this.Town.CompareTo(other.Town);
              //}

            return result;
        }

        public override string ToString()
        {
            var result = $"{this.Name} {this.Age}";

            return result;
        }

        public override bool Equals(object obj)
        {
                   // ili ... || !(obj is Person)
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return (this.Name == person.Name) && (this.Age == person.Age);
            }
        }

        public override int GetHashCode()
        {
            // ili + vmesto ^
            return this.Name.GetHashCode() ^ this.Age.GetHashCode();
        }
    }
}
