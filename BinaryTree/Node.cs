
namespace BinaryTree
{
    public class Node<T> where T : IComparable
    {
        public T _data { get; set; }
        public Node<T> Left { get; set; } = new Node<T>();
        public Node<T> Right { get; set; } = new Node<T>();

        public Node(){ }
        public Node(T data)
        {
            this._data = data;
        }
    }
}
