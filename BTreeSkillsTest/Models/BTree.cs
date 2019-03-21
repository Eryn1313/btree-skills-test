namespace BTreeSkillsTest.Models
{
    public class BTree
    {
        public Node Root { get; set; }

        public BTree()
        {
            InitalizeTree();
        }

        void InitalizeTree()
        {
            Node Leaf1 = new Node { Name = "Leaf1" };
            Node Leaf2 = new Node { Name = "Leaf2" };
            Node Leaf3 = new Node { Name = "Leaf3" };
            Node Leaf4 = new Node { Name = "Leaf4" };
            Node Leaf5 = new Node { Name = "Leaf5" };

            Node Node2 = new Node { RightChild = Leaf1, LeftChild = Leaf2, Name = "Node2" };
            Node Node1 = new Node { RightChild = Node2, LeftChild = Leaf3, Name = "Node1" };
            Node Node3 = new Node { RightChild = Node1, LeftChild = Leaf5, Name = "Node3" };

            Root = new Node
            {
                RightChild = Node3,
                LeftChild = Leaf4,
                Name = "head"
            };
        }
    }
}
