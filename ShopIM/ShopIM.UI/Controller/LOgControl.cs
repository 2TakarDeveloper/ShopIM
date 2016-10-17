using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using ShopIM.BLL;

namespace ShopIM.UI.Controller
{
    public partial class LogControl : UserControl
    {
        public LogControl()
        {
            InitializeComponent();
            UserLogGrid.DataSource=new LogRepo().GetUserLog();
            SalesLogGrid.DataSource=new LogRepo().GetSalesLog();
        }

        private void UserLogClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you Sure?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;
            new LogRepo().ClearUserLog();
            UserLogGrid.DataSource = null;
            UserLogGrid.DataSource = new LogRepo().GetUserLog();
        }

        private void SalesLogClear_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you Sure?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;
            new LogRepo().ClearSalesLog();
            SalesLogGrid.DataSource = null;
            SalesLogGrid.DataSource = new LogRepo().GetSalesLog();
        }
    }
}
