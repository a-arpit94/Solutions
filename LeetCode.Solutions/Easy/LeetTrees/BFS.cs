using System;
using Common.Setup;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class BFS : IOperation
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
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                root = queue.Dequeue();
                if(root.Left != null) queue.Enqueue(root.Left);
                if(root.Right != null) queue.Enqueue(root.Right);
                yield return root.Val;
            }

        }

    }
}
