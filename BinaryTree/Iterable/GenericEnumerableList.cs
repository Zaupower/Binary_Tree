using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree.Iterable
{
    public class GenericEnumerableList<T> : IEnumerable<T>
    {
        private GenericListEnumerator<T> _enumerator;

        public GenericEnumerableList(IEnumerable<T> source)
        {
            _enumerator = new GenericListEnumerator<T>(source);
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
