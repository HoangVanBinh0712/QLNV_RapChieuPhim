using System;
using System.Windows.Forms;

namespace QLNV_RapChieuPhim
{
    public partial class FormLuong : Form
    {
        private LUONGDAO luong;
        protected bool role;
        public FormLuong(LUONGDAO luong,bool role)
        {
            InitializeComponent();
            this.luong = luong;
            this.role = role;
            luongsetup();
        }
        public void luongsetup()
        {
            txtLtl.Enabled = false;
            if (role == false)
            {
                txtLID.Enabled = false;
                tpLdate.Enabled = false;
                txtLsgl.Enabled = false;
                txtLtg.Enabled = false;
                txtLt.Enabled = false;
                txtLtl.Enabled = false;
                btLsua.Enabled = false;
            }
            else {
                txtLID.Enabled = true;
                tpLdate.Enabled = true;
                txtLsgl.Enabled = true;
                txtLtg.Enabled = true;
                txtLt.Enabled = true;
                txtLtl.Enabled = true;
                btLsua.Enabled = true;
            }

        }
        public void load_luong()
        {
            txtLID.Text = luong.getLuongID().ToString();
            tpLdate.Value = luong.getLuongdate();
            txtLsgl.Text = luong.getLuongSogiolam().ToString();
            txtLtg.Text = luong.getLuongLtheogio().ToString();
            txtLt.Text = luong.getLuongThuong().ToString();
            txtLtl.Text = luong.getLuongTongLuong().ToString();
        }
    
        private void btLsua_Click(object sender, EventArgs e)
        {
            DBBusiness db = new DBBusiness();
            string err = "";
            int MaNV, Luongtheogio, Thuong;
            DateTime DAY;
            MaNV = int.Parse(txtLID.Text);
            DAY = tpLdate.Value;
            Luongtheogio = int.Parse(txtLtg.Text);
            Thuong = int.Parse(txtLt.Text);
            DialogResult tl = new DialogResult();
            tl = MessageBox.Show("Ban muon cap nhap?",
                "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LuongAdapter luongAdapter = new LuongAdapter();
            if (tl == DialogResult.Yes)
            {
                if (!luongAdapter.UpdateLuong(ref err, MaNV,Luongtheogio,DAY,Thuong))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                { 
                    MessageBox.Show("Sua thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int x = int.Parse(txtLtg.Text);
                    int y = int.Parse(txtLt.Text);
                    int z = int.Parse(txtLsgl.Text);
                    int thuong = x * z + y;
                    txtLtl.ResetText();
                    txtLtl.Text = thuong.ToString();

                }
            }

        }

        private void txtLtl_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLuong_Load(object sender, EventArgs e)
        {
            load_luong();
        }

    }
}
