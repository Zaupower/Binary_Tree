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
        private DateTime date1;
        private DateTime date2;
        private DateTime date3;
        private DateTime date4;
        private DateTime date5;

        ExamResult examResult1;
        ExamResult examResult2;
        ExamResult examResult3;
        ExamResult examResult4;
        ExamResult examResult5;

        [SetUp]
        public void SetUp()
        {            
            date1 = new DateTime(2015, 12, 26);
            date2 = new DateTime(2015, 12, 27);
            date3 = new DateTime(2015, 12, 28);
            date4 = new DateTime(2015, 12, 29);
            date5 = new DateTime(2015, 12, 30);

            ExamResult examResult1 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);
            ExamResult examResult2 = new ExamResult(1, "Antonio", Exams.PHYSICS, Score.B, date2);
            ExamResult examResult3 = new ExamResult(3, "Soares", Exams.ENGLISH, Score.A, date3);
            ExamResult examResult4 = new ExamResult(2, "Marcelo", Exams.ENGLISH, Score.A, date4);
            ExamResult examResult5 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date5);

            Tree<ExamResult> treeExamResults = new Tree<ExamResult>();

            treeExamResults.Add(examResult1);
            treeExamResults.Add(examResult2);
            treeExamResults.Add(examResult3);
            treeExamResults.Add(examResult4);
            treeExamResults.Add(examResult5);
        }
        [TearDown]
        public void Postcondition()
        {           
            Tree<ExamResult> treeExamResults = new Tree<ExamResult>();
        }

        [Test]
        public void ExamResult_AddValue()
        {
            ExamResult[] exams = { examResult1, examResult2, examResult3, examResult4, examResult5 };
            Tree<ExamResult> treeExamResults = new Tree<ExamResult>();
            
            for (int i = 0; i < exams.Length; i++)
            {
                treeExamResults.Add(exams[i]);
            };

            Assert.AreEqual(treeExamResults.getNodeCounter(), exams.Length);
        }

        [Test]
        public void ExamResult_IsEquivalent()
        {          
            ExamResult[] testArray = new ExamResult[] { examResult1, examResult2, examResult3,examResult4, examResult5 };

            GenericEnumerableList<ExamResult> testList = new GenericEnumerableList<ExamResult>(testArray); 
            GenericEnumerableList<ExamResult> listExpected = treeExamResults.Traverse();

            CollectionAssert.AreEquivalent(listExpected, testList);
            
        }

        [Test]
        public void ExamResult_IsIterable()
        {

            ExamResult[] testArray = new ExamResult[5];
            int counter = 0;

            Tree<ExamResult> treeExamResults = new Tree<ExamResult>();

            treeExamResults.Add(examResult1);
            treeExamResults.Add(examResult2);
            treeExamResults.Add(examResult3);
            treeExamResults.Add(examResult4);
            treeExamResults.Add(examResult5);
            GenericEnumerableList<ExamResult> expected = treeExamResults.Traverse();
            
            foreach (ExamResult item in expected)
            {
                testArray[counter++] = item;
            }
            GenericEnumerableList<ExamResult> testList = new GenericEnumerableList<ExamResult>(testArray);
            CollectionAssert.AreEquivalent(expected, testList);
        }
        //Falta testar inserir mesmo valor e esperar exception
        //Falta testar com reverseInOrder
    }
}
