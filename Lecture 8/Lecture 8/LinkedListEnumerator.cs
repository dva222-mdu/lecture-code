using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Lecture_8
{
    internal class LinkedListEnumerator : IEnumerator
    {
        public object Current => current.Data;
        LinkedListNode? first;
        LinkedListNode? current;


        public LinkedListEnumerator(LinkedListNode? first)
        {
            // ...
            this.first = new LinkedListNode { Next = first };
            Reset();
        }

        public bool MoveNext()
        {
            if (current == null) return false;
            current = current.Next;
            return current != null;
        }

        public void Reset()
        {
            current = first;
        }
    }
}
