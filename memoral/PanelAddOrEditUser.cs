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
    public partial class PanelAddOrEditUser : UserControl
    {
        List<DataLayer.Users> users = new List<DataLayer.Users>();
        public enum WhoIs                       //whos login,admin?manager?seller?
        {
            ImAdmin = 0, ImManager = 1, ImSeller = 2
        }
        public enum WhichPage                   //what do you want to do? edit seller or manager?
        {
            sellerTools, managerTools
        }
        public WhoIs whoIs = WhoIs.ImManager;
        public WhichPage whichPage = WhichPage.managerTools;
        public PanelAddOrEditUser()
        {
            InitializeComponent();
        }
        public bool isAdmin = false;
        private void btnAddUser_Click(object sender, EventArgs e)                   //addseller tools
        {
            Login.H.Controls.Add(Panels.PanelUserTools());
            Panels.PanelUserTools().status = PanelUserTools.Status.add;
            Panels.PanelUserTools().picImage.BackgroundImage = memoral.Properties.Resources.user_male1;
            Panels.PanelUserTools().txtName.Text = "";
            Panels.PanelUserTools().txtPass.Text = "";
            Panels.PanelUserTools().txtUserName.Text = "";
            Panels.PanelUserTools().btnSubmit.Text = "افزودن";
            Panels.PanelUserTools().lblPass.Text = "رمز عبور";
            Panels.PanelUserTools().Location = new Point(50, 50);
            Panels.PanelUserTools().BringToFront();
        }
        private void btnEditeUser_Click(object sender, EventArgs e)                     //edite seller tools
        {
            Login.H.Controls.Add(Panels.PanelUserTools());
            Panels.PanelUserTools().status = PanelUserTools.Status.edit;
            Binding.BindingEditUsers(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString().ToEnglishInt()));
            Panels.PanelUserTools().id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString().ToEnglishInt());
            Panels.PanelUserTools().btnSubmit.Text = "ویرایش";
            Panels.PanelUserTools().lblPass.Text = "رمز عبور\n (توجه: فقط اگر میخواهید رمز را تغیر دهید چیزی در کادر زیر بنویسید.در غیر اینصورت کادر را خالی رها کنید)";
            Panels.PanelUserTools().Location = new Point(50, 50);
            Panels.PanelUserTools().BringToFront();
        }
        public void ReloadDgv()                         //reload datagridview
        {
            dgvUsers.Rows.Clear();
            using (DataBaseClass db = new DataBaseClass())
            {
                if (whoIs == WhoIs.ImAdmin && whichPage == WhichPage.managerTools)
                {
                    users = db.userRepository.GetAllManager();
                }
                else
                {
                    users = db.userRepository.GetAllSeller();
                }
            }
            foreach (DataLayer.Users item in users)
            {
                dgvUsers.Rows.Add(item.Id,
                                  item.name.ToPersianInt(),
                                  item.username.ToPersianInt(),
                                  item.degree == 1 ? "مدیر" : "فروشنده");
            }
        }
        private void btnRefreshUser_Click(object sender, EventArgs e)                   //refresh
        {
            ReloadDgv();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)                    //dellet an user
        {
            if (RtlMessageBox.Show("آیا از حذف این کاربر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataBaseClass db = new DataBaseClass())
                {
                    DataLayer.Users user = db.userRepository.GetUserbyId(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
                    db.userRepository.DeleteUser(user);
                    db.userRepository.Save();
                    RtlMessageBox.Show("کاربر موردنظر شما با موفقیت حذف شد.");
                }
            }
        }
    }
}
