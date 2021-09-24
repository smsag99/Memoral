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

namespace memoral
{
    public partial class PanelUserTools : UserControl
    {
        public int id;
        public int degree;
        public enum Status
        {
            add, edit
        }
        public Status status;
        public PanelUserTools()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.H.Controls.Remove(this);
        }
        private void btnSubmit_Click(object sender, EventArgs e)    //checkin who and which page
        {
            if (txtUserName.Text != "")
            {
                PanelAddOrEditUser panelAddOrEditUser = Panels.PanelAddOrEditUser();
                if (status == Status.add)
                {
                    if (txtPass.Text != "")
                    {
                        if (panelAddOrEditUser.whichPage == PanelAddOrEditUser.WhichPage.sellerTools)
                        {
                            degree = 2;
                        }
                        else if (panelAddOrEditUser.whichPage == PanelAddOrEditUser.WhichPage.managerTools)
                        {
                            degree = 1;
                        }
                        add();
                        RtlMessageBox.Show("کاربر با موفقیت افزوده شد.");
                        Login.H.Controls.Remove(this);
                    }
                    else
                    {
                        RtlMessageBox.Show(" رمز پر نشده است");
                    }
                }
                else if (status == Status.edit)
                {
                    update(id);
                    RtlMessageBox.Show("کاربر با موفقیت ویرایش شد.");
                    Login.H.Controls.Remove(this);
                }
            }
            else { RtlMessageBox.Show("نام کاربری وارد نشده است"); }
        }
        void update(int id)         //update user from database
        {
            using (DataBaseClass db = new DataBaseClass())
            {
                DataLayer.Users user = new DataLayer.Users();
                user = db.userRepository.GetUserbyId(id);
                user.image = unit_convertor.ImageToByteArray(picImage.BackgroundImage);
                user.name = txtName.Text.ToEnglishInt();
                user.degree = degree;
                user.username = txtUserName.Text.ToEnglishInt();
                if (txtPass.Text != "")
                {
                    user.password = hash.md5(txtPass.Text.ToEnglishInt());
                }
                db.userRepository.UpdateUser(user);
                db.userRepository.Save();
            }
        }
        void add()              //add user to database
        {
            DataLayer.Users user = new DataLayer.Users()
            {
                image = unit_convertor.ImageToByteArray(picImage.BackgroundImage),
                name = txtName.Text.ToEnglishInt(),
                isOnline = 0,
                degree = degree,
            username = txtUserName.Text.ToEnglishInt(),
            password = hash.md5(txtPass.Text.ToEnglishInt())
        };
            
            using (DataBaseClass db = new DataBaseClass())
            {
                db.userRepository.InsertUser(user);
                db.userRepository.Save();
            }
        }
        private void btnRemoveImage_Click(object sender, EventArgs e)           //remove image
        {
            picImage.BackgroundImage = memoral.Properties.Resources.user_male1;
        }
        private void btnAddImage_Click(object sender, EventArgs e)          //add image to user
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;
                this.picImage.BackgroundImage = Image.FromFile(strFn);
            }
            catch
            {
                MessageBox.Show("wrong");
            }
        }
        private void PersianKey(object sender, KeyPressEventArgs e)
        {
            e.ToPersianInt();
        }
    }
}
