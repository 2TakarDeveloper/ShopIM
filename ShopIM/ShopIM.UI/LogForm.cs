using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class LogForm : MetroFramework.Forms.MetroForm
    {
        public LogForm()
        {
            InitializeComponent();
            logTable.DataSource = new LogContext().GetLogs();
            logTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            logTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            logTable.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            logTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            logTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SalesLogGrid.DataSource = new SalesLogContext().GetSalesLog();


        }

    }
}
