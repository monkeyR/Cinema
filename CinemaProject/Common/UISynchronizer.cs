using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class UISynchronizer
    {
        public static void synchronizeWithUI<TParam>(Control control, Action<TParam> action, TParam param)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action, param);
            }
            else
            {
                action(param);
            }
        }

        public static void synchronizeWithUI(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void enableButton(Button b, Boolean enable)
        {
            UISynchronizer.synchronizeWithUI(b, (boolean) => b.Enabled = boolean, enable);
        }

    }
}
