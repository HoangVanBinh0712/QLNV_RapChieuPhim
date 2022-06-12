using System;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
using System.Data;
using System.Drawing;
using System.IO;

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
                    DataUser user = DataUser.getInstance();
                    DataSet dataset = db.get1NV(int.Parse(txtUser.Text));
                    NhanVienDAO nhanvien = new NhanVienDAO();
                    nhanvien.setNVid(int.Parse(dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString()));
                    nhanvien.setNVName(dataset.Tables[0].Rows[0].ItemArray.GetValue(1).ToString());
                    nhanvien.setNVBirth(DateTime.Parse(dataset.Tables[0].Rows[0].ItemArray.GetValue(2).ToString()));
                    nhanvien.setNVPnum(dataset.Tables[0].Rows[0].ItemArray.GetValue(3).ToString());
                    nhanvien.setNVEmail(dataset.Tables[0].Rows[0].ItemArray.GetValue(4).ToString());
                    nhanvien.setNVJob(dataset.Tables[0].Rows[0].ItemArray.GetValue(5).ToString());
                    nhanvien.setDRented(DateTime.Parse(dataset.Tables[0].Rows[0].ItemArray.GetValue(6).ToString()));
                    nhanvien.setpassword(dataset.Tables[0].Rows[0].ItemArray.GetValue(7).ToString());
                    Image ig = byteArrayToImage((byte[])dataset.Tables[0].Rows[0].ItemArray.GetValue(8));
                    nhanvien.setNVimg(ig);

                    user.setNhanVien(nhanvien);
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
        //Chuyen tu byte[] sang image
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
