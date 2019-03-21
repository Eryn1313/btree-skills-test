using BTreeSkillsTest.Models;

namespace BTreeSkillsTest.Services
{
    public class BTreeNodeService
    {
        readonly Node _selectedNode1;
        readonly Node _selectedNode2;
        int selectedFound;

        public BTreeNodeService(Node selectedNode1, Node selectedNode2)
        {
            _selectedNode1 = selectedNode1;
            _selectedNode2 = selectedNode2;
        }

        public bool SetSelectedAndParentNodes(Node root)
        {

            Node parent = FindParentNode(root);
            if (parent == null)
            {
                return false;
            }
            parent.Parent = true;
            FindSelectedNodes(root);
            return true;

        }

        void FindSelectedNodes(Node node)
        {
            if (selectedFound < 2 && node != null)
            {
                if (node.Equals(_selectedNode1) || node.Equals(_selectedNode2))
                {
                    node.Selected = true;
                    selectedFound++;
                }

                FindSelectedNodes(node.LeftChild);
                FindSelectedNodes(node.RightChild);
            }
        }

        Node FindParentNode(Node root)
        {
            if (root == null)
            {
                return null;
            }

            if (_selectedNode1.Equals(root) || _selectedNode2.Equals(root))
            {
                return root;
            }

            Node l = FindParentNode(root.LeftChild);
            Node r = FindParentNode(root.RightChild);

            return l != null && r != null ? root : l ?? r;
        }
    }
}
