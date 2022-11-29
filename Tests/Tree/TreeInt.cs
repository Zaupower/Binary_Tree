using BinaryTree.Iterable;
using BinaryTree.Tree;
using ExamResultApp;
using NUnit.Framework;

namespace Tests.Tree
{
    [TestFixture]
    public class TreeInt
    {

        private Tree<int> treeInt;
        private int[] Values;
        private int SizeValues = 7;
        [SetUp]
        public void SetUp()
        {

            treeInt = new Tree<int>();
            Values = new int[SizeValues];

            for (int i = 0; i < SizeValues; i++)
            {
                Values[i] = i+1;
            }
            for (int i = 0; i < Values.Length; i++)
            {
                treeInt.Add(Values[i]);
            }
        }
        [TearDown]
        public void Postcondition()
        {
            treeInt = new Tree<int>();
            Values = new int[] { };
        }

        [Test]
        public void Int_AddValue()
        {
            Assert.AreEqual(treeInt.getNodeCounter(), Values.Length);
        }

        [Test]
        public void Int_IsEquivalent()
        {
            int[] testArray = new int[Values.Length];

            for(int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = Values[i];
            }

            GenericEnumerableList<int> testList = new GenericEnumerableList<int>(testArray);
            GenericEnumerableList<int> listExpected = treeInt.Traverse();

            CollectionAssert.AreEquivalent(listExpected, testList);

        }

        [Test]
        public void Int_IsIterable()
        {

            int[] testArray = new int[Values.Length];
            int counter = 0;

            GenericEnumerableList<int> expected = treeInt.Traverse();

            foreach (int item in expected)
            {
                testArray[counter++] = item;
            }
            GenericEnumerableList<int> testList = new GenericEnumerableList<int>(testArray);
            CollectionAssert.AreEquivalent(expected, testList);
        }

        [Test]
        public void ExamResult_AddExistingValue_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => treeInt.Add(Values[1]));
        }
    }
}
