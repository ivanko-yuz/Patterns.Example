using System;

namespace Patterns.Example.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            //root.Remove(leaf);

            Composite innerComp = new Composite("Composite XY");
            innerComp.Add(new Leaf("Leaf XYA"));
            innerComp.Add(new Leaf("Leaf XYB"));

            comp.Add(innerComp);

            // Recursively display tree
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
