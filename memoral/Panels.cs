using memoral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoral
{
    public static class Panels
    {
        private static addProduct addproduct;
        private static PanelShowProducts panelproducts;
        private static PanelProductsDetails panelproductsdetails;
        private static PanelFactors panelfactores;
        private static PanelRegisteredFactores panelregisteredfactores;
        private static PanelAddOrEditUser paneladdoredituser;
        private static PanelUserTools panelusertools;
        public static addProduct PanelAddOrEdit(int id =0)
        {
            if (addproduct==null)
            {
                addproduct = new addProduct();
            }
            addproduct.productid = id;
            return addproduct;
        }

        public static PanelShowProducts PanelShowProducts()
        {
            if (panelproducts == null)
            {
                panelproducts = new PanelShowProducts();
            }
            return panelproducts;
        }

        public static PanelProductsDetails PanelProductsDetails()
        {
            if (panelproductsdetails == null)
            {
                panelproductsdetails = new PanelProductsDetails();
            }
            return panelproductsdetails;
        }
        public static PanelFactors PanelFacores()
        {
            if (panelfactores == null)
            {
                panelfactores = new PanelFactors();
            }
            return panelfactores;
        }

        public static PanelRegisteredFactores PanelRegisteredFactores()
        {
            if (panelregisteredfactores == null)
            {
                panelregisteredfactores = new PanelRegisteredFactores();
            }
            return panelregisteredfactores;
        }
        public static PanelAddOrEditUser PanelAddOrEditUser()
        {
            if (paneladdoredituser == null)
            {
                paneladdoredituser = new PanelAddOrEditUser();
            }
            return paneladdoredituser;
        }
        public static PanelUserTools PanelUserTools()
        {
            if (panelusertools == null)
            {
                panelusertools = new PanelUserTools();
            }
            return panelusertools;
        }
    }
}
