
namespace BinaryTree
{
    public class Node<T> where T : IComparable
    {
        public T _data;
        public Node<T> Left;
        public Node<T> Right;

        public Node()
        {
            this.Left = null;
            this.Right = null;
        }
        public Node(T data)
        {
            this._data = data;
            this.Left = null;
            this.Right = null;
        }

        public T GetData()
        {
            return this._data;
        }
        public void SetData(T data)
        {
             this._data = data;
        }
    }
}
