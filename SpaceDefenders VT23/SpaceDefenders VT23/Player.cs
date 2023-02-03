using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{

    enum Direction { Left, Right }
    internal class Player
    {
        double x, y;
        public int X => (int)x;
        public int Y => (int)y;

        GameEngine Engine;

        public Player(GameEngine engine)
        {
            Engine = engine;
            x = Engine.Width / 2;
            y = Engine.Height - 1;
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.Left && x >= 1) x--;
            if (direction == Direction.Right && x <= Engine.Width - 2) x++;
        }

        public void Draw(IRenderer renderer)
        {
            renderer.Draw(X, Y, Entity.Player);
        }

        public void Fire()
        {
            var shot = new Shot(x, y - 1, Engine);
            Engine.Add(shot);
        }
        public void Hit(int damage)
        {
            Engine.SetGameOver();
        }
    }
}
