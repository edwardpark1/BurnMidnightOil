using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using BurnMidnightOil;
using System.Drawing;

namespace BurnMidnightOil
{
    public class MouseMoveSession : Session
    {
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int XCoord, int YCoord);

        public MouseMoveSession(Action<string> logSetter, Time moveDelayTime) 
            : base(logSetter, moveDelayTime, null)
        {
        }

        public void InvokeSession(ControlDimension ctrlDimension)
        {
            MoveMouseCursor(ctrlDimension.Origin.X, ctrlDimension.Origin.Y, ctrlDimension.Width, ctrlDimension.Height);
        }

        private void MoveMouseCursor(int x, int y, int width, int height)
        {
            int newWidth = rand.Next(x, x + width + 1);
            int newHeight = rand.Next(y, y + height + 1);

            SetCursorPos(newWidth, newHeight);
        }
    }
}
