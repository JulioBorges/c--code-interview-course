using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Practice6 : IExecution
    {
        public string Name => "Print traversal multidimencional array odd and even";

        public string Description => "In this challenge, let's adjust our matrix traversal method! Originally, our method involved traversing even-indexed columns upwards and odd-indexed columns downwards. Your task is to reverse this pattern without adding new lines of code. Make the necessary change in the condition within the loop so that even-indexed columns are traversed downwards, and odd-indexed ones upwards. Let's enhance this pattern!";

        public void Run()
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            PrintMatrixTraversal(matrix);
        }

        public static void PrintMatrixTraversal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int col = cols - 1; col >= 0; --col)
            {
                // Orignal is:
                //if (col %2 != 0)
                if (col % 2 == 0)
                {
                    for (int row = rows - 1; row >= 0; --row)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                else
                {
                    for (int row = 0; row < rows; ++row)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
            }
        }
    }
}
