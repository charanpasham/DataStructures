﻿using System;
namespace logicBuilding
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
    public class BinaryTree
    {
        TreeNode rootNode = null;
        public BinaryTree()
        {

        }
    }
}
