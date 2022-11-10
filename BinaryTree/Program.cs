// See https://aka.ms/new-console-template for more information
using BinaryTree.Iterable;
using BinaryTree.Tree;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree<int> tree = new Tree<int>(true);

        tree.Add(1);
        tree.Add(3);
        tree.Add(2);

        tree.Add(5);
        tree.Add(0);

        tree.Traverse();
        //GenericEnumerableList<string> list = new GenericEnumerableList<string>(new string[] {"1","2","3" });
        //foreach (string item in list)
        //{
        //    Console.WriteLine(item);
        //}




    }     
}