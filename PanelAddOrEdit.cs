using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using memoral.DataLayer.context;
using memoral.Utility.Convertor;

namespace memoral
{
    public partial class addProduct : UserControl
    {

        public int productid;


        public addProduct()
        {

            InitializeComponent();
        }

        // only allow one decimal point
        private void textBox_PersianDesimal(object sender, KeyPressEventArgs e)
        {
            e.JustDecimal();
            e.ToPersianInt();

        }

        private void textBox2_Persian(object sender, KeyPressEventArgs e)
        {
            e.ToPersianInt();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void PanelAddOrEdit_Load(object sender, EventArgs e)
        {


        }
        private void btnSave_Click(object sender, EventArgs e)
        {




            using (DataBaseClass db = new DataBaseClass())
            {
                if (btnSave.Text.CompareTo("افزودن محصول") == 0)
                    try
                    {

                        DataLayer.Product p = new DataLayer.Product()
                        {
                            Name = inputNewProductName.Text.ToEnglishInt(),
                            Frequery = Convert.ToInt32(inputNewProductFrequery.Text.ToEnglishInt()),
                            price = Convert.ToInt32(inputNewProductPrice.Text.ToEnglishInt()),
                            details = inputDetails.Text.ToEnglishInt(),
                            image = ImageToByteArray(pic_product.BackgroundImage)
                        };

                        db.ProductRepository.InsertProduct(p);



                        RtlMessageBox.Show("محصول مورد نظر با موفقیت به لیست محصولات اضافه شد");


                    }
                    catch (Exception)
                    {
                        RtlMessageBox.Show("عملیات افزودن با خطا مواجه شد");

                    }
                else
                {
                    try
                    {




                        DataLayer.Product p = new DataLayer.Product();
                        p.ID = productid;
                        p.Name = inputNewProductName.Text.ToEnglishInt();
                        p.Frequery = Convert.ToInt32(inputNewProductFrequery.Text.ToEnglishInt());
                        p.price = Convert.ToInt32(inputNewProductPrice.Text.ToEnglishInt());
                        p.details = inputDetails.Text.ToEnglishInt();
                        p.image = ImageToByteArray(pic_product.BackgroundImage);
                        db.ProductRepository.UpdateProduct(p);
                        RtlMessageBox.Show("محصول مورد نظر با موفقیت ویرایش شد");
                    }
                    catch
                    {

                        RtlMessageBox.Show("عملیات ویرایش با خطا مواجه شد");
                    }
                }
                db.ProductRepository.save();
            }


            inputNewProductName.Text = "";
            inputNewProductFrequery.Text = "";
            inputNewProductPrice.Text = "";
            inputDetails.Text = "";
            pic_product.BackgroundImage = memoral.Properties.Resources.succulent_in_flower_pot_icon_isolated_vector_14370395;


        }

        private void btnChooseImage_click(object sender, EventArgs e)
        {

            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;
                this.pic_product.BackgroundImage = Image.FromFile(strFn);
            }
            catch
            {
                MessageBox.Show("wrong");
            }
        }

        private void btnRemove_click(object sender, EventArgs e)
        {
            pic_product.BackgroundImage = memoral.Properties.Resources.succulent_in_flower_pot_icon_isolated_vector_14370395;
        }

    }
}

