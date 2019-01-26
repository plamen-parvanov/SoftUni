﻿namespace DefiningClasses
{
    public class Person
    {
        private const string noName = "No name";
        private const int noAge = 1;

        private string name;
        private int age;

        public Person()
        {
            this.Name = noName;
            this.Age = noAge;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            var result = $"{this.name} {this.age}";

            return result;
        }
    }
}
