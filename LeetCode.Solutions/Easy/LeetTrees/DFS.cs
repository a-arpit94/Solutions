using Common.Setup;
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class DFS : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(6);
            dataTypes.InputTree.InsertNode(new TreeNode(3));
            dataTypes.InputTree.InsertNode(new TreeNode(8));
            dataTypes.InputTree.InsertNode(new TreeNode(2));
            dataTypes.InputTree.InsertNode(new TreeNode(13));
            dataTypes.InputTree.InsertNode(new TreeNode(10));
            dataTypes.InputTree.InsertNode(new TreeNode(4));
            dataTypes.InputTree.InsertNode(new TreeNode(14));
            foreach (var i in Implementation(dataTypes.InputTree))
                Console.WriteLine(i);
        }

        private IEnumerable<int> Implementation(TreeNode root)
        {
            if (root == null) yield return int.MinValue;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                if(root.Left != null) stack.Push(root.Left);
                if(root.Right != null) stack.Push(root.Right);
                yield return root.Val;
            }

        }
    }
}
