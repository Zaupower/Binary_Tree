using System;
using System.Collections.Generic;

namespace CollectionsTemplate
{
    public class RandomizedListEnumerator<T> : IEnumerator<T>
    {
        private List<Element<T>> _source = new List<Element<T>>();
        private int position = -1;
        public RandomizedListEnumerator(IEnumerable<T> source)
        {
            foreach(var item in source)
            {
                _source.Add(new Element<T> { Value = item });
            }
        }

        private T _current;

        public object Current => _source[position].Value;
        //{
        //    get
        //    {
        //        try
        //        {
        //            return _source[position];
        //        }
        //        catch (IndexOutOfRangeException)
        //        {
        //            throw new InvalidOperationException();
        //        }
        //    }
        //}

        T IEnumerator<T>.Current => _current;

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

    public class Node
    {
        public object Value;

        public Node LeftChild;

        public Node RightChild;
    }
}

