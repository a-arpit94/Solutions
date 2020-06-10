using Common.Setup; 
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class InOrderTraversal : IOperation
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

            if (node.Left != null)
                Traverse(node.Left);
            Console.WriteLine(node.Val);
            if(node.Right != null)
                Traverse(node.Right);
        }

        //Remaining work to do
        private void TraverseWithoutRecursion(TreeNode root)
        {
            if (root == null) return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            
            while (stack.Count > 0)
            {

            }


        }
    }
}
