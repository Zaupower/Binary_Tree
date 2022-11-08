using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsTemplate
{
    public class RandomizedList<T> : IEnumerable<T>
    {
        private RandomizedListEnumerator<T> _enumerator;

        public RandomizedList(IEnumerable<T> source)
        {
            _enumerator = new RandomizedListEnumerator<T>(source);
        }

        public IEnumerator GetEnumerator()
        {
            _enumerator.Reset();

            return _enumerator;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            _enumerator.Reset();

            return _enumerator;
        }
    }
}
