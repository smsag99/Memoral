using memoral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panels
{
    public static class Panels
    {
        private static addProduct addproduct;
        private static Panel_Products panelproducts;
        private static panel_productsDetails panelproductsdetails;
        public static addProduct PanelAddOrEditProduct()
        {
            if (addproduct==null)
            {
                addproduct = new addProduct();
            }
            return addproduct;
        }

        public static Panel_Products PanelProducts()
        {
            if (panelproducts == null)
            {
                panelproducts = new Panel_Products();
            }
            return panelproducts;
        }

        public static panel_productsDetails PanelProductsDetails()
        {
            if (panelproductsdetails == null)
            {
                panelproductsdetails = new panel_productsDetails();
            }
            return panelproductsdetails;
        }



    }
}
