namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Lists
    {

        public static void Main()
        {
            var intList = Console.ReadLine().Split().Select(double.Parse).ToList();

            
                for (int i = 0; i < intList.Count - 1; i++)
                {
                    if (intList[i] == intList[i + 1])
                    {
                        intList[i + 1] = intList[i] + intList[i + 1];                       
                        intList.RemoveAt(i);
                    i = -1;
                        
                    }
                   
                }
            
            

            Console.WriteLine(string.Join(" ", intList));


        }
    }
}
