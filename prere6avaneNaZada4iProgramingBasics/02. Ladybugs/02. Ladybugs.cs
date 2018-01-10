namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class ExamPreparationII
    {

        public static void Main()
        {
            var fieldLenght = int.Parse(Console.ReadLine());

            var field = new int[fieldLenght];

            InitialiseFieldWithBugs(field);
            
            ExecuteCommandInput(field);

        }

        public static void ExecuteCommandInput(int[] field)
        {
            var command = Console.ReadLine()
                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();

            while (! command[0].Equals("end"))
            {
                var getBugFrom = int.Parse(command[0]);
                var move = 0;
                if (command[1].Equals("right"))
                {
                    move = 1;
                }
                else if (command[1].Equals("left"))
                {
                    move = -1;
                }

                var range = int.Parse(command[2]) * move;

                if (getBugFrom < 0 || getBugFrom >= field.Length) // dali e v masiva
                {
                    command = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    continue;
                }
                else if (field[getBugFrom] == 0) // dali ima bobule4ka
                {
                    command = Console.ReadLine()
                     .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                    continue;
                }

                MovingTheBug(getBugFrom, range, field);


                command = Console.ReadLine()
                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        public static int[] MovingTheBug(int getBugFrom, int range, int[] field)
        {
            field[getBugFrom] = 0;
            bool moved = false;
            var movedField = getBugFrom + range;

            while (!moved)
            {
               
                if (movedField < 0 || movedField >= field.Length)
                {
                    moved = true;
                    continue;
                }
                else if (field[movedField] == 0)
                {
                    moved = true;
                    field[movedField] = 1;
                    continue;
                }
                else
                {
                    movedField += range; // in the same direction by the same fly length
                }
            }

            return field;
        }


        public static void InitialiseFieldWithBugs(int[] field)
        {
            var bugsIndexes = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                if (bugsIndexes[i] >= 0 && bugsIndexes[i] < field.Length)
                {
                    field[bugsIndexes[i]] = 1;
                }
            }

        }
    }
}
