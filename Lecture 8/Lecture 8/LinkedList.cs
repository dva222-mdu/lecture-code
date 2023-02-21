using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8
{
    internal class LinkedList : ICollection
    {
        public LinkedListNode? First { get; protected set; }
        public LinkedListNode? Last { get; protected set; }

        public object? this[int index]
        {
            get { return Find(index).Data; }
            set { Find(index).Data = value; }
        }

        public int Count { get; protected set; }

        public bool IsSynchronized => false;
        public object SyncRoot => this;

        public void Add(object item) => AddLast(item);

        public void AddFirst(object item) {
            var node = new LinkedListNode() { Next = First, Data = item };
            First = node;
            if (Last == null) { Last = node; }
            Count++;
        }

        public void AddLast(object item)
        {
            var node = new LinkedListNode() { Data = item };
            if (Last != null) { Last.Next = node; }
            Last = node;
            if (First == null) { First = node; }
            Count++;
        }

        public LinkedListNode Find(int index)
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

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(First);
        }
    }
}
