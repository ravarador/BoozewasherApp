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
        internal static string ShowHideDropDown(this Button btn, Panel panel1, Panel panel2, Panel panel3, Panel panel4)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            if (btn.Text == "Transactions")
            {
                if (panel1.Visible)
                {
                    panel1.Visible = false;
                    return "";
                }
                else
                {
                    panel1.Visible = true;
                }
                
            }
            if (btn.Text == "Vehicles")
            {
                if (panel2.Visible)
                {
                    panel2.Visible = false;
                    return "";
                }
                else
                {
                    panel2.Visible = true;
                }
            }
            if (btn.Text == "Services")
            {
                if (panel3.Visible)
                {
                    panel3.Visible = false;
                    return "";
                }
                else
                {
                    panel3.Visible = true;
                }
            }
            if (btn.Text == "View Today's Sales")
            {
                if (panel4.Visible)
                {
                    panel4.Visible = false;
                    return "";
                }
                else
                {
                    panel4.Visible = true;
                }
            }

            if (panel1.Visible)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }

            if (panel2.Visible)
            {
                panel1.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }

            if (panel3.Visible)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel4.Visible = false;
            }

            if (panel4.Visible)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }

            return "";
        }
    }
}
