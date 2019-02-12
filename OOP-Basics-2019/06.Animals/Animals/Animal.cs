namespace _06.Animals.Animals
{
    using System;
    using System.Text;

    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.Age = age;
            this.gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.name} {this.Age} {this.gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
