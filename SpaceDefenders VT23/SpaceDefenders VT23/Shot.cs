using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{
    internal class Shot : IAnimatable
    {
        double x, y, Speed;
        int X => (int)x;
        int Y => (int)y;

        GameEngine Engine;

        public Shot(double x, double y, GameEngine engine)
        {
            this.x = x;
            this.y = y;
            Engine = engine;
            Speed = 5;
        }

        public void Tick()
        {
            y -= Speed / 10;
            if (y <= 0)
            {
                Engine.Remove(this);
            }
        }

        public void TryHit(Alien alien)
        {
            if (X == alien.X && Y == alien.Y)
            {
                Engine.Remove(this);
                alien.Hit(1);
            }
        }

        public void Draw(IRenderer renderer)
        {
            renderer.Draw(X, Y, Entity.Shot);
        }
    }
}
