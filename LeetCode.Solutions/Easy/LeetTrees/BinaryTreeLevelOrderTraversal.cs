using System;
using System.Collections.Generic;
using System.Linq;
using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetTrees
{
    public class BinaryTreeLevelOrderTraversal :IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputTree = new TreeNode(3);
            dataTypes.InputTree.InsertNode(new TreeNode(9));
            dataTypes.InputTree.InsertNode(new TreeNode(20));
            dataTypes.InputTree.InsertNode(new TreeNode(15));
            dataTypes.InputTree.InsertNode(new TreeNode(17));
            foreach (var height in LevelOrder(dataTypes.InputTree))
            {
                foreach (var i in height)
                    Console.Write(i + " ");
                Console.WriteLine();
            }

            
        }

        private IList<IList<int>> LevelOrder(TreeNode root)
        {
            var list = new List<IList<int>>();

            return list;
        }
    }
}
