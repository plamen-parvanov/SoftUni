namespace _03.Karate_Strings
{

    using System;


    public class Regex
    {

        public static void Main()
        {
            string path = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '>')
                {
                    power += int.Parse(path[i + 1].ToString());
                    i++;
                    while (power > 0 && i < path.Length)
                    {
                        if (path[i] == '>')
                        {
                            break;
                        }
                        path = path.Remove(i, 1);
                        power--;
                    }
                    i--;
                }
            }

            Console.WriteLine(path);
        }
    }
}
