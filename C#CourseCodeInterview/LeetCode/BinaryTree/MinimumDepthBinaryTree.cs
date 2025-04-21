using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;
using System.ComponentModel.Design;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class MinimumDepthBinaryTree : IExecution
    {
        public string Name => "Minimum Depth of Binary Tree";

        public string Description => "Given the root of a binary tree, return its minimum depth.";

        public void Run()
        {
            TestCase([3, 9, 20, null, null, 15, 7]);
            TestCase([1, null, 2]);
        }
        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);

            Console.WriteLine("---");
            Console.WriteLine($"The min dept  in [{string.Join(", ", values)}] is: {MinDepth(root)}");
            Console.WriteLine();
        }

        private int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            if (root.left == null)
                return 1 + MinDepth(root.right);

            if (root.right == null)
                return 1 + MinDepth(root.left);

            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}