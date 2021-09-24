using memoral.DataLayer;
using memoral.DataLayer.context;
using memoral.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace memoral
{
    public partial class HomeForm : Form
    {
        bool IsOpen = false;                            //set open or close sidbar
        bool Bool_Login = false;                        //set condition for logout from account
        public static Users LoginUser;                  //Login user
        public static  int MaxFactoreCount;             //last factore id that regestried
        public static List<Factore> sabad = new List<Factore>();                    //sabad kharid
        enum sidebarStatus { OpenIt, CloseIt };         //sidebar enume(is it close or open)
        public HomeForm()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;                    //transparent the background
            this.TransparencyKey = Color.LimeGreen;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            using (DataBaseClass db = new DataBaseClass())              
            {
                MaxFactoreCount = db.factoreRepository.GetMaxFactoreId();   //get last factore id that regestried        
            }
            PanelShowProducts panel_Products=Panels.PanelShowProducts();
            this.Controls.Add(panel_Products);                              //adding panel products to homeform
            panel_Products.Location = new Point(23, 32);
            lableUser.Text = LoginUser.name;                            //set name on lable name
            picProfile.BackgroundImage = LoginUser.image.ToImage();
            switch (LoginUser.degree) {                                 //check the access level
                case 1:                                                 //if manager login
                        btnAddManager.Visible = false;                  //hide add manager for manager(this field just change by admin)
                        picAddManager.Visible = false;
                    btnLogOut.Location = btnAddManager.Location;          //set the location of other buttons
                    picLogOut.Location = picAddManager.Location;
                    break;
                case 2:                                                  //if seller login
                    btnAddManager.Visible = false;                       //hide add manager & add seller for seller
                    picAddManager.Visible = false;
                    btnAddMember.Visible = false;
                    picAddMember.Visible = false;
                    btnLogOut.Location = btnAddMember.Location;            //set the location of other buttons
                    picLogOut.Location = picAddMember.Location;
                    break;
            }
            seasson(1);                                 //start season for current user
        }
        //set or remove season for users
        protected void seasson(int onOff)
        {
            LoginUser.isOnline = onOff;
            using (DataBaseClass db = new DataBaseClass())
            {
                db.userRepository.UpdateUser(LoginUser);
            }
            if(onOff == 0)
            {
                RemoveAllFromSabad();                           //remove all product from sabad when we logng out
            }
        }
        //drag the app by mouse
        private void home_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Login.ReleaseCapture();
                Login.SendMessage(Handle, Login.WM_NCLBUTTONDOWN, Login.HT_CAPTION, 0);
            }
        }
        //open-close sidbar
        private void btnSidBar_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            else
            {
                SideBareHandle(sidebarStatus.OpenIt);
            }
        }
        
        private void SideBareHandle(sidebarStatus status)
        {
            if (status == sidebarStatus.CloseIt&& IsOpen)                 //if sidebar is open , close it
            {
                int x = panelSideBar.Location.X;            //current sidebar location
                for (int i = 2; i < 200; i += i / 2)
                {
                    panelSideBar.Left = x + i;              //move the sidbar
                    Thread.Sleep(10);                       //do statment per time
                }
                IsOpen = false;                             //sidebar close;
            }
            else if (!IsOpen && status == sidebarStatus.OpenIt)
            {                                          // if sidbar close,open it
                panelSideBar.BringToFront();
                int x = panelSideBar.Location.X;            //current sidebar location
                for (int i = 2; i < 200; i += i / 2)
                {
                    panelSideBar.Left = x - i;              //move the sidbar
                    Thread.Sleep(10);                       //do statment per time
                }
                IsOpen = true;                              //sidebar open;
            }
        }


        //change the cursor when hover the pictureboxs
        private void picMouse_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).Cursor = Cursors.Hand;
        }
        //change the cursor when hover the buttons
        private void btnMouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Hand;
        }
        //button close(x) click event
        private void picClose_Click(object sender, EventArgs e)
        {
            panelExit.Visible = true;               //open message dialog
            panelExit.BringToFront();
        }
        //button minimize(-) click event
        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //event when closing the form
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            panelExit.Visible = true;           //open message dialog
            panelExit.BringToFront();
            seasson(0);                         //end current season
        }
        private void logOut_click(object sender, EventArgs e)
        {
            Bool_Login = true;                  //it means user wants logout from current account and login again in another account
            panelExit.Visible = true;           //open message dialog
            panelExit.BringToFront();
        }
        //button "خیر "in message dialog event
        private void btnNo_Click(object sender, EventArgs e)
        {
            panelExit.Visible = false;          //cansel the message dialog
            Bool_Login = false;
        }
        //button "بله "in message dialog event
        private void btnYes_Click(object sender, EventArgs e)
        {
            seasson(0);                          //end current season
            if (Bool_Login)                      //if true it means user want login again(we should go to login form(not exit the app))
            {
                Login L = new Login();
                L.Show();                        //show login form
                this.Visible=false;              //close home form
            }
            else
            {
                disposeAll();
                Application.Exit();              //close the app  
            }
        }
        private void RemoveAllFromSabad()
        {
            try { 
                Product product = new Product();
                using (DataBaseClass db = new DataBaseClass())
                {
                    foreach (Factore item in sabad)                                     //select each factore in sabad
                    {
                        product = db.ProductRepository.GetProductById(item.ProductId);  
                        product.Frequery += Convert.ToInt32(item.Frq_request);          //add Frequery of product
                        db.ProductRepository.UpdateProduct(product);                    //update product
                    }
                    db.ProductRepository.save();                                        //save the database
                    sabad.Clear();                                                      //clear the sabad
                }
            }
            catch
            {
                RtlMessageBox.Show("مشکلی هنگام حذف محصولات پیش آمد");
            }
        }
        void disposeAll()                                           //dispose All the panels
        {
            panel_guide.Visible = false;
            Login.H.Controls.Remove(Panels.PanelShowProducts());
            Login.H.Controls.Remove(Panels.PanelAddOrEdit());
            Login.H.Controls.Remove(Panels.PanelProductsDetails());
            Login.H.Controls.Remove(Panels.PanelFacores());
            Login.H.Controls.Remove(Panels.PanelRegisteredFactores());
            Login.H.Controls.Remove(Panels.PanelAddOrEditUser());
        }
        ///////btnHome event//////
        private void btnHome_Click(object sender, EventArgs e)
        {
            picHome_Click(sender, e);
        }
        public void picHome_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            PanelShowProducts panel_Products = Panels.PanelShowProducts();
            this.Controls.Add(panel_Products);
            panel_Products.Location = new Point(23, 32);
            using (DataBaseClass db = new DataBaseClass())
            {
                Panels.PanelShowProducts().ProductList = db.ProductRepository.GetAllProduct();
            }
            new ShowProducts(Panels.PanelShowProducts().ProductList,
                             Panels.PanelShowProducts().panel_showProducts);            //show all product
        }
        ///////btnHome event//////

        ///////btnAddProduct event//////
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            picAddProduct_Click(sender, e);
        }
        private void picAddProduct_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            addProduct addProduct = Panels.PanelAddOrEdit();
            addProduct.inputDetails.Text = "";
            addProduct.inputNewProductFrequery.Text = "";
            addProduct.inputNewProductName.Text = "";
            addProduct.inputNewProductPrice.Text = "";
            addProduct.pic_product.BackgroundImage = memoral.Properties.Resources.succulent_in_flower_pot_icon_isolated_vector_14370395;
            addProduct.btnSave.Text = "افزودن محصول";
            addProduct.btnSave.TextAlign = ContentAlignment.MiddleCenter;
            addProduct.btnRemoveProduct.Visible = false;
            this.Controls.Add(addProduct);
            addProduct.Location = new Point(23, 32);
        }
        ///////btnAddProduct event//////

        ///////btnAddRecipt event//////
        private void btnAddRecipt_Click(object sender, EventArgs e)
        {
            picAddRecipt_Click(sender, e);
        }
        private void picAddRecipt_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            PanelFactors panel_Factores = Panels.PanelFacores();
            this.Controls.Add(panel_Factores);
            panel_Factores.Location = new Point(23, 32);
            panel_Factores.ReloadSabadDGV();
        }
        ///////btnAddRecipt event//////

        ///////btnRecipt event//////
        private void btnRecipt_Click(object sender, EventArgs e)
        {
            picRecipt_Click(sender, e);
        }
        private void picRecipt_Click(object sender, EventArgs e)
        {

            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            PanelRegisteredFactores panelregisteredfactores = Panels.PanelRegisteredFactores();
            this.Controls.Add(panelregisteredfactores);
            panelregisteredfactores.Location = new Point(23, 32);
        }
        ///////btnAddRecipt event//////
        ///////btnAddMember event//////
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            picAddMember_Click(sender, e);
        }
        private void picAddMember_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            PanelAddOrEditUser panelAddOrEditUser = Panels.PanelAddOrEditUser();
            this.Controls.Add(panelAddOrEditUser);
            panelAddOrEditUser.Location = new Point(23, 32);
            panelAddOrEditUser.whichPage = PanelAddOrEditUser.WhichPage.sellerTools;
            if (LoginUser.degree == 0)
            {
                panelAddOrEditUser.whoIs = PanelAddOrEditUser.WhoIs.ImAdmin;
            }
            else
            {
                panelAddOrEditUser.whoIs = PanelAddOrEditUser.WhoIs.ImManager;
            }
            panelAddOrEditUser.btnAddUser.Text = "افزودن فروشنده";
            panelAddOrEditUser.btnDeleteUser.Text = "حذف فروشنده";
            panelAddOrEditUser.ReloadDgv();
        }
        ///////btnAddMember event//////

        ///////btnAddManager event//////
        private void btnAddManager_Click(object sender, EventArgs e)
        {
            picAddManager_Click(sender, e);
        }
        private void picAddManager_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SideBareHandle(sidebarStatus.CloseIt);
            }
            disposeAll();
            PanelAddOrEditUser panelAddOrEditUser = Panels.PanelAddOrEditUser();
            this.Controls.Add(panelAddOrEditUser);
            panelAddOrEditUser.Location = new Point(23, 32);
            panelAddOrEditUser.whichPage = PanelAddOrEditUser.WhichPage.managerTools;
            panelAddOrEditUser.whoIs = PanelAddOrEditUser.WhoIs.ImAdmin;
            panelAddOrEditUser.btnAddUser.Text = "افزودن مدیر";
            panelAddOrEditUser.btnDeleteUser.Text = "حذف مدیر";
            panelAddOrEditUser.ReloadDgv();
        }
        ///////btnAddManager event//////

        ///////btnEditProfile event//////
        private void picEditProfile_Click(object sender, EventArgs e)
        {
            Login.H.Controls.Add(Panels.PanelUserTools());
            Panels.PanelUserTools().status = PanelUserTools.Status.edit;
            Binding.BindingEditUsers(LoginUser.Id);
            Panels.PanelUserTools().id = LoginUser.Id;
            Panels.PanelUserTools().btnSubmit.Text = "ویرایش";
            Panels.PanelUserTools().lblPass.Text = "رمز عبور\n (توجه: فقط اگر میخواهید رمز را تغیر دهید چیزی در کادر زیر بنویسید.در غیر اینصورت کادر را خالی رها کنید)";
            Panels.PanelUserTools().Location = new Point(50, 50);
            Panels.PanelUserTools().BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_guide.Visible = true;
        }
        ///////btnEditProfile event//////
    }
}
