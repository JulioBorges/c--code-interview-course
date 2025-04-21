using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice5 : IExecution
    {
        public string Name => "3-story residential building";

        public string Description =>
            @"You are managing a 3-story residential building using C# 2D arrays. Your tasks are to:

1. Create a 3-story building (2D array) with 3 units per floor.
2. Mark one unit as vacant by changing its value.
3. Print the names of all units, floor by floor.";

        public void Run()
        {
            // TODO: Initialize a 3-story building with 3 units per floor using a 2D array.
            string[,] storyBuilding =  {
                {"Apt 101", "Apt 102", "Apt 103"},
                {"Apt 201", "Apt 202", "Apt 203"},
                {"Apt 301", "Apt 302", "Apt 303"}
            };

            // TODO: Update the name of one of the apartments to "Vacant".

            storyBuilding[2, 1] = "Vacant";

            // TODO: Traverse the building and print out the names of all units, one floor at a time.
            for (int i = 0; i < storyBuilding.GetLength(0); i++)
            {
                for (int j = 0; j < storyBuilding.GetLength(1); j++)
                {
                    Console.Write(storyBuilding[i, j] + ", ");
                }
                Console.WriteLine();  // Move to the next floor
            }
        }
    }
}
