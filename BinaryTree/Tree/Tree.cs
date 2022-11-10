
using System.Data;

namespace BinaryTree.Tree
{
    public class Tree<T> where T : IComparable
    {
        private Node<T> _root = new Node<T>();
        private bool _isReversedReading = false;

        public Tree() { }
        public Tree(bool isReversedReading)
        {
            _isReversedReading = isReversedReading;
        }

        public void Add(T data)
        {
            if (_root._data == null)
            {
                _root._data = data;
            }
            else
            {
                AddNode(_root, data);


            }
        }

        private void AddNode(Node<T> currentRoot, T data)
        {
            
            bool isDataNull = IsDefault(currentRoot._data);//Verify if class or struct is null without boxing on classes

            if (isDataNull)
            {
                currentRoot.SetData(data);

            }
            else if (data.CompareTo(currentRoot.GetData()) == 0)//Verify equal values
            {
                throw new Exception("Equal Values not allowed");
            }
            else if (data.CompareTo(currentRoot.GetData()) < 0)//Go left, if left is null add Node 
            {
                if (currentRoot.Left == null)
                    currentRoot.Left = new Node<T>();

                AddNode(currentRoot.Left, data);
            }
            else if (data.CompareTo(currentRoot.GetData()) > 0)//Go right, if right is null add Node 
            {
                if (currentRoot.Right == null)
                    currentRoot.Right = new Node<T>();

                AddNode(currentRoot.Right, data);
            }
        }

        //Missing 
        public void Traverse()
        {
            switch (_isReversedReading)
            {
                case false:
                    VisitInOrder(_root);
                    break;
                case true:
                    VisitPreOrder(_root);
                    break;
            }
        }

        private void VisitInOrder(Node<T> currentRoot)
        {
            if (currentRoot.Left != null)
            {
                VisitInOrder(currentRoot.Left);
            }
            
            Console.WriteLine(currentRoot.GetData());
            
            if (currentRoot.Right != null)
            {
                VisitInOrder(currentRoot.Right);
            }
        }

        //Missing 
        private void VisitPreOrder(Node<T> currentRoot)
        {

            if (currentRoot.Right != null)
            {
                VisitPreOrder(currentRoot.Right);
            }
            
            Console.WriteLine(currentRoot.GetData());

            if (currentRoot.Left != null)
            {
                VisitPreOrder(currentRoot.Left);
            }
        }

        private static bool IsDefault(T t)
        {
            return EqualityComparer<T>.Default.Equals(t, default);
        }
    }
}
