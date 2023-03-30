using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class GameForm : Form
    {

        public GameForm()
        {
            AutoSize = true;
            Text = "Game!";
            DoubleBuffered = true;
            var flpanel = new FlowLayoutPanel();
            flpanel.AutoSize = true;
            flpanel.FlowDirection = FlowDirection.TopDown;

            Controls.Add(flpanel);

            var gamePanel = new GamePanel();
            flpanel.Controls.Add(gamePanel);
            var scorePanel = new ScorePanel();
            flpanel.Controls.Add(scorePanel);

            scorePanel.Click += ScorePanel_Click;

            var timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 16;
            timer.Enabled= true;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Refresh();
        }

        private void ScorePanel_Click(object? sender, EventArgs e)
        {
            var panel = (ScorePanel)sender;
            panel.BackColor = Color.White;
        }
    }
}
