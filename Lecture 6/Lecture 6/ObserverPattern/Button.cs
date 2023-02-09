using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6.ObserverPattern
{
    interface IClickListener
    {
        void Click(object sender, ClickEventData data);
    }

    interface IDoubleClickListener
    {
        void DoubleClick(object sender, ClickEventData data);
    }

    enum MouseButton { Left, Middle, Right };
    class ClickEventData
    {
        public int X, Y;
        public MouseButton Button;
    }

    internal class Button
    {

        List<IClickListener> ClickListeners = new List<IClickListener>();
        List<IDoubleClickListener> DoubleClickListeners = new List<IDoubleClickListener>();

        public string Label { get; set; }

        public void AddClickListener(IClickListener listener) => ClickListeners.Add(listener);
        public void RemoveClickListener(IClickListener listener) => ClickListeners.Remove(listener);

        public void AddDoubleClickListener(IDoubleClickListener listener) => DoubleClickListeners.Add(listener);
        public void RemoveDoubleClickListener(IDoubleClickListener listener) => DoubleClickListeners.Remove(listener);

        public void FireClick(ClickEventData data)
        {
            foreach (var listener in ClickListeners) { listener.Click(this, data); }
        }

        public void FireDoubleClick(ClickEventData data)
        {
            foreach (var listener in DoubleClickListeners) { listener.DoubleClick(this, data); }
        }

    }
}
