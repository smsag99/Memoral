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
    public partial class PanelProductsDetails : UserControl
    {
        public PanelProductsDetails()
        {
            InitializeComponent();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Login.H.Controls.Remove(this);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow one decimal point
            e.JustDecimal();
            e.ToPersianInt();
        }
        private void btn_Buy_Click(object sender, EventArgs e)              //adding a product to sabad and saving changes in database
        {
            if (frequery.Text != "" && Convert.ToInt32(frequery.Text.ToEnglishInt()) != 0)
            {
                DataLayer.Product product;
                using (DataBaseClass db = new DataBaseClass())
                {
                    product = db.ProductRepository.GetProductById(this.ProductId);
                    if (Convert.ToInt32(frequery.Text.ToEnglishInt()) <= product.Frequery)
                    {
                        Factore factore = new Factore()
                        {
                            ProductId = this.ProductId,
                            Frq_request = (frequery.Text.ToEnglishInt()),
                            Date = DateTime.Now,
                            Price = product.price,
                            ProductName = product.Name,
                            FactoreId = HomeForm.MaxFactoreCount + 1
                            
                        };
                        product.Frequery -= Convert.ToInt32(frequery.Text.ToEnglishInt());
                        db.ProductRepository.UpdateProduct(product);
                        db.ProductRepository.save();
                        if (HomeForm.sabad.Any(s => s.ProductId == ProductId))
                        {
                            string fre = HomeForm.sabad.First(s => s.ProductId == ProductId).Frq_request;
                            HomeForm.sabad.First(s => s.ProductId == ProductId).Frq_request = Convert.ToInt32(fre.ToEnglishInt()) + Convert.ToInt32(frequery.Text.ToEnglishInt())+"";
                        }
                        else
                        {
                            HomeForm.sabad.Add(factore);
                        }
                        Login.H.Controls.Remove(this);
                    }
                    else
                    {
                        RtlMessageBox.Show("تعداد انتخاب شده از موجودی شما بیشتر است", "خطا");
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("تعداد محصول به درستی وارد نشده");
                frequery.Text = "";
            } 
            
        }
    }
}
