
namespace BinaryTree
{
    public class Node<T> where T : IComparable
    {
        public T _data = default(T)!;
        public Node<T> Left;
        public Node<T> Right;

        public Node()
        {
        }
        public Node(T data)
        {
            this._data = data;
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
