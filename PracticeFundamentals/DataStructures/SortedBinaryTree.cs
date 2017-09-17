using System.Collections.Generic;
using System.Linq;
namespace PracticeFundamentals.DataStructures
{
   
    class SortedBinaryTree : Tree
    {
        TreeNode root;
        List<TreeNode> nodes = new List<TreeNode>();
        public SortedBinaryTree(int rootData)
            :base(rootData)
        {
        }
        protected override void GenerateChildren(TreeNode[] parents, int[] elements)
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

       
    }
}
