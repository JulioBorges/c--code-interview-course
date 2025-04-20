using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class1 : IExecution
    {
        public string Name => "Multidimensional Arrays";

        public string Description => "To construct a multidimensional array in C#, we use arrays of arrays. Here are examples to demonstrate how to create and work with 2D static arrays.";

        public void Run()
        {
            int[,] array =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}