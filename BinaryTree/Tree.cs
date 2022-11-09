
using System.Data;

namespace BinaryTree
{
    public class Tree<T> where T:IComparable
    {
        private Node<T> _root;
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

            
            //else
            //{
            //    if(data.CompareTo(_root.Left) == 0 || data.CompareTo(_root.Right) == 0)
            //    {
            //        throw new Exception("Exception");
            //    }else if(data.CompareTo(_root.Left))
            //}
        }

        private void AddNode(Node<T> currentRoot, T data)
        {
            if(currentRoot._data.CompareTo(data) == 0)
            {
                throw new Exception("Equal Values not allowed");

            }
            else if (currentRoot._data == null)
            {
                currentRoot._data = data;

            }else if(data.CompareTo(currentRoot.Left._data) < 0)//Go left 
            {
                AddNode(currentRoot.Left, data);
            }
            else if (data.CompareTo(currentRoot.Left._data) < 0)//Go right
            {
                AddNode(currentRoot.Right, data);
            }
        }

        public void InOrder()
        {

        }

    }
}
