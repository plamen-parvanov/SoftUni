namespace _02._Parking_Feud
{
    using System;
    using System.Linq;

    public class Problem02
    {
        private static int[,] matrix;
        private static int passed;
        private static int samStartRow;
        private static int samIndex;

        public static void Main()
        {
            CreateMatrix();

            StartParking();
        }

        private static void StartParking()
        {
            samStartRow = int.Parse(Console.ReadLine()) * 2 - 1;
            samIndex = samStartRow - 1;
            passed = 0;

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var samParkingSlot = input[samStartRow - 1];

                
                if (input.Where(x => x == samParkingSlot).ToArray().Length < 2)
                {
                    passed += CalculatePassedSlots(samParkingSlot, samStartRow);

                    SamParksAt(samParkingSlot);
                }

                if (Array.IndexOf(input, samParkingSlot) == samIndex)
                {
                    Conflickt(samIndex,
                        Array.LastIndexOf(input, samParkingSlot),
                        input);
                }
                else
                {
                    Conflickt(samIndex,
                         Array.IndexOf(input, samParkingSlot),
                         input);
                }
                
                
            }
        }

        private static void Conflickt(int samIndex, int secondIndex, string[] input)
        {
             var samDistance = CalculatePassedSlots(input[samIndex], samIndex * 2 + 1);
            var secondDistance = CalculatePassedSlots(input[secondIndex], secondIndex * 2 + 1);

            if (samDistance > secondIndex)
            {
                passed += (samDistance * 2);
                return;
            }

            passed += samDistance;

            SamParksAt(input[samIndex]);
        }

        private static int MyNewCalcDistance(int startRow, string parkSlot)
        {
            var startCol = 0;

            var parkRow = parkSlot.Substring(1);
            var parlCol = parkSlot[0] - 'A' + 1;

        }

        private static void SamParksAt(string slot)
        {
            Console.WriteLine($"Parked successfully at {slot}.");
            Console.WriteLine($"Total Distance Passed: {passed}");

            System.Environment.Exit(1);
        }

        private static int CalculatePassedSlots(string slot, int startRow)
        {
            var result = 0;
            var slotRow = int.Parse(slot.Substring(1)) * 2 - 2;
            var slotCol = slot[0] - 'A' + 1;
            var movedRows = 0;

            while (true)
            {
                if (ParkingSlotIsOnThisRow(slotRow, startRow))
                {
                    if (movedRows % 2 == 0)
                    {
                        result += slotCol;
                        break;
                    }

                    result += (matrix.GetLength(1) - slotCol - 1);
                    break;
                }


                if (slotRow > startRow)
                {
                    startRow += 2;
                }
                else
                {
                    startRow -= 2;
                }
                
                result += matrix.GetLength(1) + 1;
                movedRows++;
            }

            return result;
        }

        private static bool ParkingSlotIsOnThisRow(int slotRow, int startRow)
        {
            return Math.Abs(slotRow - startRow) == 1;
        }

        private static void CreateMatrix()
        {
            var dimentions = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            var cols = dimentions[0] + 2;
            var rows = dimentions[1] * 2 - 1;

            matrix = new int [rows, cols];
        }
    }
}
