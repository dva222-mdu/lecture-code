using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lecture_7
{
    internal class GamePanel : Control
    {
        public GamePanel()
        {
            Width = 800;
            Height = 600;
            BackColor = Color.White;
            DoubleBuffered = true;

            Paint += GamePanel_Paint;
            Click += GamePanel_Click;
        }

        private void GamePanel_Click(object? sender, EventArgs e)
        {
            Refresh();
        }

        float XV = 3, YV = 2;
        float X, Y;

        private void GamePanel_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            // g.DrawEllipse(new Pen(Color.Black), X, Y, 50, 50);
            g.DrawImageUnscaled(Pictures.Planet, new Point((int) X,(int) Y));
            X += XV;
            Y += YV;
            if (X <= 0 || X >= Width) { XV = -XV;  }
            if (Y <= 0 || Y >= Height) { YV = -YV;  }

        }
    }
}
