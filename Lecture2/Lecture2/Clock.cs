
using System.Timers;

namespace Lecture2
{
    class Clock
    {

        int Hour, Minute, Second;

        public Clock(int hour, int minute, int second)
        {
            Set(hour, minute, second);
        }

        private void TimerTick(object? sender, ElapsedEventArgs e)
        {
            Tick();
        }

        public void Tick()
        {
            Second++;
            if (Second >= 60)
            {
                Second = 0;
                Minute++;
            }
            if (Minute >= 60)
            {
                Minute = 0;
                Hour++;
            }
            if (Hour >= 24)
            {
                Hour = 0;
            }
        }

        public void Set(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public string GetTime()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
    }
}
