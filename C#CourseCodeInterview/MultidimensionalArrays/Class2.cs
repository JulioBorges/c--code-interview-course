using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class2 : IExecution
    {
        public string Name => "Adding a New Row or Column";

        public string Description => "To add a new row or column to a 2D static array, create a new array with the desired dimensions, then copy the existing elements into it.";

        public void Run()
        {
            int[,] array =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Create a new array with an additional row
            int[,] newArray = new int[array.GetLength(0) + 1, array.GetLength(1)]; // Add 1 more row

            // Copy existing array elements
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }

            // Add new values to the extra row
            newArray[3, 0] = 10;
            newArray[3, 1] = 11;
            newArray[3, 2] = 12;

            // Display the new array
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    Console.Write(newArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}