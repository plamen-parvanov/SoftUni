namespace _09.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var materialAndQuantity = new Dictionary<string, int>();
            var itemPerMaterial = new Dictionary<string, string>
            {
                ["shards"] = "Shadowmourne",
                ["fragments"] = "Valanyr", 
                ["motes"] = "Dragonwrath"
            }; 


            while (true)
            {
                var inputLine = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 0; i < inputLine.Length; i++)
                {
                    var material = inputLine[i + 1];
                    var quantity = int.Parse(inputLine[i]);

               // trqbva da subiram materialite v dva spisuka (cennite i junk)

                    if (!materialAndQuantity.ContainsKey(material))
                    {
                        materialAndQuantity[material] = 0;
                    }

                    materialAndQuantity[material] += quantity;

                    if (materialAndQuantity[material] > 249)
                    {
                        Console.WriteLine("{0} obtained!", itemPerMaterial[material]);
                        materialAndQuantity[material] -= 250;
                        Console.WriteLine("");
                    }
                }
            }

        }
    }
}
