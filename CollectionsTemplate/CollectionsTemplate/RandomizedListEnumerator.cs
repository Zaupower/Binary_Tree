using System;
using System.Collections.Generic;

namespace CollectionsTemplate
{
    public class RandomizedListEnumerator<T> : IEnumerator<T>
    {
        private List<Element<T>> _source = new List<Element<T>>();

        public RandomizedListEnumerator(IEnumerable<T> source)
        {
            foreach(var item in source)
            {
                _source.Add(new Element<T> { Value = item });
            }
        }

        private T _current;

        public object Current => _current;

        T IEnumerator<T>.Current => _current;

        public bool MoveNext()
        {
            List<int> unwatchedIndexes = new List<int> ();

            for(var index = 0; index < _source.Count; index++)
            {
                if (!_source[index].IsWatched)
                    unwatchedIndexes.Add(index);
            }

            if (unwatchedIndexes.Count == 0)
                return false;

            var random = new Random();

            var randomUnwatchedIndexPosition = random.Next(0, unwatchedIndexes.Count);
            var currentElementPosition = unwatchedIndexes[randomUnwatchedIndexPosition];

            _source[currentElementPosition].IsWatched = true;

            _current = _source[currentElementPosition].Value;

            return true;

        }

        public void Reset()
        {
            foreach(var item in _source)
            {
                item.IsWatched = false;
            }
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

