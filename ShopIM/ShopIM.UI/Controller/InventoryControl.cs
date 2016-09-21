using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopIM.UI.Controller
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            InveontroyForm inveontroyForm = new InveontroyForm();
            inveontroyForm.ShowDialog(this);
        }
    }
}
