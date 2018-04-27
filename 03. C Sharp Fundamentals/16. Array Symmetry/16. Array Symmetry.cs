namespace _16.Array_Symmetry
{

    using System;

    public class Problem16
    {

        public static void Main()
        {
            var strArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var isSymetric = true;

            for (int i = 0; i < strArr.Length / 2; i++)
            {
                if (strArr[i] != strArr[strArr.Length - 1 - i])
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
