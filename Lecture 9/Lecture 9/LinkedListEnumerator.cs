using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lecture_9
{
    internal class LinkedListEnumerator<T> : IEnumerator<T>
    {
        LinkedListNode<T>? first;
        LinkedListNode<T>? current;


        public LinkedListEnumerator(LinkedListNode<T>? first)
        {
            // ...
            this.first = new LinkedListNode<T> { Next = first };
            Reset();
        }

        public T Current => current.Data;

        object IEnumerator.Current => current.Data;

        public void Dispose()
        {
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
