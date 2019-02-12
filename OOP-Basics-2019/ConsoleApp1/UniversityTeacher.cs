namespace ConsoleApp1
{
    public class UniversityTeacher : Teacher
    {
        //private int age;

        public UniversityTeacher(int age) : base(age)
        {
        }

        public string Info { get; set; } = "university teacher";


        public override int Age { get; set; } = 111111;
       
    }
}
