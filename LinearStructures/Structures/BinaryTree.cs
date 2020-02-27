using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearStructures.Structures
{
    class BinaryTree<T> : Interfaces.ILinearDataStructure<T>, IEnumerable<T> where T :IComparable
    {
        static Node<T> Root { get; set; }
        static int Count;
        public IEnumerator<T> GetEnumerator()
        {
            var current = Root;
            yield return current.Value;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Insert(T value)
        {

        }
    }
}
