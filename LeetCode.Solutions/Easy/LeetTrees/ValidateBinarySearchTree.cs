using Common.Setup;
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class ValidateBinarySearchTree : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(5)
            {
                Left = new TreeNode(1),
                Right = new TreeNode(7)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(8)
                }

            };

            Console.WriteLine(IsValidBst(dataTypes.InputTree));
        }

        public bool IsValidBst(TreeNode root)
        {
            if (root == null) return true;
            var ls = InOrderTraversal(root, new List<int>());
            for (int i = 0; i < ls.Count-1; i++)
            {
                if (ls[i] >= ls[i + 1])
                    return false;
            }
            return true;
        }

        //Use iterative inordertraversal instead of recursive
        private List<int> InOrderTraversal(TreeNode root, List<int> list)
        {
            
            if (root.Left != null) InOrderTraversal(root.Left, list);
            list.Add(root.Val);
            if (root.Right != null) InOrderTraversal(root.Right, list);
            return list;
        }
    }
}
