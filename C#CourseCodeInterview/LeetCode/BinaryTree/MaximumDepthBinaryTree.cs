using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class MaximumDepthBinaryTree : IExecution
    {
        public string Name => "Maximum Depth of Binary Tree";

        public string Description => "Given the root of a binary tree, return its maximum depth.\r\n\r\nA binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.";

        public void Run()
        {
            TestCase([3, 9, 20, null, null, 15, 7]);
            TestCase([1, null, 2]);
        }

        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);

            Console.WriteLine("---");
            Console.WriteLine($"The max dept  in [{string.Join(", ", values)}] is: {MaxDepth(root)}");
            Console.WriteLine();
        }

        private int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return 1 + Math.Max(rightDepth, leftDepth);
        }
    }
}
