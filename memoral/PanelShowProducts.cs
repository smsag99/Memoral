using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using memoral.DataLayer.context;
using memoral.Utility.Convertor;

namespace memoral
{
    public partial class PanelShowProducts : UserControl
    {
        public PanelShowProducts()
        {
            InitializeComponent();
        }
        public List<DataLayer.Product> ProductList;
        private void PanelShowProducts_Load(object sender, EventArgs e)         //panel o show
        {
            using (DataBaseClass db = new DataBaseClass() )
            {
                ProductList = db.ProductRepository.GetAllProduct();
            }
            new ShowProducts(ProductList, panel_showProducts);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)      //search betwin products
        {
            panel_showProducts.Controls.Clear();
            var list = (from name in ProductList
                       where name.Name.Contains(txtSearch.Text)
                       select name);
            new ShowProducts(list.ToList(), panel_showProducts);
        }
        private void btnRefresh_Click(object sender, EventArgs e)       //refresh the list
        {
            using (DataBaseClass db = new DataBaseClass())
            {
                ProductList = db.ProductRepository.GetAllProduct();
            }
            new ShowProducts(ProductList, panel_showProducts);
        }
    }
}
