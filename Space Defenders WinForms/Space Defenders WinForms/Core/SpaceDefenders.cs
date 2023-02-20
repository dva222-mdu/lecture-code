using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{
    internal class SpaceDefenders
    {

        IRenderer Renderer;
        GameEngine Engine;
        public SpaceDefenders() 
        { 
        
            Renderer = new ConsoleRenderer();
            Engine = new GameEngine(40, 20, Renderer);

        }

        public void Run()
        {
            var running = true;
            while (running && !Engine.GameOver)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            running = false;
                            break;
                        case ConsoleKey.LeftArrow:
                            Engine.Move(Direction.Left);
                            break;
                        case ConsoleKey.RightArrow:
                            Engine.Move(Direction.Right);
                            break;
                        case ConsoleKey.Spacebar:
                            Engine.Fire();
                            break;
                    }
                }

                Engine.Tick();

                Console.SetCursorPosition(0, 0);
                Renderer.Clear();
                Engine.Draw();
                Renderer.Display();

                Thread.Sleep(1000 / 10);
            }
}
    }
}
