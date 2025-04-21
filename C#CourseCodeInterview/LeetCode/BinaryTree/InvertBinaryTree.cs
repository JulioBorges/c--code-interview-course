using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class InvertBinaryTree : IExecution
    {
        public string Name => "226. Invert Binary Tree";

        public string Description => "Given the root of a binary tree, invert the tree, and return its root.";

        public void Run()
        {
            TestCase([4, 2, 7, 1, 3, 6, 9]);
            TestCase([2, 1, 3]);
        }

        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);
            Console.WriteLine("---");

            Console.WriteLine("Original: ");
            BinaryTreeConsoleWriter.Print(root);

            TreeNode inverted = InvertTree(root);

            Console.WriteLine("Inverted: ");
            BinaryTreeConsoleWriter.Print(inverted);

            Console.WriteLine();
        }

        private static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var newRoot = new TreeNode(root.val)
            {
                left = InvertTree(root.right),
                right = InvertTree(root.left)
            };

            return newRoot;
        }
    }
}
