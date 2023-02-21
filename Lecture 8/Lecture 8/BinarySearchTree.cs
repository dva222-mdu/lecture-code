using System.Collections;


namespace Lecture_8
{
    internal class BinarySearchTree //: ICollection
    {

        BinarySearchTreeNode? Root;
        public int Count { get; protected set; }

        public void Add(IComparable item)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode() { Data = item };
            } else
            {
                Root.Add(item);
            }
        }

        public IComparable? Find(IComparable item)
        {
            return Root?.Find(item);
        }
    }
}
