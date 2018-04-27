using System;


namespace _09.Extract_Middle_Elements
{
    class ExtractMiddleElements

    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stringArr = input.Split(' ');
            var intArr = new int[stringArr.Length];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
            }

            

            if (intArr.Length == 1)
            {
             
                Console.WriteLine("{{ {0} }}", intArr[0]);
                
            }
            else if (intArr.Length % 2 == 0)
            {
                CopyMiddleTwoElements(intArr);
            }
            else
            {
                CopyMiddleThreeElements(intArr);
            }
        }
        public static void CopyMiddleTwoElements(int[] Arr)
        {
            
            int temp = Arr.Length / 2;
            
            Console.WriteLine("{{ {0}, {1} }}", Arr[temp - 1], Arr[temp]);
            
        }

        public static void CopyMiddleThreeElements(int[] Arr)
        {
            int temp = Arr.Length / 2;
            
            Console.WriteLine("{{ {0}, {1}, {2} }}", Arr[temp - 1], Arr[temp], Arr[temp + 1]);
       
        }
    }
}
