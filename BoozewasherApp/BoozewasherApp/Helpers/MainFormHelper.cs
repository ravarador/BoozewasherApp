using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Helpers
{
    public static class MainFormHelper
    {
        internal static void HoverBtn(this Button btn)
        {
            //btn.BackColor = Color.FromArgb(1, 162, 0, 37);
            btn.ForeColor = Color.White;
        }

        internal static void LeaveBtn(this Button btn)
        {
            //btn.BackColor = Color.WhiteSmoke;
            btn.ForeColor = Color.Black;
        }
    }
}
