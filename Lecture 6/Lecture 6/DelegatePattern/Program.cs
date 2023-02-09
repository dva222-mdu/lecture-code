// See https://aka.ms/new-console-template for more information

namespace Lecture_6.DelegatePattern
{

    static class TryDelegatePattern
    {
        public static void Run()
        {

            var startButton = new Button();
            startButton.Label = "Start";
            var stopButton = new Button();
            stopButton.Label = "Stop";

            var listener1 = new Listener1();
            var listener2 = new Listener2();

            /*
            startButton.Click += listener1.HandMenuButtons;
            stopButton.Click += listener1.HandMenuButtons;
            startButton.Click += listener2.Click;
            */

            // sker is OS/GUI
            var data = new ClickEventData();
            data.X = 0;
            data.Y = 0;
            data.Button = MouseButton.Right;
            startButton.FireClick(data);
            stopButton.FireClick(data);
        }
    }

    class Listener1
    {
        public void HandMenuButtons(Object sender, ClickEventData data)
        {
            var button = (Button)sender;
            Console.WriteLine($"Listener 1 notified {data.X} {data.Y} {data.Button} {button.Label}");
            switch (button.Label)
            {
                case "Start": // ...
                    break;
                case "Stop": // ...
                    break;
            }
        }
    }

    class Listener2
    {
        public void Click(Object sender, ClickEventData data)
        {
            if (data.Button == MouseButton.Left)
            {
                Console.WriteLine($"Listener 2 notified {data.X} {data.Y}");
            }
        }
    }
}