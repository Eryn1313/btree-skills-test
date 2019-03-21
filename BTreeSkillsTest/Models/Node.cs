namespace BTreeSkillsTest.Models
{
    public class Node
    {
        private string name;
        private bool parent;
        private bool selected;

        public string Name { get { return name; } set { name = value; } }
        public bool Parent { get { return parent; } set { parent = value; } }
        public bool Selected { get { return selected; } set { selected = value; } }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public override bool Equals(object obj)
        {
            Node node = obj as Node;

            return Name.ToLower() == node.Name.ToLower();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
