using BinaryTree.Iterable;
using BinaryTree.Tree;
using ExamResultApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tree
{
    [TestFixture]
    public class TreeExamResult
    {
        //Test Add
        //Test Traverse

        private Tree<ExamResult> treeExamResults;

        [SetUp]
        public void SetUp()
        {
            
            treeExamResults = new Tree<ExamResult>();
        }
        [TearDown]
        public void Postcondition()
        {
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
            Console.WriteLine("InOrder");
            Tree<ExamResult> treeExamResults = new Tree<ExamResult>();

            treeExamResults.Add(examResult1);
            treeExamResults.Add(examResult2);
            treeExamResults.Add(examResult3);

            treeExamResults.Add(examResult4);
        }

        [Test]
        public void ExamResult_AddValue()
        {
            DateTime date1 = new DateTime(2015, 12, 26);
            DateTime date2 = new DateTime(2015, 12, 27);
            DateTime date3 = new DateTime(2015, 12, 28);
            DateTime date4 = new DateTime(2015, 12, 29);
            DateTime date5 = new DateTime(2015, 12, 30);

            ExamResult examResult1 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);
            ExamResult examResult2 = new ExamResult(1, "Antonio", Exams.PHYSICS, Score.B, date2);
            ExamResult examResult3 = new ExamResult(3, "Soares", Exams.ENGLISH, Score.A, date3);
            ExamResult examResult4 = new ExamResult(2, "Marcelo", Exams.ENGLISH, Score.A, date4);
            ExamResult examResult5 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date5);

            ExamResult[] exams = { examResult1, examResult2, examResult3, examResult4, examResult5 };
            for (int i = 0; i < exams.Length; i++)
            {
                treeExamResults.Add(exams[i]);
            };

            Assert.AreEqual(treeExamResults.getNodeCounter(), exams.Length);
        }

        //public void ExamResult_IsIterable()
        //{
        //    DateTime date1 = new DateTime(2015, 12, 26);
        //    DateTime date2 = new DateTime(2015, 12, 27);
        //    DateTime date3 = new DateTime(2015, 12, 28);
        //    DateTime date4 = new DateTime(2015, 12, 29);
        //    DateTime date5 = new DateTime(2015, 12, 30);

        //    ExamResult examResult1 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);
        //    ExamResult examResult2 = new ExamResult(1, "Antonio", Exams.PHYSICS, Score.B, date2);
        //    ExamResult examResult3 = new ExamResult(3, "Soares", Exams.ENGLISH, Score.A, date3);
        //    ExamResult examResult4 = new ExamResult(2, "Marcelo", Exams.ENGLISH, Score.A, date1);
        //    ExamResult examResult5 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);

        //    GenericEnumerableList<ExamResult> list3 = treeExamResults.Traverse();
        //    foreach (ExamResult item in list3)
        //    {
        //        Assert.IsInstanceOf(ExamResult, item);

        //        Console.WriteLine(item);
        //    }
        //}
    }
}
