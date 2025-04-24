using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class MergeTwoBinaryTrees : IExecution
    {
        public string Name => "Merge Two Binary Trees";

        public string Description => "You are given two binary trees root1 and root2.\r\n\r\nImagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not. You need to merge the two trees into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of the new tree.";

        public void Run()
        {
            TestCase([1], [1, 2]);
            TestCase([1, 3, 2, 5], [2, 1, 3, null, 4, null, 7]);
        }

        private void TestCase(int?[] values, int?[] values2)
        {
            TreeNode root1 = BinaryTreeBuilder.BuildTree(values);
            TreeNode root2 = BinaryTreeBuilder.BuildTree(values2);

            var merged = MergeTrees(root1, root2);
            Console.WriteLine("---");
            Console.WriteLine("Merged tree:");
            BinaryTreeConsoleWriter.Print(merged);
            Console.WriteLine();
        }

        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return null;

            if (root1 == null)
                return root2;

            if (root2 == null)
                return root1;

            TreeNode mergedTree = new TreeNode(root1.val + root2.val);
            mergedTree.left = MergeTrees(root1.left, root2.left);
            mergedTree.right = MergeTrees(root1.right, root2.right);

            return mergedTree;
        }
    }
}
