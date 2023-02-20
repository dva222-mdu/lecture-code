using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefenders_VT23
{
    internal class GameEngine
    {
        public int Score { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public bool GameOver { get; private set; } = false;

        Random Random = new Random();

        IRenderer Renderer;

        Player Player;

        List<Alien> Aliens = new List<Alien>();
        List<Bomb> Bombs = new List<Bomb>();
        List<Shot> Shots = new List<Shot>();
        public GameEngine(int widht, int height, IRenderer renderer) {
            Width = widht;
            Height = height;
            Renderer = renderer;
            Renderer.SetDimension(Width, Height);

            Player = new Player(this);
        }

        public void Move(Direction direction) => Player.Move(direction);
        public void Fire() => Player.Fire();

        public void Add(Bomb bomb)
        {
            Bombs.Add(bomb);
        }

        public void Add(Shot shot) => Shots.Add(shot);

        public void Remove(Alien alien)
        {
            Aliens.Remove(alien);
        }

        public void AddScore(int score) => Score += score;

        public void Remove(Bomb bomb)
        {
            Bombs.Remove(bomb); 
        }

        public void Remove(Shot shot) => Shots.Remove(shot);
        public void Tick()
        {
            var animatables = new List<IAnimatable>();
            animatables.AddRange(Aliens);
            animatables.AddRange(Bombs);
            animatables.AddRange(Shots);

            foreach (var item in animatables) { item.Tick(); }

            if (Random.Next(10) >= 7)
            {
                Aliens.Add(new Alien(this));
            }

            var bombs = new List<Bomb>();
            bombs.AddRange(Bombs);

            foreach (var bomb in bombs)
            {
                bomb.TryHit(Player);
            }

            var shots = new List<Shot>();
            shots.AddRange(Shots);
            var aliens = new List<Alien>(); 
            aliens.AddRange(Aliens);
            foreach(var shot in shots)
            {
                foreach (var alien in aliens)
                {
                    shot.TryHit(alien);
                }
            }

        }
        public void Draw()
        {
            foreach (var item in Bombs) { item.Draw(Renderer); }
            foreach (var item in Shots) { item.Draw(Renderer); }
            foreach (var item in Aliens) { item.Draw(Renderer);  }
            Player.Draw(Renderer);
        }

        public void SetGameOver()
        {
            GameOver = true;
        }

    }
}
