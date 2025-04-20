using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class3 : IExecution
    {
        public string Name => "Removing a Row or Column";

        public string Description => "To remove a row or column from a 2D static array, create a new array with the reduced dimensions and copy over the elements while skipping the one you want to remove.";

        public void Run()
        {
            int[,] array =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Removing the second row (index 1)
            int[,] rowRemovedArray = new int[array.GetLength(0) - 1, array.GetLength(1)]; // New array with 1 less row

            // Copy elements except the second row
            int rowIndex = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i != 1)
                { // Skip row 1
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        rowRemovedArray[rowIndex, j] = array[i, j];
                    }
                    rowIndex++;
                }
            }

            // Display the new array (with row removed)
            for (int i = 0; i < rowRemovedArray.GetLength(0); i++)
            {
                for (int j = 0; j < rowRemovedArray.GetLength(1); j++)
                {
                    Console.Write(rowRemovedArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}