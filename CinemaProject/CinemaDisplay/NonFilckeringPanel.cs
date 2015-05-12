using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDisplay
{
    class NonFilckeringPanel : Panel
    {
        public NonFilckeringPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);
        }
    }
}
