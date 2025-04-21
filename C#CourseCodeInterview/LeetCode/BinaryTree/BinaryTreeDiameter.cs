using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class BinaryTreeDiameter : IExecution
    {
        public string Name => "543. Diameter of Binary Tree";

        public string Description => @"Given the root of a binary tree, return the length of the diameter of the tree.

The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

The length of a path between two nodes is represented by the number of edges between them.";

        public void Run()
        {
            TestCase([1, 2, 3, 4, 5]);
        }

        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);

            Console.WriteLine("---");
            Console.WriteLine($"The diameter for [{string.Join(", ", values)}] is: {DiameterOfBinaryTree(root)}");
            Console.WriteLine();
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxDepth(root);

            return diameter;
        }

        private int diameter = 0;

        private int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            diameter = Math.Max(diameter, leftDepth + rightDepth);

            // E retornamos a profundidade desse nó
            return 1 + Math.Max(leftDepth, rightDepth);
        }
    }
}
