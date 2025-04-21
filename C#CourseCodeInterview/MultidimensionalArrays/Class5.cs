using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class5 : IExecution
    {
        public string Name => "Matrix Traversal  ";

        public string Description => "You've been given a 2D array consisting of individual cells, each holding a unique integer value. Your goal is to create a function that will traverse this matrix, starting at the bottom-right cell. From there, you'll travel up to the top of the same column, then move left to the next column, and then continue downward from the top of this new column. After reaching the bottom of the column, you'll again move left and start moving upward. This unique traversal pattern will be performed until all the cells have been visited.";

        public void Run()
        {
            int[,] matrix = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            int[] result = ColumnTraverse(matrix);
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static int[] ColumnTraverse(int[,] matrix)
        {
            int rows = matrix.GetLength(0); // Obtém o número de linhas da matriz
            int cols = matrix.GetLength(1); // Obtém o número de colunas da matriz
            string direction = "up"; // Define a direção inicial como "cima"
            int row = rows - 1; // Começa na última linha
            int col = cols - 1; // Começa na última coluna
            int[] output = new int[rows * cols]; // Cria um array para armazenar os valores na ordem de travessia
            int index = 0; // Índice para preencher o array de saída

            while (index < rows * cols) // Continua até que todos os elementos sejam visitados
            {
                output[index++] = matrix[row, col]; // Adiciona o valor atual da célula ao array de saída, já movendo o índice para o próximo valor

                if (direction == "up") // Se a direção for "cima"
                {
                    if (row - 1 < 0) // Verifica se chegou ao topo da coluna
                    {
                        direction = "down"; // Altera a direção para "baixo"
                        col -= 1; // Move para a próxima coluna à esquerda
                    }
                    else
                    {
                        row -= 1; // Move uma linha para cima
                    }
                }
                else // Se a direção for "baixo"
                {
                    if (row + 1 == rows) // Verifica se chegou ao final da coluna
                    {
                        direction = "up"; // Altera a direção para "cima"
                        col -= 1; // Move para a próxima coluna à esquerda
                    }
                    else
                    {
                        row += 1; // Move uma linha para baixo
                    }
                }
            }

            return output; // Retorna o array com os valores na ordem de travessia
        }
    }
}
