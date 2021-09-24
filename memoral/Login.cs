using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using memoral.DataLayer;
using memoral.DataLayer.context;
using memoral.Utility.Convertor;

namespace memoral
{
    public partial class Login : Form
    {
        public static DataTable Dt;
        List<Users> loginUsers;
        Users loginUser;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static HomeForm H;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;                    //transparent the background
            this.TransparencyKey = Color.LimeGreen;
        }

        //drag the app by mouse
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //check user & pass
        private bool checkVerify()
        {
            try
            {
                using (DataBaseClass db = new DataBaseClass())
                {
                    loginUsers = db.userRepository.GetUserbyUsername(textUser.Text.ToEnglishInt());
                    foreach (Users item in loginUsers)
                    {
                        if (hash.md5(textPass.Text.ToEnglishInt()) == item.password)
                        {
                            loginUser = item;
                            return true;
                        }
                    }
                        {
                            lableWrong.Visible = true;    //enable "نام کاربری یا رمز عبور درست وارد نشده"
                            textPass.Text = "";            //null the password textbox
                            return false;
                        }
                }
            }
            catch
            {
                lableWrong.Visible = true;          //enable "نام کاربری یا رمز عبور درست وارد نشده"
                textPass.Text = "";                  //null the password textbox
                return false;
            }
        }
        //button close(x) click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //button minimize(-) click event
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //change the cursor when hover the buttons
        private void btnHand_MouseHover(object sender, EventArgs e)
        {
           
            ((Button)sender).Cursor = Cursors.Hand;
        }
        //convert english numberic to persian
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.ToPersianInt();
        }
        //show password contents
        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            textPass.PasswordChar = '\0';
        }
        //hide password contents
        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            textPass.PasswordChar = '*';
        }
        //enter button event
        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            if (textUser.Text == "")        //chek if empty
            {
                lableNoUser.Visible = true;        //enable "نام کاربری وارد نشده "
            }
            else
            { 
                if (checkVerify())
                {
                    H = new HomeForm();
                    HomeForm.LoginUser = loginUser;
                    H.Show();                           //show home form
                    H.Visible = true;
                    this.Visible = false;               //hide current form
                }
            }
        }
        //hide warning messages
        private void textUser_TextChanged(object sender, EventArgs e)
        {
            lableWrong.Visible = false;                
            lableNoUser.Visible = false;
            btnClear.Visible = true;
            if (textUser.Text == "")
            {
                btnClear.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textUser.Text = "";
            btnClear.Visible = false;
        }

    }
}
