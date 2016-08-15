using System;
using MetroFramework.Forms;

namespace ShopIM.UI
{
    public partial class Home :MetroForm
    {
        private Login login;
        public Home(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            login.Dispose();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewProduct().Show();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
