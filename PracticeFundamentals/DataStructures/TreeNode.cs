using System;
using System.Collections.Generic;

namespace PracticeFundamentals
{
    class TreeNode
    {
        public TreeNode(int data)
        {
            this.data = data;
        }
        public TreeNode Left;
        public TreeNode Right;
        public int data;
        public int Level;
        public void PrintPretty(string indent, bool last)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(data);

            var children = new List<TreeNode>();
            if (this.Left != null)
                children.Add(this.Left);
            if (this.Right != null)
                children.Add(this.Right);

            for (int i = 0; i < children.Count; i++)
                children[i].PrintPretty(indent, i == children.Count - 1);

        }
    }
}
