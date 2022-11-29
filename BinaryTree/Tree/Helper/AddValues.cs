using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Tree.Helper
{
    public class AddValues<T>
    {
        public int NodeCounter { get; set; } = 0;
        private T[] _values;
        private int _pointer = 0;

        public void addValue(T value)
        {
            _values[_pointer++] = value;  
        }

        public void setValuesSize()
        {
            _values = new T[NodeCounter];
            _pointer = 0;
        }

        public T[] GetValues()
        {
           return this._values;
        }

    }
}
