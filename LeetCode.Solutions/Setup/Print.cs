
namespace LeetCode.Solutions.Setup
{
    public static class Print
    {
        public static void printAllLinkedListNodes(ListNode node)
        {
            while (node != null)
            {
                System.Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }
}
