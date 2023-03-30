using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    internal class LinkedListNode<T>
    {
        public LinkedListNode<T>? Next { get; internal set; }
        public T? Data { get; internal set; }
    }
}
