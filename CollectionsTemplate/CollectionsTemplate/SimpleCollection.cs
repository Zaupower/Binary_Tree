using System;
using System.Collections;

namespace CollectionsTemplate
{
    internal class SimpleCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for(var i=0;i< 20;i++)
            {
                yield return i;
            }

            yield break;
        }
    }
}
