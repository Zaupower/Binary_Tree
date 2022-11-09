using System;
using System.Collections.Generic;

namespace BinaryTree.Iterable
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private List<Element<T>> _source = new List<Element<T>>();
        private int position = -1;
        T IEnumerator<T>.Current => _current;
        private T _current;

        public GenericListEnumerator(IEnumerable<T> source)
        {
            foreach(var item in source)
            {
                _source.Add(new Element<T> { Value = item });
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _source[position].Value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
}
            }
        }

        public bool MoveNext()
        {
            position++;
            bool hasNext = position < _source.Count;
            return (hasNext);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }
    }

    public class Element<T>
    {
        public T Value;

        public bool IsWatched;
    }
}

