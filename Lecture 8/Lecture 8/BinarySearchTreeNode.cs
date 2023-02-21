using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8
{
    internal class BinarySearchTreeNode
    {
        public IComparable Data { get; internal set; }

        public BinarySearchTreeNode Left { get; internal set; }
        public BinarySearchTreeNode Right { get; internal set; }

        public void Add(IComparable item)
        {
            if (Data.CompareTo(item) > 0)
            {
                if (Left != null) { Left.Add(item); }
                else { Left = new BinarySearchTreeNode { Data = item }; }
            }
            else
            {
                if (Right != null) { Right.Add(item); }
                else { Right = new BinarySearchTreeNode { Data = item }; }
            }
        }

        public IComparable? Find(IComparable item)
        {
            var result = Data.CompareTo(item);
            if (result == 0) { return Data; }

            if (result > 0)
            {
                if (Left != null) { return Left.Find(item); }
            }
            else
            {
                if (Right != null) { return Right.Find(item); }
            }

            return null;
        }

    }

}
