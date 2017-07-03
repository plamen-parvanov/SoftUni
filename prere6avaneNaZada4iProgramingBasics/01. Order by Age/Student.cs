namespace _01.Order_by_Age
{

    public class Student
    {
        private string name;
        private string personId;
        private int age;

        public Student(string name, string personId, int age)
        {
            this.name = name;
            this.personId = personId;
            this.age = age;
        }

        public int Age
        {
            get { return this.age; }
           // set { this.age = value; }
            
        }

        public string Name
        {
            get { return this.name; }
           // set { this.name = value; }

        }
        public string PersonId
        {
            get { return this.personId; }
          //  set { this.personId = value; }

        }


    }
}
