namespace DefiningClasses
{
    public class Person
    {
        private const int noAge = 1;
        private const string noName = "No name";

        private int age;
        private string name;

        public Person()
        {
            this.Age = noAge;
            this.Name = noName;
        }

        public Person(int age) :this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public override string ToString()
        {
            var result = $"{this.name} - {this.age}";
            return result;
        }
    }
}
