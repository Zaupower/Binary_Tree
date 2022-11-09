// See https://aka.ms/new-console-template for more information
using BinaryTree;
using BinaryTree.Iterable;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree<int> tree = new Tree<int>();

        tree.Add(1);
        tree.Add(3);
        tree.Add(2);

        tree.Add(5);
        tree.Add(0);

        GenericEnumerableList<int> list = new GenericEnumerableList<int>(new int[] {1,2,3 });
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }




    }     
}