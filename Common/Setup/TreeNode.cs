namespace Common.Setup
{
    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public int Val;
        
        public TreeNode(int val, TreeNode left = null, TreeNode right = null )
        {
            Left = left;
            Right = right;
            Val = val;
        }

        public void InsertNode(TreeNode node)
        {
            // Inserting BST way
            if (node.Val >= Val)
            {
                if (Right == null)
                    Right = node;
                else
                    Right.InsertNode(node);
            }
            else
            {
                if (Left == null)
                    Left = node;
                else
                {
                    Left.InsertNode(node);
                }
            }
        }
    }
}
