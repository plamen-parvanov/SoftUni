using _05.Mordor_sCruelPlan.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Mordor_sCruelPlan.Models
{
    public class Mood
    {
        private List<Food> foodEaten;

        public Mood(List<Food> foodEaten)
        {
            this.foodEaten = foodEaten;
        }

        private string GetMoodName()
        {
            var happynes = CalculateHappyness();
            string moodName;

            if (happynes < -5)
            {
                moodName = "Angry";
            }
            else if (happynes <= 0)
            {
                moodName = "Sad";
            }
            else if (happynes <= 15)
            {
                moodName = "Happy";
            }
            else
            {
                moodName = "JavaScript";
            }

            return moodName;
        }

        private int CalculateHappyness()

        {
            int happynes = 0;


            foreach (var food in this.foodEaten)
            {
                happynes += (int)food;
            }

            return happynes;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.CalculateHappyness()}");
            sb.AppendLine($"{this.GetMoodName()}");

            return sb.ToString().TrimEnd();
        }
    }
}
