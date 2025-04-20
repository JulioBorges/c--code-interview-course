using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class Class4 : IExecution
    {
        public string Name => "Break/Continue in Nested Loops";

        public string Description => "Sometimes, when we visit every apartment on each floor, we might need to start visiting the next floor midway. break helps us exit the current loop, while continue helps us skip the current iteration and move to the next one.";

        public void Run()
        {
            string[,] array = {
                {"Apt 101", "Apt 102", "Apt 103"},
                {"Apt 201", "Exit Floor", "Apt 203"},
                {"Apt 301", "Apt 302", "Apt 303"}
            };

            // Break in nested loop
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == "Exit Floor")
                    {
                        break;
                    }
                    Console.Write(array[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}