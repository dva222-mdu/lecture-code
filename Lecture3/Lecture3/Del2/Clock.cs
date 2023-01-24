using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lecture3.Del2
{
    class Clock
    {

        int Seconds;
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
            var seconds = Seconds;
            var hour = seconds / 3600;
            seconds -= hour * 3600;
            var minute = seconds / 60;
            seconds -= minute * 60;
            var second = seconds;
            Display.Show(hour, minute, second);
        }

        public void Tick()
        {
            Seconds++;
            if (Seconds >= 24 * 60 * 60)
            {
                Seconds = 0;
            }
        }

        public void Set(int hour, int minute, int second)
        {
            Seconds = second;
            Seconds += 60 * minute;
            Seconds += 60 * 60 * hour;
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
