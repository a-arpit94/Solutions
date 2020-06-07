using Common.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class MaximumDepthOfBinaryTree : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(3);
            dataTypes.InputTree.InsertNode(new TreeNode(9));
            dataTypes.InputTree.InsertNode(new TreeNode(20));
            dataTypes.InputTree.InsertNode(new TreeNode(15));
            dataTypes.InputTree.InsertNode(new TreeNode(7));
            Console.WriteLine(MaxDepth(dataTypes.InputTree));
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = MaxDepth(root.Left);
            int rightHeight = MaxDepth(root.Right);
            if (leftHeight < rightHeight)
                return rightHeight+1;
            return leftHeight+1;
        }
    }
}