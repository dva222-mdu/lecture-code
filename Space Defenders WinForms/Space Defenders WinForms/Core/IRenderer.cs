using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{

    enum Entity { Alien, Player, Bomb, Shot }
    internal interface IRenderer
    {
        void SetDimension(int width, int height);
        void Clear();
        void Draw(int x, int y, Entity entity);

        void Display();
    }
}
