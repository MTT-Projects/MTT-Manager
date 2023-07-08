using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTT_Manager
{
    public static class MSG
    {
        public static bool YesNoMessage(string message = "Defuaul Message", string title = "Default Title", MessageBoxIcon icon = MessageBoxIcon.None)
        {
            var confirmMessage = MessageBox.Show(message, title, MessageBoxButtons.YesNo, icon);
            if(confirmMessage == DialogResult.Yes)
            {
                return true;
            }
            else
            return false;
        }
    }
}
