using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice3 : IExecution
    {
        public string Name => "Print the ground floor";

        public string Description => "Your mission is to fill in the missing part of the code to print the apartment codes on the ground floor of an apartment building. Keep your solution clear and straightforward.";

        public void Run()
        {
            // Creating a 2D array representing an apartment building
            string[,] building =
            {
                {"1A", "1B", "1C"},
                {"2A", "2B", "2C"},
                {"3A", "3B", "3C"}
            };

            // Complete the code to print the apartment codes of the ground floor only.
            for (int i = 0; i < building.GetLength(0); i++)
            {
                Console.Write(building[0, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
