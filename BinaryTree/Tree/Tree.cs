
using BinaryTree.Iterable;
using BinaryTree.Tree.Helper;
using System.Data;

namespace BinaryTree.Tree
{
    public class Tree<T> where T : IComparable<T>
    {
        private Node<T> _root = new Node<T>();
        private bool _isReversedReading = false;
        private AddValues<T> AddValuesHelper = new AddValues<T>();

        public Tree() { }
        public Tree(bool isReversedReading)
        {
            _isReversedReading = isReversedReading;
        }

        public void Add(T data)
        {
            if (!IsDefault(data))
                AddNode(_root, data);
        }

        private void AddNode(Node<T> currentRoot, T data)
        {
            
            bool isDataNull = IsDefault(currentRoot._data);//Verify if class or struct is null without boxing on classes

            if (isDataNull)
            {
                currentRoot.SetData(data);
                AddValuesHelper.NodeCounter++;
            }
            else if (data.CompareTo(currentRoot.GetData()) == 0)//Verify equal values
            {
                throw new InvalidOperationException("Equal Values not allowed");
            }
            else if (data.CompareTo(currentRoot.GetData()) < 0)//Go left
            {
                if(currentRoot.Left == null)    //if left is null add Node
                    currentRoot.Left = new Node<T>();

                AddNode(currentRoot.Left, data);
            }
            else if (data.CompareTo(currentRoot.GetData()) > 0)//Go right
            {
                if(currentRoot.Right == null)   //if right is null add Node 
                    currentRoot.Right = new Node<T>();

                AddNode(currentRoot.Right, data);
            }
        }

        //Missing 
        public GenericEnumerableList<T> Traverse()
        {
            //Set Values to store all nodes
            AddValuesHelper.setValuesSize();

            switch (_isReversedReading)
            {
                case false:
                    VisitInOrder(_root);
                    break;
                case true:
                    VisitInOrderReverse(_root);
                    break;
            }
            GenericEnumerableList<T> valuesList = new GenericEnumerableList<T>(AddValuesHelper.GetValues());
            return valuesList;
        }

        private void VisitInOrder(Node<T> currentRoot)
        {
            if (currentRoot.Left != null)
                VisitInOrder(currentRoot.Left);           
            
            AddValuesHelper.addValue(currentRoot.GetData());

            if (currentRoot.Right != null)            
                VisitInOrder(currentRoot.Right);
        }

        //Missing 
        private void VisitInOrderReverse(Node<T> currentRoot)
        {
            if (currentRoot.Right != null)
                VisitInOrderReverse(currentRoot.Right);

            AddValuesHelper.addValue(currentRoot.GetData());

            if (currentRoot.Left != null)
                VisitInOrderReverse(currentRoot.Left);
        }

        public int getNodeCounter()
        {
            return AddValuesHelper.NodeCounter;
        }
        private static bool IsDefault(T t)
        {
            return EqualityComparer<T>.Default.Equals(t, default);
        }
    }
}
