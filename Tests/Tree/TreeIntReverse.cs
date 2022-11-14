using BinaryTree.Iterable;
using BinaryTree.Tree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tree
{
    public class TreeIntReverse
    {

        private Tree<int> treeExamResults;
        private int[] Values;
        private int SizeValues = 7;
        private bool reversed = true;

        [SetUp]
        public void SetUp()
        {

            treeExamResults = new Tree<int>(reversed);
            Values = new int[SizeValues];

            for (int i = 0; i < SizeValues; i++)
            {
                Values[i] = i+1;
            }
            for (int i = 0; i < Values.Length; i++)
            {
                treeExamResults.Add(Values[i]);
            }
        }
        [TearDown]
        public void Postcondition()
        {
            treeExamResults = new Tree<int>(reversed);
            Values = new int[] { };
        }

        [Test]
        public void Int_AddValue()
        {
            Assert.AreEqual(treeExamResults.getNodeCounter(), Values.Length);
        }

        [Test]
        public void Int_IsEquivalent()
        {
            int[] testArray = new int[Values.Length];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = Values[i];
            }

            GenericEnumerableList<int> testList = new GenericEnumerableList<int>(testArray);
            GenericEnumerableList<int> listExpected = treeExamResults.Traverse();

            CollectionAssert.AreEquivalent(listExpected, testList);

        }

        [Test]
        public void Int_IsIterable()
        {

            int[] testArray = new int[Values.Length];
            int counter = 0;

            GenericEnumerableList<int> expected = treeExamResults.Traverse();

            foreach (int item in expected)
            {
                testArray[counter++] = item;
            }
            GenericEnumerableList<int> testList = new GenericEnumerableList<int>(testArray);
            CollectionAssert.AreEquivalent(expected, testList);
        }

        [Test]
        public void Int_AddExistingValue_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => treeExamResults.Add(Values[0]));
        }

        [Test]
        public void Int_IsReversed()
        {
            Tree<int> treeExamResultsNotReversed = new Tree<int>();
            
            for (int i = 0; i < Values.Length; i++)
            {
                treeExamResultsNotReversed.Add(Values[i]);
            }

            GenericEnumerableList<int> Reversed = treeExamResults.Traverse();
            GenericEnumerableList<int> NotReversed = treeExamResultsNotReversed.Traverse();

            int[] resultReversed = new int[Reversed.Count()];
            int counter = 0;
            foreach(int item in Reversed)
            {
                resultReversed[counter++] = item;
            }


            int[] resultNotReversed = new int[NotReversed.Count()];
            int counter2 = 0;
            foreach (int item in NotReversed)
            {
                resultNotReversed[counter2++] = item;
            }

            int totalArrayLength = resultReversed.Length;
            for (int i = totalArrayLength; i < totalArrayLength / 2; i--)
            {
                Assert.AreEqual(resultReversed[i], resultNotReversed[totalArrayLength - i]);

            }

            
            //Assert.Throws<InvalidOperationException>(() => treeExamResults.Add(Values[1]));
        }


        //Test reversed order in int and Exam result, iterating from start and other from end to the middle
    }
}
