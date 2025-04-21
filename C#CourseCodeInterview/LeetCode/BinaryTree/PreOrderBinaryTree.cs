using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class PreOrderBinaryTree : IExecution
    {
        public string Name => "Implement a pre-order binary tree traversal";

        public string Description => "A pre order traversal strategy is based on this read order: root node -> left node -> right node";

        public void Run()
        {
            //TestCase([1, 2, 3, 4, 5, null, null]);

            // 1:
            //TestCase([1, 2, null, 3, null]);

            // 2:
            // TestCase([1, null, 2, null, 3, null]);

            // 3: 
            TestCase([1, 2, 3, null, null, null, 4]);

            //TestCase([10, 5, 20, 3, 7, 15, 30, 2, null, null, null, 12, null, null, null]);
            //TestCase([50, 25, 75, 10, 30, 60, 90, 5, 15, null, 35, null, null, 80, 100, null, null, 12]);
        }

        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);

            Console.WriteLine("---");
            Console.WriteLine("Traversal this tree in Pre order traversal");
            BinaryTreeConsoleWriter.Print(root);

            Console.WriteLine();

            PreOrder(root);

            Console.WriteLine();
        }

        private void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.val + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }
    }
}
