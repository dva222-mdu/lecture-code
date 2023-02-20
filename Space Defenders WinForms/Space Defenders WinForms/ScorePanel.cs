using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Defenders_WinForms
{
    internal class ScorePanel : Panel
    {
        public Label ScoreLabel;
        public ScorePanel()
        {
            Width = 800;
            Height = 60;
            BackColor = Color.Blue;
            ScoreLabel = new Label();
            ScoreLabel.Font = new Font(ScoreLabel.Font.FontFamily, 16);
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Location = new Point(10, 14);
            ScoreLabel.AutoSize = true;
            ScoreLabel.Text = "Score: 0";
            Controls.Add(ScoreLabel);

        }
    }
}
