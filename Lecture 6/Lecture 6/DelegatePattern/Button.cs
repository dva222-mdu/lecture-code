using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6.DelegatePattern
{
    delegate void ClickListener(object sender, ClickEventData data);
    delegate void DoubleClickListener(object sender, ClickEventData data);

    enum MouseButton { Left, Middle, Right };
    class ClickEventData
    {
        public int X, Y;
        public MouseButton Button;
    }

    internal class Button
    {

        public event ClickListener Click;
        public event DoubleClickListener DoubleClick;

        public string Label { get; set; }


        public void FireClick(ClickEventData data) { if (Click != null) Click(this, data); }

        public void FireDoubleClick(ClickEventData data) { if (DoubleClick != null) DoubleClick(this, data); }

    }
}
