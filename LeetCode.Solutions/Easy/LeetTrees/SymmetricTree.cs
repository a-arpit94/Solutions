using Common.Setup;
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class SymmetricTree : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(4)
                },
                Right = new TreeNode(2)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(3)
                }
            };

            Console.WriteLine(IsSymmetry(dataTypes.InputTree));
        }

        private bool IsSymmetry(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root.Left);
            queue.Enqueue(root.Right);

            while (queue.Count > 0)
            {
                TreeNode one = queue.Dequeue();
                TreeNode two = queue.Dequeue();
                if (one == null && two == null) continue;
                if (one == null ||  two == null) return false;
                if (one.Val != two.Val) return false;
                queue.Enqueue(one.Left);
                queue.Enqueue(two.Right);
                queue.Enqueue(one.Right);
                queue.Enqueue(two.Left);

            }
            return true;
        }
    }
}
