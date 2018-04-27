namespace _06.Winecraft
{

    using System;
    using System.Collections.Generic;

    public class Problem06
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var grapeList = InitializeIntList(inputLine);
            var growthDays = int.Parse(Console.ReadLine());
            

            while (true)
            {             
                for (int i = 0; i < growthDays; i++)
                {
                    var grapesKindArr = new string[grapeList.Count];
                    SetGrapesKinds(grapeList, grapesKindArr);

                    for (int j = 0; j < grapeList.Count; j++)
                    {
                        if (grapeList[j] > 0)
                        {
                            ExecuteGrowthRules(grapeList, grapesKindArr, j);
                        }
                    }               
                }

                SetZeroToGrapesLessOrEqualToGrowthDays(grapeList, growthDays);

                if (!CountOfGrapesBiggerThanGrowthDays(grapeList, growthDays))
                {
                    break;
                }
            }

            PrintResult(grapeList);
        }

        public static List<int> InitializeIntList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();

            foreach (var str in inputArr)
            {
                list.Add(int.Parse(str));
            }

            return list;
        }

        public static bool CountOfGrapesBiggerThanGrowthDays(List<int> grapeList, int n)
        {
            var cntr = 0;

            foreach (var grape in grapeList)
            {
                if (grape > n)
                {
                    cntr++;
                }
            }

            return (cntr >= n);
        }

        public static void ExecuteGrowthRules(
            List<int> grapeList, string[] grapesKindArr, int i)
        {
            if (grapesKindArr[i] == "normal")
            {
                grapeList[i]++;
            }
            else if (grapesKindArr[i] == "greater")
            {
                grapeList[i]++;
                if (grapeList[i - 1] > 0)
                {
                    grapeList[i]++;
                    grapeList[i - 1]--;
                }

                if (grapeList[i + 1] > 0)
                {
                    grapeList[i]++;
                    grapeList[i + 1]--;
                }

            }

        }

        public static void SetZeroToGrapesLessOrEqualToGrowthDays(
            List<int> grapeList, int growthDays)
        {
            for (int i = 0; i < grapeList.Count; i++)
            {
                if (grapeList[i] <= growthDays)
                {
                    grapeList[i] = 0;
                }
            }
        }

        public static void SetGrapesKinds(List<int> grapeList, string[] grapesKinds)
        {
            SetGreatherGrapes(grapeList, grapesKinds);

            if (grapeList.Count > 1)
            {
                if (grapesKinds[1] == "greater")
                {
                    grapesKinds[0] = "lesser";
                }
                else
                {
                    grapesKinds[0] = "normal";
                }
                if (grapesKinds[grapesKinds.Length - 2] == "greater")
                {
                    grapesKinds[grapesKinds.Length - 1] = "lesser";
                }
                else
                {
                    grapesKinds[grapesKinds.Length - 1] = "normal";
                }
            }

            for (int i = 1; i < grapeList.Count - 1; i++)
            {
                if (grapesKinds[i - 1] == "greater" || grapesKinds[i + 1] == "greater")
                {
                    grapesKinds[i] = "lesser";
                }
                else if (grapesKinds[i] == null)
                {
                    grapesKinds[i] = "normal";
                }
                
            }
        }

        public static void SetGreatherGrapes(List<int> grapeList, string[] grapesKinds)
        {
            for (int i = 1; i < grapesKinds.Length - 1; i++)
            {
                var curr = grapeList[i];
                var prev = grapeList[i - 1];
                var next = grapeList[i + 1];

                if (curr > prev && curr > next)
                {
                    grapesKinds[i] = "greater";
                }
            }
        }

        public static void PrintResult(List<int> grapesList)
        {
            var result = new List<int>();

            foreach (var grapes in grapesList)
            {
                if (grapes > 0)
                {
                    result.Add(grapes);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
