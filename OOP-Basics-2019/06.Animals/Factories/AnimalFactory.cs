using _06.Animals.Animals;
using System;

namespace _06.Animals.Factories
{
    public abstract class AnimalFactory
    {
        public static Animal CreateAnimal(string type, string info)
        {
            var arr = info.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = arr[0];
            var age = int.Parse(arr[1]);
            string gender;

            switch (type)
            {
                case "Cat":
                    gender = arr[2];
                    return new Cat(name, age, gender);
                case "Dog":
                    gender = arr[2];
                    return new Dog(name, age, gender);
                case "Frog":
                    gender = arr[2];
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    throw new ArgumentException("Invalid input!");
            }

        }
    }
}
