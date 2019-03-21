using System;
using BTreeSkillsTest.Models;

namespace BTreeSkillsTest.Services
{
    public class PrintTree
    {
        public void Print(Node node, String indent)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(indent + "+- " + FormatNodeName(node));
            Print(node.LeftChild, indent + "|  ");
            Print(node.RightChild, indent + "|  ");
        }

        string FormatNodeName(Node node)
        {
            return string.Format("{0}{1}{2}", 
                                 node.Name, 
                                 node.Parent ? "**" : "",
                                 node.Selected ? "*" : "");
        }
    }
}
