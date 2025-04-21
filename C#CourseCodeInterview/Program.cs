using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Course Code Interview!");
            Console.WriteLine();

            //MultiDimensionalArrays();
            LeetCodeTraining();
        }

        private static void LeetCodeTraining()
        {
            Console.WriteLine("LeetCode examples training");
            Console.WriteLine();

            IExecution[] leetCodeTraining = [
                //new LeetCode.PalindromeLinkedList()
                //new LeetCode.BestStockPrice(),
                //new LeetCode.BinaryTree.MaximumDepthBinaryTree(),
                //new LeetCode.BinaryTree.MinimumDepthBinaryTree(),
                //new LeetCode.BinaryTree.SameBinaryTree(),
                //new LeetCode.BinaryTree.PreOrderBinaryTree(),
                //new LeetCode.BinaryTree.InOrderBinaryTree(),
                //new LeetCode.BinaryTree.PostOrderBinaryTree(),
                //new LeetCode.BinaryTree.InvertBinaryTree(),
                new LeetCode.BinaryTree.BinaryTreeDiameter(),
            ];

            RunPractices(leetCodeTraining);
        }

        private static void MultiDimensionalArrays()
        {
            Console.WriteLine("Multidimensional arrays lesson");
            Console.WriteLine();
            IExecution[] multiDimensionalArrays = [
                
                //new MultidimensionalArrays.Class1(),
                //new MultidimensionalArrays.Class2(),
                //new MultidimensionalArrays.Class3(),
                //new MultidimensionalArrays.Class4(),
                //new MultidimensionalArrays.Practice1(),
                //new MultidimensionalArrays.Practice2(),
                //new MultidimensionalArrays.Practice3(),
                //new MultidimensionalArrays.Practice4(),
                //new MultidimensionalArrays.Practice5(),
                //new MultidimensionalArrays.Class5(),
                new MultidimensionalArrays.Practice6(),
            ];

            RunPractices(multiDimensionalArrays);
        }

        private static void RunPractices(IExecution[] practices)
        {
            foreach (var practice in practices)
            {
                Console.WriteLine("====================");
                Console.WriteLine($"Running: {practice.Name}");
                Console.WriteLine("====================");
                practice.Run();
                Console.WriteLine("====================");
            }
        }
    }
}