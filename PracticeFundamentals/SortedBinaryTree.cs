using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class SortedBinaryTree
    {
        TreeNode root;
        List<TreeNode> nodes = new List<TreeNode>();
        private int lastOperatedLevel;
        public SortedBinaryTree(int rootData)
        {
            root = new TreeNode(rootData);
        }
        public void AddItems(int[] items)
        {
            var orderedItems = items.OrderBy(i => i);
            var itemNode = new TreeNode(items[0]);
            if (root == null)
            {
                root = itemNode;
                lastOperatedLevel = 0;
                itemNode.Level = 0;
            }
            nodes.Add(root);
            GenerateChildren(new[] { root }, items.Skip(1).ToArray());
        }

        private void GenerateChildren(TreeNode[] parents, int[] elements)
        {
            if (elements == null || elements.Count() == 0 || parents == null)
                return;
            
            var elementIndex = 0;
            foreach (var parent in parents)
            {
                lastOperatedLevel++;
                var resultLeft = new TreeNode(elements[elementIndex++]);
                resultLeft.Level = parent.Level + 1;
                parent.Left = resultLeft;
                nodes.Add(parent.Left);
                //GenerateChildren(parent.Left, leftoutElements.ToArray());

                if (elements.Count() > 1)
                {
                    var resultRight = new TreeNode(elements[elementIndex++]);
                    resultRight.Level = parent.Level + 1;
                    parent.Right = resultRight;
                    nodes.Add(parent.Right);
                    //GenerateChildren(parent.Right, leftoutElements.ToArray());
                }
            }

            var leftoutElements = elements.Count() >= elementIndex ? elements.Skip(elementIndex) : elements;
            GenerateChildren(nodes.Where(n => n.Level == lastOperatedLevel).ToArray(), leftoutElements.ToArray());
        }

        public void DrawTree(TreeNode root = null)
        {
            if (root == null)
            {
                if (this.root == null)
                    return;
                else
                    root = this.root;
            }
            root.PrintPretty("", false);
        }
    }
}
