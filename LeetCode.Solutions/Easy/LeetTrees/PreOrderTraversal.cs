using Common.Setup;
using System;
using System.Collections;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class PreOrderTraversal : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(6);
            dataTypes.InputTree.InsertNode(new TreeNode(3));
            dataTypes.InputTree.InsertNode(new TreeNode(8));
            dataTypes.InputTree.InsertNode(new TreeNode(2));
            dataTypes.InputTree.InsertNode(new TreeNode(13));
            dataTypes.InputTree.InsertNode(new TreeNode(10));
            // output : 6, 3, 2, 8, 13, 10
            TraverseWithoutRecursion(dataTypes.InputTree);
        }

        private void Traverse(TreeNode node)
        {
            Console.WriteLine(node.Val);
            if(node.Left != null) Traverse(node.Left);
            if(node.Right != null) Traverse(node.Right);
        }

        private void TraverseWithoutRecursion(TreeNode node)
        {
            if (node == null) return;
            Stack s = new Stack();
            s.Push(node);

            while (s.Count > 0)
            {
                node = (TreeNode) s.Pop();
                Console.Write(node.Val + " ");
                if (node.Right != null)
                    s.Push(node.Right);
                if (node.Left != null)
                    s.Push(node.Left);
            }
        }
    }
}
