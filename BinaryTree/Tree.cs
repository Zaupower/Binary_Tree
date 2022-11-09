
using System.Data;

namespace BinaryTree
{
    public class Tree<T> where T:IComparable
    {
        private Node<T> _root = new Node<T>();
        private bool _isReversedReading = false;

        public Tree(){}
        public Tree(bool isReversedReading) 
        {
            _isReversedReading = isReversedReading;
        }

        public void Add(T data)
        {
            if (_root._data == null)
            {
                _root._data = data;
            }else
            {
                AddNode(_root, data);


            }
        }

        private void AddNode(Node<T> currentRoot, T data)
        {
            if (currentRoot == null)
            {
                currentRoot = new Node<T>(data);  //.SetData(data);

            }else if(currentRoot.GetData().CompareTo(data) == 0)
            {
                throw new Exception("Equal Values not allowed");
            }
            else if(data.CompareTo(currentRoot._data) < 0)//Go left 
            {
                AddNode(currentRoot.Left, data);
            }
            else if (data.CompareTo(currentRoot._data) > 0)//Go right
            {
                AddNode(currentRoot.Right, data);
            }
        }

        public void InOrder()
        {

        }

    }
}
