using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memoral.Utility.Convertor;
using memoral.DataLayer.context;
using memoral.DataLayer;

namespace memoral
{
    public partial class PanelRegisteredFactores : UserControl
    {
        public PanelRegisteredFactores()
        {
            InitializeComponent();
        }
        DateTime from, to;          //date From to TO
        List<Factore> resault;
        private void JustDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.JustDecimal();
            e.ToPersianInt();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSsearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnSsearch_Click(object sender, EventArgs e)
        {
            filter();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (RtlMessageBox.Show("آیا از چاپ کردن این فاکتور اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Print.PrintDGV(dgvSabad, stiPrint, 1);
            }
        }
        private void PanelRegisteredFactores_Load(object sender, EventArgs e)
        {
            dgvSabad.AutoGenerateColumns = false;
            filter();
        }
        private void filter()           //filering the factores by date and factore id
        {
            dgvSabad.Rows.Clear();
            using (DataBaseClass db = new DataBaseClass())
            {

                if (txtFactoreIdSearch.Text == "")
                {
                    resault = db.factoreRepository.GetAllFactores();
                }
                else
                {
                    resault = db.factoreRepository.GetFactoresByFactoreId(Convert.ToInt32(txtFactoreIdSearch.Text.ToEnglishInt()));
                }
                try
                {
                    if (txtFromDate.Text != "    /  /")
                    {
                        from = Convert.ToDateTime(txtFromDate.Text.ToEnglishInt());
                        from = unit_convertor.ToMiladi(from);
                        resault = resault.Where(r => r.Date >= from).ToList();
                    }
                    if (txtToDate.Text != "    /  /")
                    {
                        
                            to = Convert.ToDateTime(txtToDate.Text.ToEnglishInt());
                            to = unit_convertor.ToMiladi(to);
                        if (from<=to)
                        {
                            resault = resault.Where(r => r.Date <= to).ToList();
                        }
                        else
                        {
                            resault = db.factoreRepository.GetAllFactores();
                            RtlMessageBox.Show("تاریخ درست وارد نشده است");
                        }
                    }
                }
                catch
                {
                    RtlMessageBox.Show("تاریخ به درستی وارد نشده", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);}
                foreach(Factore item in resault)
                {
                    dgvSabad.Rows.Add(item.FactoreId.ToString().ToPersianInt(),                 //adding each factore to datagridview
                                      item.ProductId, item.ProductName.ToPersianInt(),
                                      item.Frq_request.ToPersianInt(),
                                      item.Price.ToString().ToPersianInt(),
                                      item.Date.ToShamsi().ToPersianInt());
                    
                }
            }
        }
    }
}
