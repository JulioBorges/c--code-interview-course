namespace C_CourseCodeInterview.Utils
{
    using C_CourseCodeInterview.Models;
    using System;
    using System.Collections.Generic;

    public static class BinaryTreeConsoleWriter
    {
        public static void Print(TreeNode? root)
        {
            Print(root, "", true, false, true);
        }

        private static void Print(TreeNode? node, string indent, bool isLast, bool isRightChild, bool isRoot)
        {
            if (node == null)
                return;

            Console.Write(indent);

            if (isLast)
            {
                Console.Write("└──");
                indent += "   ";
            }
            else
            {
                Console.Write("├──");
                indent += "│  ";
            }

            // Definir cor baseada no tipo de nó
            if (isRoot)
                Console.ForegroundColor = ConsoleColor.White;
            else if (isRightChild)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            // Escrever o valor do nó
            if (isRightChild)
                Console.Write($"{node.val}─|");
            else
                Console.Write($"{node.val}");

            Console.ResetColor();
            Console.WriteLine();

            // Checar se existe filho esquerdo e direito
            bool hasLeft = node.left != null;
            bool hasright = node.right != null;

            if (hasLeft)
                Print(node.left, indent, !hasright, false, false); // Filho esquerdo
            if (hasright)
                Print(node.right, indent, true, true, false); // Filho direito
        }
    }
}
