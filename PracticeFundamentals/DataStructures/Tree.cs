using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFundamentals
{
    abstract class Tree
    {
        TreeNode root;
        List<TreeNode> nodes = new List<TreeNode>();
        protected int lastOperatedLevel = 0;
        public Tree(int rootData)
        {
            root = new TreeNode(rootData);
        }
        public virtual void AddItems(int[] items)
        {
            var orderedItems = items.OrderBy(i => i);
            var itemNode = new TreeNode(items[0]);
            if (root == null)
            {
                lastOperatedLevel = 0;
                root = itemNode;
                itemNode.Level = 0;
            }
            nodes.Add(root);
            GenerateChildren(new[] { root }, items.Skip(1).ToArray());
        }

        protected abstract void GenerateChildren(TreeNode[] parents, int[] elements);

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
