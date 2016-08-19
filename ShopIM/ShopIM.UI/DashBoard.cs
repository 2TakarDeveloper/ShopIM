using System;
using MetroFramework;
using ShopIM.Data;

namespace ShopIM.UI
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        readonly ProductRepo _productRepo = new ProductRepo();
        readonly InventoryRepo _inventoryRepo=new InventoryRepo();
        private readonly Login _loginForm;
        public DashBoard(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm ;
            
            ProductGrid.DataSource = _productRepo.GetProducts();
            ProductGrid.Columns[4].Visible = false;



            InventoryGrid.DataSource = _inventoryRepo.GetInventories();
            InventoryGrid.Columns[2].Visible = false;



        }

        protected override void OnClosed(EventArgs e)
        {
            _loginForm.Dispose();
        }
    }
}
