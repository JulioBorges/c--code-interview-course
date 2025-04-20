using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice1 : IExecution
    {
        public string Name => "Practice 1 - Update multidimensional array";

        public string Description => "Apply what you've learned about updating elements in multidimensional arrays to complete this task. Your job is to update the second apartment on the second floor of the from to in the provided C# 2D array. Make sure not to alter the original array initialization; perform the update after the array has been created. This exercise is a great way to practice accessing and modifying specific elements in a 2D array. Let's improve our apartment building in C#!apartmentBuilding\"Apt 202\"\"Renovated Apt 202\"";

        public void Run()
        {
            string[,] apartmentBuilding =
            {
                {"Apt 101", "Apt 102", "Apt 103"},
                {"Apt 201", "Apt 202", "Apt 203"},
                {"Apt 301", "Apt 302", "Apt 303"}
            };

            // Update "Apt 202" to "Renovated Apt 202" in `apartmentBuilding`
            apartmentBuilding[1, 1] = "Renovated Apt 202";

            // Print all the apartments after the renovation update
            for (int i = 0; i < apartmentBuilding.GetLength(0); i++)
            {
                for (int j = 0; j < apartmentBuilding.GetLength(1); j++)
                {
                    Console.Write(apartmentBuilding[i, j] + ", ");
                }
                Console.WriteLine();  // Move to the next floor
            }
        }
    }
}