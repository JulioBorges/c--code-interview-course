using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.MultidimensionalArrays
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class PalindromeLinkedList : IExecution
    {
        public string Name => "Practice Palindrome with LinkedList";

        public string Description => "Given the head of a singly linked list, return true if it is a palindrome or false otherwise.";

        public void Run()
        {
            int[] case1 = [1, 2, 1];
            TestCase(case1);

            int[] case2 = [1, 2];
            TestCase(case2);

            int[] case3 = [1];
            TestCase(case3);

            int[] case4 = [1, 1];
            TestCase(case4);

            int[] case5 = [1, 2, 3, 2, 1];
            TestCase(case5);
        }

        private void TestCase(int[] vector)
        {
            var case1 = GetLinkedList(vector);

            Console.WriteLine($"Is [{string.Join(", ", vector)}] a palindrome? {IsPalindrome(case1)}");
        }

        private ListNode GetLinkedList(int[] vector)
        {
            ListNode head = new ListNode(vector[0]);
            ListNode current = head;

            for (int i = 1; i < vector.Length; i++)
            {
                current.next = new ListNode(vector[i]);
                current = current.next;
            }
            return head;
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            // 1. Encontrar o meio da lista
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2. Reverter a segunda metade da lista
            ListNode prev = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            // 3. Comparar os dois ponteiros
            ListNode left = head;
            ListNode right = prev; // início da segunda metade revertida
            while (right != null)
            {
                if (left.val != right.val)
                    return false;
                left = left.next;
                right = right.next;
            }

            return true;
        }
    }
}