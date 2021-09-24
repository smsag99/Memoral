using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memoral.DataLayer.context;
using memoral.DataLayer;
using memoral.Utility.Convertor;

namespace memoral
{
    public partial class PanelFactors : UserControl
    {
        public PanelFactors()
        {
            InitializeComponent();
        }
        private Product product;
        private void btnRemove_Click(object sender, EventArgs e)            //remove a product from sabad
        {
            if (dgvSabad.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف کردن این محصول اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvSabad.CurrentRow.Cells[1].Value.ToString().ToEnglishInt());
                    int fr = Convert.ToInt32(dgvSabad.CurrentRow.Cells[3].Value.ToString().ToEnglishInt());
                    RemoveFromSabad(id, fr);
                    ReloadSabadDGV();
                } 
            }
            else
            {
                RtlMessageBox.Show(" ابتدا سطر مورد نظر خود را انتخاب کنید", "هیچ محصولی انتخاب نشده است");
            }
        }
        public void ReloadSabadDGV()                //reload datagridview
        {
            dgvSabad.DataSource = HomeForm.sabad.ToList();
            foreach( DataGridViewRow row in dgvSabad.Rows)
            {
                row.Cells[2].Value = row.Cells[2].Value.ToString().ToPersianInt();
                row.Cells[3].Value = row.Cells[3].Value.ToString().ToPersianInt();
            }
        }
        public void PanelFactors_Load(object sender, EventArgs e)               
        {
            dgvSabad.AutoGenerateColumns = false;
            ReloadSabadDGV();
        }
        private void btnClear_Click(object sender, EventArgs e)         //remove all product from sabad
        {
            if (HomeForm.sabad.Count!=0)
            {
                if (RtlMessageBox.Show("آیا از خالی کردن سبد خرید اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvSabad.Rows)
                    {
                        int id = Convert.ToInt32(row.Cells[1].Value.ToString());
                        int fr = Convert.ToInt32(row.Cells[3].Value.ToString());
                        RemoveFromSabad(id, fr);
                    }
                    ReloadSabadDGV();
                }
            }
            else
            {
                RtlMessageBox.Show("سبد شما خالی است", "توجه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void RemoveFromSabad(int id,int fr)             //method for removing from sabad
        {
            HomeForm.sabad.RemoveAll(p => p.ProductId == id);
            using (DataBaseClass db = new DataBaseClass())
            {
                product = db.ProductRepository.GetProductById(id);
                product.Frequery += fr;
                db.ProductRepository.UpdateProduct(product);
                db.ProductRepository.save();
            }
        }
        private void btnFinalize_Click(object sender, EventArgs e)              //finalize the sabad
        {
            if (HomeForm.sabad.Count!=0)
            {
                if (RtlMessageBox.Show("آیا از نهایی کردن سبد خرید اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Print.PrintDGV(dgvSabad, stiPrint);

                    using (DataBaseClass db = new DataBaseClass())
                    {
                        foreach (Factore factore in HomeForm.sabad)
                        {
                            db.factoreRepository.InsertFactore(factore);
                        }
                        db.factoreRepository.save();
                    }
                    HomeForm.sabad.Clear();
                    ReloadSabadDGV();
                    HomeForm.MaxFactoreCount++;
                }
            }
            else
            {
                RtlMessageBox.Show("سبد شما خالی است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}