namespace _02.Pokemon_Don_t_Go
{

    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ExamPartI
    {

        public static void Main()
        {
            var inputList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var sumRemovedEl = 0;

            while (inputList.Count > 0)
            {
                var indexToRemove = int.Parse(Console.ReadLine());
                if (indexToRemove < 0)
                {
                    sumRemovedEl += inputList[0];
                    ManipulateListIfIndexOtsideList(inputList, indexToRemove);
                }
                else if (indexToRemove >= inputList.Count)
                {
                    sumRemovedEl += inputList[inputList.Count - 1];
                    ManipulateListIfIndexOtsideList(inputList, indexToRemove);
                }
                else
                {                  
                    sumRemovedEl += inputList[indexToRemove];
                    ManipulateListIfIndexInRange(inputList, indexToRemove);
                }              
                
            }

            Console.WriteLine(sumRemovedEl);
        }

        public static void ManipulateListIfIndexInRange(List<int> list, int index)
        {
            var elementValue = list[index];

            SumOrSubstractElementsValue(list, elementValue);

            list.RemoveAt(index);

        }

        public static void SumOrSubstractElementsValue(List<int> list, int elementValue)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += list[i] <= elementValue ? elementValue : -elementValue;
            }
        }

        public static void ManipulateListIfIndexOtsideList(List<int> list, int index)
        {
            var elementValue = 0;

            if (index < 0)
            {
                elementValue = list[0];
                SumOrSubstractElementsValue(list, elementValue);
                list[0] = list[list.Count - 1];
            }
            else
            {
                elementValue = list[list.Count - 1];
                SumOrSubstractElementsValue(list, elementValue);
                list[list.Count - 1] = list[0];
            }

        }

    }
}
