using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Defenders_WinForms
{
    public partial class GamePanel : Control
    {
        public GamePanel()
        {
            InitializeComponent();
            Width = 800;
            Height = 600;
            BackColor = Color.Navy;
            DoubleBuffered = true;
        }

    }
}
