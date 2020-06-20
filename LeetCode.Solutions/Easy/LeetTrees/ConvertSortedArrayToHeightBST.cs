using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class ConvertSortedArrayToHeightBST : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new[] {-10, -3, 0, 5, 9};
            var v = SortedArrayToBST(dataTypes.InputIntArray);

        }

        public TreeNode Root;
        private TreeNode SortedArrayToBST(int[] nums)
        {
            Root = new TreeNode(nums[nums.Length / 2]);
            bool isOneTime = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == Root.Val && isOneTime)
                {
                    isOneTime = false;
                    continue;
                }
                InsertNode(nums[i]);
            }

            return Root;
        }

        private void AddToBst(int num)
        {
            TreeNode node = Root;
            while (node != null)
            {
                if (num >= node.Val)
                {
                    if (node.Right == null)
                        node.Right = new TreeNode(num);

                    node = node.Right;
                }

                if (num < node.Val)
                {
                    if (node.Left == null)
                        node.Left = new TreeNode(num);
                    node = node.Left;
                }

            }
        }

        public void InsertNode(int num)
        {
            // Inserting BST way
            if (num >= Root.Val)
            {
                if (Root.Right == null)
                    Root.Right = new TreeNode(num);
                else
                    InsertNode(num);
            }
            else
            {
                if (Root.Left == null)
                    Root.Left = new TreeNode(num);
                else
                { 
                    InsertNode(num);
                }
            }
        }
    }
}
