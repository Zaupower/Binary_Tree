// See https://aka.ms/new-console-template for more information
using BinaryTree.Iterable;
using BinaryTree.Tree;
using ExamResult;
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
        DateTime date1 = new DateTime(2015, 12, 26);
        DateTime date2 = new DateTime(2015, 12, 27);
        DateTime date3 = new DateTime(2015, 12, 28);
        DateTime date4 = new DateTime(2015, 12, 29);
        DateTime date5 = new DateTime(2015, 12, 30);

        ExamResult examResult1 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);
        ExamResult examResult2 = new ExamResult(1, "Antonio", Exams.PHYSICS, Score.B, date2);
        ExamResult examResult3 = new ExamResult(3, "Soares", Exams.ENGLISH, Score.A, date3);
        ExamResult examResult4 = new ExamResult(2, "Marcelo", Exams.ENGLISH, Score.A, date1);
        ExamResult examResult5 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);



    }     
}