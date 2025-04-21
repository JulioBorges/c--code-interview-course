using C_CourseCodeInterview.Models;

namespace C_CourseCodeInterview.Utils
{
    public static class BinaryTreeBuilder
    {

        public static TreeNode BuildTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
                return null;

            TreeNode root = new TreeNode(arr[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                // Preenche filho esquerdo
                if (i < arr.Length && arr[i] != null)
                {
                    current.left = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.left);
                }
                i++;

                // Preenche filho direito
                if (i < arr.Length && arr[i] != null)
                {
                    current.right = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}
