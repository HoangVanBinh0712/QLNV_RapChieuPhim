using System;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;

namespace QLNV_RapChieuPhim
{
    public partial class Login : Form
    {
        static void Main()
        {
            Application.Run(new Login());
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                DataLogin lg = DataLogin.getInstance();
                lg.setUsername(txtUser.Text);
                lg.setPassword(txtPass.Text);
                DBBusiness db = new DBBusiness();
                if (db.connec == true && db.Check_login() == true)
                {
                    mainForm x = new mainForm();
                    this.Hide();
                    x.ShowDialog();
                    this.Show();
                    txtUser.ResetText();
                    txtPass.ResetText();
                    txtUser.Focus();              
                }
                else
                {
                    txtUser.ResetText();
                    txtPass.ResetText();
                    txtUser.Focus();
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
