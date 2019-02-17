namespace ConsoleApp1
{
    public class Teacher : Person
    {
        //private int age;

        public Teacher(int age) : base(age)
        {
        }

        public override string Info { get; set; } = "teacher";

        public override int Age { get; set; } = 100;

        public void TestMethod()
        { }
        
    }
}
