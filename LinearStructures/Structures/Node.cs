using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearStructures.Structures
{
    class Node <T>
    {
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }
}
