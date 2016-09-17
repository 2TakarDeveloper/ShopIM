using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopIM.UI
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroLink13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
