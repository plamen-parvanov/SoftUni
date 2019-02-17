namespace ConsoleApp1
{
    public class Person
    {
        private int age;

        public Person(int age)
        {
            this.Age = age;
        }

        public virtual string Info { get; set; } = "person";

        public virtual int Age { get; set; } = 1;
        
    }
}
