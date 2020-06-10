using Common.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class PostOrderTraversal : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(6);
            dataTypes.InputTree.InsertNode(new TreeNode(3));
            dataTypes.InputTree.InsertNode(new TreeNode(8));
            dataTypes.InputTree.InsertNode(new TreeNode(2));
            dataTypes.InputTree.InsertNode(new TreeNode(13));
            dataTypes.InputTree.InsertNode(new TreeNode(10));
            Traverse(dataTypes.InputTree);
        }

        private void Traverse(TreeNode node)
        {
            if (node.Left != null) Traverse(node.Left);
            if (node.Right != null) Traverse(node.Right);
            Console.WriteLine(node.Val);
        }

        //Remaining work to do
        private void TraverseWithoutRecursion()
        {

        }
    }
}
