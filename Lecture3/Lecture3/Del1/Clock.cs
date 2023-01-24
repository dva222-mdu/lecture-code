
using System.Timers;

namespace Lecture3.Del1
{
    class Clock
    {

        int Hour, Minute, Second;
        System.Timers.Timer Timer;
        Display Display;

        public Clock(int hour, int minute, int second)
        {
            Set(hour, minute, second);
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += TimerTick;
            Timer.AutoReset = true;
            Display = new Display();
        }

        private void TimerTick(object? sender, ElapsedEventArgs e)
        {
            Tick();
            Display.Show(Hour, Minute, Second);
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

        public void Start()
        {
            Timer.Enabled = true;
        }

        public void Stop()
        {
            Timer.Enabled = false;

        }
    }
}
