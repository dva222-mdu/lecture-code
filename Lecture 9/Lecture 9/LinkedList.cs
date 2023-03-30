using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    internal class LinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T>? First { get; protected set; }
        public LinkedListNode<T>? Last { get; protected set; }

        public T? this[int index]
        {
            get { return Find(index).Data; }
            set { Find(index).Data = value; }
        }

        public int Count { get; protected set; }

        public bool IsSynchronized => false;
        public object SyncRoot => this;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item) => AddLast(item);

        public void AddFirst(T item) {
            var node = new LinkedListNode<T>() { Next = First, Data = item };
            First = node;
            if (Last == null) { Last = node; }
            Count++;
        }

        public void AddLast(T item)
        {
            var node = new LinkedListNode<T>() { Data = item };
            if (Last != null) { Last.Next = node; }
            Last = node;
            if (First == null) { First = node; }
            Count++;
        }

        public LinkedListNode<T> Find(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var current = First;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LinkedListEnumerator<T>(First);
        }

        public void Clear()
        {
            Count = 0;
            First = null;
            Last = null;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(First);
        }
    }
}
