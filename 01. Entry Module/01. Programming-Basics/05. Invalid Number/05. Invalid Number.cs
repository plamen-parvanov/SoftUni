﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number !=0 && (number < 100 || number > 200))
            {
                Console.Write("invalid");
            } 
        }
    }
}
