using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Display
    {
        public void Show(int hour, int minute, int second)
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
