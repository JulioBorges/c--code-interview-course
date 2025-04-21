using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class6 : IExecution
    {
        public string Name => "Traverse Using Decreasing Range";

        public string Description => "We can leverage the utility of C#'s for loop to traverse a 2D matrix in reverse order. This flexibility can also create a sequence that decrements.";

        public void Run()
        {
            int[,] matrix = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            int[] result = ReverseTraverse(matrix);
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }

        public static int[] ReverseTraverse(int[,] matrix)
        {
            int rows = matrix.GetLength(0); // Pego a quantidade de linhas
            int cols = matrix.GetLength(1); // Pego a quantidade de colunas
            int[] output = new int[rows * cols]; // Crio um array de inteiros com o tamanho igual a quantidade de linhas * quantidade de colunas
            int index = 0; // Crio um index para controlar a posição do array

            for (int row = rows - 1; row >= 0; --row) // Percorro as linhas de baixo para cima
            {
                for (int col = cols - 1; col >= 0; --col) // Percorro as colunas da direita para a esquerda
                {
                    // Adiciono o valor da matriz na posição do array
                    output[index++] = matrix[row, col];
                }
            }

            return output;
        }
    }
}
