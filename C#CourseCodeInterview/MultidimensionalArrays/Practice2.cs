using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice2 : IExecution
    {
        public string Name => "Practice 2 - Traverse multidimensional array";

        public string Description => "The provided C# code is meant to list all unoccupied apartments in an apartment building. Each apartment has a number and an occupancy status; however, the code doesn't work correctly at the moment. Your task is to fix the code so that it functions as intended.";

        public void Run()
        {
            string[,] building = {
                {"101 true", "102 false", "103 false"},
                {"201 true", "202 true", "203 false"}
            };

            // Traverse the building
            for (int i = 0; i < building.GetLength(0); i++)
            {
                for (int j = 0; j < building.GetLength(1); j++)
                {
                    string[] parts = building[i, j].Split(' ');
                    string number = parts[0];
                    bool occupied = bool.Parse(parts[1]);

                    if (!occupied)
                    {
                        Console.WriteLine("Apartment " + number + " is not occupied.");
                    }
                }
            }
        }
    }
}
