using System;

namespace SpaceDefenders_VT23
{
    internal class ConsoleRenderer : IRenderer
    {
        char[] Field;
        int Width, Height;

        public void SetDimension(int width, int height)
        {
            Width = width;
            Height = height;
            Field = new char[(Width + 3) * (Height + 2)];
            Clear();
        }

        public void Clear()
        {
            // empty Field
            for (var i = 0; i < Field.Length; i++) Field[i] = ' ';
            // upper and lower horizontal frame
            for (var x = 0; x < Width + 3; x++)
            {
                Field[x] = '\u2550';
                Field[x + (Height + 1) * (Width + 3)] = '\u2550';
            }
            // left and right vertical frame and new line
            for (var y = 0; y < Height + 2; y++)
            {
                Field[0 + y * (Width + 3)] = '\u2551';
                Field[Width + 1 + y * (Width + 3)] = '\u2551';
                Field[Width + 2 + y * (Width + 3)] = '\n';
            }
            // corners
            Field[0] = '\u2554';
            Field[Width + 1] = '\u2557';
            Field[(Height + 1) * (Width + 3)] = '\u255A';
            Field[Width + 1 + (Height + 1) * (Width + 3)] = '\u255D';
        }

        public void Display()
        {
            Console.Write(Field);
        }

        int ToIndex(int x, int y) => (x + 1) + (y + 1) * (Width + 3);

        public void Draw(int x, int y, Entity entity)
        {
            var index = ToIndex(x, y);
            switch (entity)
            {
                case Entity.Player:
                    Field[index] = 'X';
                    break;
                case Entity.Alien:
                    Field[index] = 'Y';
                    break;
                case Entity.Bomb:
                    Field[index] = '.';
                    break;
                case Entity.Shot:
                    Field[index] = '|';
                    break;
            }
        }
    }
}
