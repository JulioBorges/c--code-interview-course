using C_CourseCodeInterview.Base;
using C_CourseCodeInterview.Models;
using C_CourseCodeInterview.Utils;

namespace C_CourseCodeInterview.LeetCode.BinaryTree
{
    public class SameBinaryTree : IExecution
    {
        public string Name => "Is Same Tree";

        public string Description => "Compare two trees if are same";

        public void Run()
        {
            TestCase([3, 9, 20, null, null, 15, 7], [3, 9, 20, null, null, 15, 7]);
            TestCase([1, null, 2], [1, null, 2]);
        }

        private void TestCase(int?[] pValues, int?[] qValues)
        {
            TreeNode p = BinaryTreeBuilder.BuildTree(pValues);
            TreeNode q = BinaryTreeBuilder.BuildTree(qValues);

            Console.WriteLine("---");
            Console.WriteLine($"The [{string.Join(", ", pValues)}] is: {(IsSameTree(p,q) ? "same" : "not same")}");
            Console.WriteLine();
        }

        private bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || 
                q == null || 
                p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}