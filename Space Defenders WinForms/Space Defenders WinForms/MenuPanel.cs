using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Defenders_WinForms
{
    internal class MenuPanel : Panel
    {
        public Button StartButton;
        public Button QuitButton;
        public MenuPanel()
        {
            Width = 100;
            Height = 100;
            BackColor = Color.White;

            StartButton = new Button();
            StartButton.Text = "Start";
            StartButton.Location = new Point(12, 25);
            QuitButton = new Button();
            QuitButton.Text = "Quit";
            QuitButton.Location = new Point(12, 50);

            // AutoSize = true;

            Controls.Add(StartButton);
            Controls.Add(QuitButton);
        }

        public void Hide()
        {
            Visible = false;
            StartButton.Enabled = false;
            QuitButton.Enabled = false; 
        }

        public void Unhide()
        {
            Visible = true;
            StartButton.Enabled = true;
            QuitButton.Enabled = true;
        }

    }
}
