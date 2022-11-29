using BinaryTree.Iterable;
using BinaryTree.Tree;
using NUnit.Framework;

namespace Tests.Tree
{
    public class TreeIntReverse
    {

        private Tree<int> treeInt;
        private int[] Values;
        private int SizeValues = 7;
        private bool reversed = true;

        [SetUp]
        public void SetUp()
        {

            treeInt = new Tree<int>(reversed);
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
            treeInt = new Tree<int>(reversed);
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

            for (int i = 0; i < testArray.Length; i++)
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
        public void Int_AddExistingValue_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => treeInt.Add(Values[0]));
        }

        [Test]
        public void Int_IsReversed()
        {
            Tree<int> treeIntNotReversed = new Tree<int>();
            
            for (int i = 0; i < Values.Length; i++)
            {
                treeIntNotReversed.Add(Values[i]);
            }

            GenericEnumerableList<int> Reversed = treeInt.Traverse();
            GenericEnumerableList<int> NotReversed = treeIntNotReversed.Traverse();

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
        }
    }
}
