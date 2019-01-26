namespace _13.FamilyTree
{
    public class Person
    {
        public Person(string firstName, string lastName, string birthDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string BirthDay { get; private set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.BirthDay}"; 
        }
    }
}
