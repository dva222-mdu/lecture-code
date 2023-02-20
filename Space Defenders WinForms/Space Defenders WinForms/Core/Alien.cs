using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{
    internal class Alien : IAnimatable
    {
        double x, y, Speed;

        public int X => (int)x;
        public int Y => (int)y;

        GameEngine Engine;
        Random Random = new Random();

        public Alien(GameEngine engine)
        {
            Engine = engine;
            y = Random.Next(Engine.Height) * 0.8;
            var startPost = Random.Next(0, 2);

            Speed = Random.Next(5, 15);
            if (startPost == 0)
            {
                // left
                x = 0;
            }
            else
            {
                // right
                x = Engine.Width - 1;
                Speed = -Speed;
            }
        }

        public void Tick()
        {
            x += Speed / 10;
            if (x < 0 || x >= Engine.Width - 1)
            {
                Engine.Remove(this);
                return;
            }

            if (Random.Next(10) >= 9)
            {
                var bomb = new Bomb(x, y + 1, Engine);
                Engine.Add(bomb);
            }
        }

        public void Draw(IRenderer renderer)
        {
            renderer.Draw(X, Y, Entity.Alien);
        }

        public void Hit(int damage)
        {
            Engine.Remove(this);
            Engine.AddScore(1);
        }
    }
}
