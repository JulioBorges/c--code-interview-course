using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice4 : IExecution
    {
        public string Name => "Organized Building";

        public string Description => @"In this task, we'll simulate the creation of a more organized electronic building directory using multidimensional arrays in C#. Initially, our array represents an apartment building with missing and misaligned floors. Your primary goal is to correct these issues by performing the following operations:

1. Remove an incorrect floor that is currently in the array (floor 4).
2. Add the correct floor (floor 3) in place of the removed floor.
3. Traverse through the updated array to list all apartments, ensuring the newly corrected directory accurately reflects the building's structure.";

        public void Run()
        {
            // Initializing a 2D array that represents an apartment building
            string[,] apartments =
                {
                    {"Apt 101", "Apt 102"},
                    {"Apt 201", "Apt 202"},
                    {"Apt 401", "Apt 402"} // Missing floor 3, jumping to floor 4
                };

            // Removing floor 4 (the third floor in the array)
            apartments = RemoveFloor(apartments, 2); // Removing floor at index 2 (floor 4)

            // Adding a new floor (floor 3)
            apartments = AddNewFloor(apartments, ["Apt 301", "Apt 302"]);

            // TODO: Make a walk visiting each apartment on every floor of the updated building.
            for (int i = 0; i < apartments.GetLength(0); i++)
            {
                for (int j = 0; j < apartments.GetLength(1); j++)
                {
                    Console.Write(apartments[i, j] + ", ");
                }
                Console.WriteLine();  // Move to the next floor
            }
        }

        // TODO: Add methods 'RemoveFloor' and 'AddNewFloor'
        public static string[,] RemoveFloor(string[,] apartments, int row)
        {
            string[,] newApts = new string[apartments.GetLength(0) - 1, apartments.GetLength(1)];

            int newRow = 0;

            for (int i = 0; i < apartments.GetLength(0); i++)
            {
                if (i == row) continue;

                for (int j = 0; j < apartments.GetLength(1); j++)
                {
                    newApts[newRow, j] = apartments[i, j];
                }
                newRow++;
            }

            return newApts;
        }

        public static string[,] AddNewFloor(string[,] apartments, string[] newRow)
        {
            var newApts = new string[apartments.GetLength(0) + 1, apartments.GetLength(1)];

            for (int i = 0; i < apartments.GetLength(0); i++)
            {
                for (int j = 0; j < apartments.GetLength(1); j++)
                {
                    newApts[i,j] = apartments[i, j];
                }
            }

            var newIndex = apartments.GetLength(0);
            for (int i = 0; i < newRow.Length; i++)
            {
                newApts[newIndex, i] = newRow[i];
            }

            return newApts;
        }
    }
}
