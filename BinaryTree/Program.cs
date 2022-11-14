using BinaryTree.Iterable;
using BinaryTree.Tree;
using ExamResultApp;

namespace BinaryTree;
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
        GenericEnumerableList<int> list = tree.Traverse();
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("InOrderReverse");
        
        Tree<int> tree2 = new Tree<int>(true);
        tree2.Add(1);
        tree2.Add(3);
        tree2.Add(2);
        tree2.Add(5);
        GenericEnumerableList<int> list2 = tree2.Traverse();
        foreach (int item in list2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("InOrder");
        
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
        Tree<ExamResult> treeExamResults = new Tree<ExamResult>();
        treeExamResults.Add(examResult1);
        treeExamResults.Add(examResult2);
        treeExamResults.Add(examResult3);
        treeExamResults.Add(examResult4);        
        GenericEnumerableList<ExamResult> list3 = treeExamResults.Traverse();
        foreach (ExamResult item in list3)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("InOrderReverse");
        Tree<ExamResult> treeExamResults2 = new Tree<ExamResult>(true);
        treeExamResults2.Add(examResult1);
        treeExamResults2.Add(examResult2);
        treeExamResults2.Add(examResult3);
        treeExamResults2.Add(examResult4);
        treeExamResults2.Traverse();
        GenericEnumerableList<ExamResult> list4 = treeExamResults2.Traverse();
        foreach (ExamResult item in list4)
        {
            Console.WriteLine(item.ToString());
        }
    }     
}