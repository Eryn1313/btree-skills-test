using System;
using System.Linq;
using BTreeSkillsTest.Models;
using BTreeSkillsTest.Services;

namespace BTreeSkillsTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                BTree bTree = new BTree();
                PrintTree printTree = new PrintTree();
                string node1;
                string node2;
                string[] input;

                printTree.Print(bTree.Root, "");

                Console.WriteLine("****************************************************************");

                Console.WriteLine("Please enter the names of the nodes you'd like to find the parent of (type quit to quit): ");

                input = Console.ReadLine().Trim().Split(' ');

                if (input.Contains("quit"))
                {
                    break;
                }

                if (input.Length > 1)
                {
                    node1 = input[0];
                    node2 = input[1];
                }
                else
                {
                    node1 = input.First();
                    node2 = Console.ReadLine();
                }

                bool success = new BTreeNodeService(new Node { Name = node1 }, new Node { Name = node2 })
                    .SetSelectedAndParentNodes(bTree.Root);

                if (success)
                {
                    printTree.Print(bTree.Root, "");
                }
                else
                {
                    Console.WriteLine("Parent not found, make sure to enter the correct node names");
                }

                Console.WriteLine("****************************************************************");
            }
        }
    }
}
