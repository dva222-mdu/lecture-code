using SpaceDefenders_VT23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Defenders_WinForms
{
    internal class WinFormsRenderer : IRenderer
    {
        int Width;
        int Height;

        class ToDraw
        {
            public int X, Y;
            public Entity Entity;
        }

        List<ToDraw> ToDrawList = new List<ToDraw>();

        public void Clear()
        {
            ToDrawList.Clear();
        }

        public void Display()
        {
        ///    throw new NotImplementedException();
        }

        public void Draw(int x, int y, Entity entity)
        {
            ToDrawList.Add(new ToDraw{ X = x, Y = y, Entity = entity });
        }

        public void SetDimension(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Paint(Graphics g)
        {
            var hscale = 800 / Width;
            var vscale = 600 / Height;

            foreach (ToDraw toDraw in ToDrawList)
            {
                switch (toDraw.Entity)
                {
                    case Entity.Player:
                        g.DrawImage(Pictures.Player, toDraw.X * hscale, toDraw.Y * vscale, hscale, vscale);
                        break;

                    case Entity.Alien:
                        g.DrawImage(Pictures.Bomber, toDraw.X * hscale, toDraw.Y * vscale, hscale, vscale);
                        break;

                    case Entity.Bomb:
                        g.DrawImage(Pictures.AlienShot, toDraw.X * hscale, toDraw.Y * vscale, hscale, vscale);
                        break;

                    case Entity.Shot:
                        g.DrawImage(Pictures.Shot, toDraw.X * hscale, toDraw.Y * vscale, hscale, vscale);
                        break;

                    default:
                        g.DrawEllipse(new Pen(Color.White), toDraw.X * hscale, toDraw.Y * vscale, 50, 50);
                        break;
                }
            }
        }
    }
}
