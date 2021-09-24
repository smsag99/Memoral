using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memoral;
using memoral.Utility.Convertor;



namespace memoral
{
    public partial class product : UserControl
    {
        public product()
        {
            InitializeComponent();
        }
        private void btn_details_Click(object sender, EventArgs e)          //show product details
        {
            Binding.BindingDetails(((product)((Button)sender).Parent).productId);
        }
        private void btn_details_MouseHover(object sender, EventArgs e)     
        {
            ((Button)sender).Cursor = Cursors.Hand;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Binding.BindingEdit(((product)((Button)sender).Parent).productId);      //send a product to edit
        }
    }
}
