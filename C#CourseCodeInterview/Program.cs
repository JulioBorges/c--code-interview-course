using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Course Code Interview!");
            Console.WriteLine();
            Console.WriteLine("Multidimensional arrays lesson");
            Console.WriteLine();

            MultiDimensionalArrays();
        }

        private static void MultiDimensionalArrays()
        {
            IExecution[] multiDimensionalArrays = [
                new MultidimensionalArrays.PalindromeLinkedList(),
                //new MultidimensionalArrays.Class1(),
                //new MultidimensionalArrays.Class2(),
                //new MultidimensionalArrays.Class3(),
                //new MultidimensionalArrays.Class4(),
                //new MultidimensionalArrays.Practice1(),
                //new MultidimensionalArrays.Practice2(),
                //new MultidimensionalArrays.Practice3(),
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