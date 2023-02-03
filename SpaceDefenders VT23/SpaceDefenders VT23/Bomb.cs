using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{
    internal class Bomb : IAnimatable
    {
        double x, y, Speed;
        int X => (int)x;
        int Y => (int)y;

        GameEngine Engine;
    
        public Bomb(double x, double y, GameEngine engine) 
        {
            this.x = x;
            this.y = y;
            Engine = engine;
            Speed = 5;
        }

        public void Tick()
        {
            y += Speed / 10;
            if (y >= Engine.Height)
            {
                Engine.Remove(this);
            }
        }

        public void TryHit(Player player)
        {
            if (X == player.X && Y == player.Y)
            {
                Engine.Remove(this);
                player.Hit(1);
            }
        }

        public void Draw(IRenderer renderer)
        {
            renderer.Draw(X, Y, Entity.Bomb);
        }
    }
}
