﻿using System;


namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            string drink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;

                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;

                case "SoftUni Student":
                    drink = "Beer";
                    break;

                default:
                    drink = "Tea";
                    break;
            }

            Console.WriteLine(drink);

        }
    }
}
