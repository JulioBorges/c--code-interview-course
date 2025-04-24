using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class BalancedBinaryTree : IExecution
    {
        public string Name => "110. Balanced Binary Tree";

        public string Description => "Given a binary tree, determine if it is height-balanced. A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.";

        public void Run()
        {
            TestCase([3, 9, 20, null, null, 15, 7]);
            TestCase([1, 2, 2, 3, 3, null, null, 4, 4]);
            TestCase([]);
        }
        private void TestCase(int?[] values)
        {
            TreeNode root = BinaryTreeBuilder.BuildTree(values);

            Console.WriteLine("---");
            Console.WriteLine($"The tree [{string.Join(", ", values)}] is: {IsBalanced(root)}");
            Console.WriteLine();
        }
        public bool IsBalanced(TreeNode root)
        {
            return CheckBalance(root) != -1;
        }

        private int CheckBalance(TreeNode node)
        {
            if (node == null) return 0;

            int left = CheckBalance(node.left);
            if (left == -1) return -1; // subárvore esquerda desbalanceada

            int right = CheckBalance(node.right);
            if (right == -1) return -1; // subárvore direita desbalanceada

            if (Math.Abs(left - right) > 1) return -1; // nó atual desbalanceado

            return 1 + Math.Max(left, right); // altura do nó atual
        }
    }
}
