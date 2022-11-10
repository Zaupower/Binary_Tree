// See https://aka.ms/new-console-template for more information
using BinaryTree.Iterable;
using BinaryTree.Tree;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("InOrder");
        Tree<int> tree = new Tree<int>();

        tree.Add(1);
        tree.Add(3);
        tree.Add(2);

        tree.Add(5);

        tree.Traverse();

        Console.WriteLine("PreOrder");
        Tree<int> tree2 = new Tree<int>(true);

        tree2.Add(1);
        tree2.Add(3);
        tree2.Add(2);

        tree2.Add(5);

        tree2.Traverse();

        //GenericEnumerableList<string> list = new GenericEnumerableList<string>(new string[] {"1","2","3" });
        //foreach (string item in list)
        //{
        //    Console.WriteLine(item);
        //}




    }     
}