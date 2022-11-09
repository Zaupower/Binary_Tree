
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
            bool isDataNul = IsDefault(currentRoot._data);//Verify if class or struct is null without boxing on classes
            if (isDataNul)
            {
                currentRoot.SetData(data);   //.SetData(data)
                
                currentRoot.Left = new Node<T>();
                currentRoot.Right = new Node<T>();
            }
            else if(data.CompareTo(currentRoot.GetData()) == 0)
            {
                throw new Exception("Equal Values not allowed");
            }
            else if(data.CompareTo(currentRoot.GetData()) < 0)//Go left 
            {
                AddNode(currentRoot.Left, data);
            }
            else if (data.CompareTo(currentRoot.GetData()) > 0)//Go right
            {
                AddNode(currentRoot.Right, data);
            }
        }

        //Missing 
        public void InOrder()
        {

        }

        //Missing 
        public void PreOrder()
        {

        }

        private static readonly IEqualityComparer<T> comparer = EqualityComparer<T>.Default;
        public static bool IsDefault(T t)
        {
            return comparer.Equals(t, default(T));
        }
    }
}
