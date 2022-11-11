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
        private T[] Values;
        private int pointer = 0;

        public void addValue(T value)
        {
            Values[pointer++] = value;  
        }

        public void setValuesSize()
        {
            Values = new T[NodeCounter];
            pointer = 0;
        }

        public T[] GetValues()
        {
           return this.Values;
        }

    }
}
