namespace Common.Setup
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }

        public void pushNode(ListNode node)
        {
            if (next == null)
            {
                next = node;
                return;
            }
            next.pushNode(node);
        }
    }
}
