namespace BinaryTree.Tree
{
    public class Node<T> where T : IComparable
    {
        public T _data = default!;
        public Node<T> Left;
        public Node<T> Right;

        public Node()
        {
        }
        public Node(T data)
        {
            _data = data;
        }

        public T GetData()
        {
            return _data;
        }
        public void SetData(T data)
        {
            _data = data;
        }
    }
}
