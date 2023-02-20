using SpaceDefenders_VT23;
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
    public partial class GameForm : Form
    {

        GamePanel GamePanel;
        ScorePanel ScorePanel;
        System.Windows.Forms.Timer Timer;

        WinFormsRenderer Renderer;
        GameEngine Engine;

        Label GameOver;
        MenuPanel MenuPanel;
        public GameForm()
        {
            InitializeComponent();
            AutoSize = true;

            GameOver = new Label();
            GameOver.Text = "Game Over";
            GameOver.Font = new Font(GameOver.Font.FontFamily, 40);
            GameOver.BackColor = Color.Transparent;
            GameOver.ForeColor = Color.White;
            GameOver.AutoSize = true;
            GameOver.Location = new Point(265, 100);
            GameOver.Visible = false;
            Controls.Add(GameOver);

            MenuPanel = new MenuPanel();
            MenuPanel.Location = new Point((Width - MenuPanel.Width) / 2, 200);
            MenuPanel.Visible = true;
            Controls.Add(MenuPanel);

            MenuPanel.StartButton.Click += StartButton_Click;
            MenuPanel.QuitButton.Click += QuitButton_Click;

            var flpanel = new FlowLayoutPanel();
            flpanel.FlowDirection = FlowDirection.TopDown;
            flpanel.AutoSize = true;

            Controls.Add(flpanel); 
            
            GamePanel = new GamePanel();
            flpanel.Controls.Add(GamePanel);

            // ensure that the transparency works as intended
            GameOver.Parent = GamePanel;

            ScorePanel = new ScorePanel();
            flpanel.Controls.Add(ScorePanel);

            ScorePanel.Paint += ScorePanel_Paint;

            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000 / 10;
            Timer.Tick += Timer_Tick;
            Timer.Enabled = false;

            KeyDown += GameForm_KeyDown;
            KeyPreview = true;

            Renderer = new WinFormsRenderer();
            Engine = new GameEngine(40, 20, Renderer);

            GamePanel.Paint += GamePanel_Paint;

        }

        private void ScorePanel_Paint(object? sender, PaintEventArgs e)
        {
            ScorePanel.ScoreLabel.Text = $"Score: {Engine.Score}";
        }

        private void QuitButton_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
            MenuPanel.Hide();
            GameOver.Visible = false;
            Timer.Enabled = true;
            Engine = new GameEngine(40, 20, Renderer);
        }

        private void GamePanel_Paint(object? sender, PaintEventArgs e)
        {
            Renderer.Paint(e.Graphics);
        }

        private void GameForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    break;
                case Keys.A:
                    Engine.Move(Direction.Left);
                    break;
                case Keys.D:
                    Engine.Move(Direction.Right);
                    break;
                case Keys.Space:
                    Engine.Fire();
                    break; 
            }
        
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Engine.Tick();
            Renderer.Clear();
            Engine.Draw();
            GamePanel.Refresh();
            ScorePanel.Refresh();

            if (Engine.GameOver)
            {
                GameOver.Visible = true;
                MenuPanel.Unhide();
                Timer.Enabled = false;
            }

        }
    }
}
