using memoral.DataLayer.context;
using memoral.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoral
{
    public static class Binding
    {
        public static void BindingDetails(int id)
        {
            DataLayer.Product product;
            PanelProductsDetails productDetails = Panels.PanelProductsDetails();
            Login.H.Controls.Add(productDetails);
            using (DataBaseClass db = new DataBaseClass())
            {
                product = db.ProductRepository.GetProductById(id);
            }
            productDetails.label_productName.Text = product.Name.ToPersianInt();
            productDetails.label_frequery.Text = product.Frequery.ToString().ToPersianInt();
            productDetails.price.Text = product.price.ToString().ToPersianInt();
            productDetails.label_details.Text = product.details.ToPersianInt();
            productDetails.Pic_product.BackgroundImage = product.image.ToImage();
            productDetails.ProductId = product.ID;
            productDetails.frequery.Text = "";
            productDetails.Location = new Point(150, 100);
            productDetails.BringToFront();
        }
        
        public static void BindingEdit(int id)
        {
            DataLayer.Product product;
            addProduct addProduct = Panels.PanelAddOrEdit(id);
            Login.H.Controls.Add(addProduct);
            using (DataBaseClass db = new DataBaseClass())
            {
                product = db.ProductRepository.GetProductById(id);
            }
            addProduct.inputNewProductName.Text = product.Name.ToPersianInt();
            addProduct.inputNewProductFrequery.Text = product.Frequery.ToString().ToPersianInt();
            addProduct.inputNewProductPrice.Text = product.price.ToString().ToPersianInt();
            addProduct.inputDetails.Text = product.details.ToPersianInt();
            addProduct.pic_product.BackgroundImage = product.image.ToImage();
            addProduct.btnSave.TextAlign = ContentAlignment.MiddleRight;
            addProduct.btnSave.Text = "ویرایش محصول           ";
            addProduct.btnRemoveProduct.Visible = true;
            addProduct.productid = id;
            addProduct.Location = new Point(23, 32);
            addProduct.BringToFront();
            Login.H.panelSideBar.BringToFront();
        }


        public static void BindingEditUsers(int id)
        {
            DataLayer.Users user = new DataLayer.Users();
            using (DataBaseClass db = new DataBaseClass())
            {
                user = db.userRepository.GetUserbyId(id);
            }
            if(user.name!="")
                Panels.PanelUserTools().txtName.Text = user.name.ToPersianInt();
            Panels.PanelUserTools().txtUserName.Text = user.username.ToPersianInt();
            Panels.PanelUserTools().txtPass.Text = "";
            Panels.PanelUserTools().degree = user.degree;
            if (user.image != null)
                Panels.PanelUserTools().picImage.BackgroundImage = user.image.ToImage();
            else
                Panels.PanelUserTools().picImage.BackgroundImage = memoral.Properties.Resources.user_male1;
        }
        }
}
