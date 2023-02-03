using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lecture4
{
    internal class Vector
    {
        protected double X, Y;

        public Vector(double x, double y)
        {
            X = x; Y = y;
        }

        public double GetX() => X;
        public double GetY() => Y;

        public override string ToString()
        {
            return $"<{X},{Y}>";
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Vector)) return false;
            var other = obj as Vector;
            return X == other.X && Y == other.Y;
        }
    }

    class MutableVector : Vector
    { 
        public MutableVector(double x, double y) : base(x,y) { }

        public void SetX(double x) => X = x;
        public void SetY(double y) => Y = y;

        public void Add(Vector v)
        {
            X += v.GetX();
            Y += v.GetY();
        }
    }
}
